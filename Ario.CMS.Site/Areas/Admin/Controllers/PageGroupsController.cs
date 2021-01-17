using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ario.CMS.Data.Context;
using Ario.CMS.Data.Context.UnitOfWork;
using Ario.CMS.Data.Models;
using Microsoft.AspNetCore.Authorization;

namespace Ario.CMS.Site.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class PageGroupsController : Controller
    {
        private readonly Context db = new Context();


        // GET: Admin/PageGroups
        public IActionResult Index()
        {
            return View(db.PageGroup.GetAllGroups());
        }

        // GET: Admin/PageGroups/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageGroups = db.PageGroup.GetGroupByID(id.Value);
            if (pageGroups == null)
            {
                return NotFound();
            }

            return View(pageGroups);
        }

        // GET: Admin/PageGroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/PageGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("GroupID,GroupTitle")] PageGroups pageGroups)
        {
            if (ModelState.IsValid)
            {
                db.PageGroup.InsertGroup(pageGroups);
                db.PageGroup.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(pageGroups);
        }

        // GET: Admin/PageGroups/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageGroups = db.PageGroup.GetGroupByID(id.Value);
            if (pageGroups == null)
            {
                return NotFound();
            }
            return View(pageGroups);
        }

        // POST: Admin/PageGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("GroupID,GroupTitle")] PageGroups pageGroups)
        {
            if (id != pageGroups.GroupID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.PageGroup.UpdateGroup(pageGroups);
                    db.PageGroup.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PageGroupsExists(pageGroups.GroupID))
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
            return View(pageGroups);
        }

        // GET: Admin/PageGroups/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageGroups = db.PageGroup.GetGroupByID(id.Value);
            if (pageGroups == null)
            {
                return NotFound();
            }

            return View(pageGroups);
        }

        // POST: Admin/PageGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var pageGroups = db.PageGroup.GetGroupByID(id);
            db.PageGroup.DeleteGroup(pageGroups);
            db.PageGroup.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool PageGroupsExists(int id)
        {
            return db.PageGroup.PageGroupsExists(id);
        }
    }
}
