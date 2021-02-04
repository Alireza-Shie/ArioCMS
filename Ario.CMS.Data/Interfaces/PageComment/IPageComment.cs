using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ario.CMS.Data.Interfaces.PageComment
{
    public interface IPageComment
    {
        IEnumerable<Models.PageComment> GetLatestComment(int take = 6);
        IEnumerable<Models.PageComment> GetAllCommentsByPageId(int pageId);
        bool InsertComment(Models.PageComment comment);
    }
}
