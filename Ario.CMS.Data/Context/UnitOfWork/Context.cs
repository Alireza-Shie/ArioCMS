using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ario.CMS.Data.Interfaces.PageComment;
using Ario.CMS.Data.Interfaces.PageGroups;
using Ario.CMS.Data.Interfaces.Pages;
using Ario.CMS.Data.Services.PageComment;
using Ario.CMS.Data.Services.PageGroups;
using Ario.CMS.Data.Services.Pages;
using Microsoft.EntityFrameworkCore;

namespace Ario.CMS.Data.Context.UnitOfWork
{
    public class Context
    {
        private ArioCMSContext _context = new ArioCMSContext(new DbContextOptions<ArioCMSContext>());
        private IPageGroup _pageGroup;
        private IPage _page;
        private IPageComment _pageComment;

        public IPageGroup PageGroup
        {
            get
            {
                if (_pageGroup == null)
                {
                    _pageGroup = new PageGroup(_context);
                }

                return _pageGroup;
            }
        }

        public IPage Page
        {
            get
            {
                if (_page == null)
                {
                    _page = new Page(_context);
                }

                return _page;
            }
        }

        public IPageComment PageComment
        {
            get
            {
                if (_pageComment == null)
                {
                    _pageComment = new PageComment(_context);
                }

                return _pageComment;
            }
        }
    }
}
