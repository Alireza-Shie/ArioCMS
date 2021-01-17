using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ario.CMS.Data.Context;
using Ario.CMS.Data.Context.UnitOfWork;
using Ario.CMS.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Ario.CMS.Site.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class PagesController : Controller
    {
        [BindProperty]
        public IFormFile imgUP { get; set; }
        private readonly Context db = new Context();

        // GET: Admin/Pages
        public IActionResult Index()
        {
            return View(db.Page.GetAllPages());
        }

        // GET: Admin/Pages/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = db.Page.GetPageByID(id.Value);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        // GET: Admin/Pages/Create
        public IActionResult Create()
        {
            ViewBag.GroupID = new SelectList(db.PageGroup.GetAllGroups(), "GroupID", "GroupTitle");
            return View();
        }

        // POST: Admin/Pages/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("PageID,GroupID,PageTitle,ShortDescription,PageText,Visit,Tags,ImageName,ShowInSlider,CreateDate")] Ario.CMS.Data.Models.Page page, [FromServices] IWebHostEnvironment env)
        {
            if (ModelState.IsValid)
            {
                var id = Guid.NewGuid().ToString();
                page.Visit = 0;
                page.CreateDate = DateTime.Now;
                page.ImageName = id + imgUP.FileName;
                var path = Path.Combine(env.WebRootPath, "PageImages", id + imgUP.FileName);
                using (var stream = System.IO.File.Create(path))
                {
                    imgUP.CopyTo(stream);
                }
                db.Page.InsertPage(page);
                db.Page.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.GroupID = new SelectList(db.PageGroup.GetAllGroups(), "GroupID", "GroupTitle");
            return View(page);
        }

        // GET: Admin/Pages/Edit/5
        public IActionResult Edit(int? id, [FromServices] IWebHostEnvironment env)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = db.Page.GetPageByID(id.Value);
            if (page == null)
            {
                return NotFound();
            }

            System.IO.File.Delete(Path.Combine(env.WebRootPath, "PageImages", page.ImageName));

            ViewBag.GroupID = new SelectList(db.PageGroup.GetAllGroups(), "GroupID", "GroupTitle");
            return View(page);
        }

        // POST: Admin/Pages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("PageID,GroupID,PageTitle,ShortDescription,PageText,Visit,Tags,ImageName,ShowInSlider,CreateDate")] Page page, [FromServices] IWebHostEnvironment env)
        {
            if (id != page.PageID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string pageImgName = page.ImageName;
                    page.ImageName = pageImgName;
                    var path = Path.Combine(env.WebRootPath, "PageImages", pageImgName);
                    using (var stream = System.IO.File.Create(path))
                    {
                        imgUP.CopyTo(stream);
                    }

                    page.ImageName = pageImgName;
                    db.Page.UpdatePage(page);
                    db.Page.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PageExists(page.PageID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(page);
        }

        // GET: Admin/Pages/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = db.Page.GetPageByID(id.Value);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        // POST: Admin/Pages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id, [FromServices] IWebHostEnvironment env)
        {
            var page = db.Page.GetPageByID(id);
            db.Page.DeletePage(page);
            if (page.ImageName != null)
            {
                var path = Path.Combine(env.WebRootPath, "PageImages", page.ImageName);
                System.IO.File.Delete(path);
            }
            db.Page.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool PageExists(int id)
        {
            return db.Page.PagesExists(id);
        }
    }
}
