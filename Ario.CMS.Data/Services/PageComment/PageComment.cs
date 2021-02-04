using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ario.CMS.Data.Context;
using Ario.CMS.Data.Interfaces.PageComment;

namespace Ario.CMS.Data.Services.PageComment
{
    public class PageComment : IPageComment
    {
        private ArioCMSContext _context;
        public PageComment(ArioCMSContext context)
        {
            _context = context;
        }

        public IEnumerable<Models.PageComment> GetLatestComment(int take = 6)
        {
            return _context.PageComments.OrderByDescending(o => o.DateTime).Take(take).ToList();
        }

        public IEnumerable<Models.PageComment> GetAllCommentsByPageId(int pageId)
        {
            return _context.PageComments.OrderByDescending(p=>p.DateTime).Where(c => c.PageID == pageId).ToList();
        }

        public bool InsertComment(Models.PageComment comment)
        {
            try
            {
                _context.PageComments.Add(comment);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
