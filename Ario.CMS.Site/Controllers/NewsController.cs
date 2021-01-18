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
    }
}
