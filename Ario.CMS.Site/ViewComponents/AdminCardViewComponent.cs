﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ario.CMS.Data.Context.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace Ario.CMS.Site.ViewComponents
{
    public class AdminCardViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
