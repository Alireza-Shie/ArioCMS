using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ario.CMS.Data.Context.UnitOfWork;

namespace Ario.CMS.Site.Controllers
{
    public class NewsController : Controller
    {
        private readonly Context db = new Context();

        [Route("Archive")]
        public IActionResult Archive()
        {
            var pages = db.Page.GetAllPages();
            return View(pages);
        }

        [Route("News/{id}/{title}")]
        public IActionResult ShowPage(int id, string title)
        {
            var page = db.Page.GetPageByID(id);
            ViewBag.groupName = db.PageGroup.GetGroupNameByID(db.Page.GetGroupIdByPageId(id)); 
            if (page == null)
            {
                return NotFound();
            }

            page.Visit += 1;
            db.Page.UpdatePage(page);
            db.Page.Save();

            return View(page);
        }

        [Route("Groups/{id}/{title}")]
        public IActionResult ShowGroup(int id, string title)
        {
            var result = db.Page.GetPageByGroupId(id);
            ViewBag.GroupTitle = title;
            if (result == null)
            {
                return NotFound();
            }

            return View(result);
        }
    }
}
