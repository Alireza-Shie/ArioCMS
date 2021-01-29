using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ario.CMS.Data.Context.UnitOfWork;

namespace Ario.CMS.Site.Controllers
{
    public class SearchController : Controller
    {
        private readonly Context db = new Context();

        public IActionResult Search(string q)
        {
            ViewBag.Query = q;
            var pages = db.Page.SearchPage(q);
            return View(pages);
        }
    }
}
