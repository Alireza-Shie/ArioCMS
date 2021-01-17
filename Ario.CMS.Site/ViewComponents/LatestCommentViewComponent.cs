using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ario.CMS.Data.Context.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace Ario.CMS.Site.ViewComponents
{
    public class LatestCommentViewComponent:ViewComponent
    {
        private readonly Context db = new Context();

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(db.PageComment.GetLatestComment());
        }
    }
}
