using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ario.CMS.Data.Models;

namespace Ario.CMS.Data.Interfaces.Pages
{
    public interface IPage : IDisposable
    {
        List<Models.Page> GetAllPages();
        IEnumerable<Models.Page> TopNews(int take = 4);
        IEnumerable<Models.Page> GetPageBySlider(int take = 4);
        IEnumerable<Models.Page> GetPageByCreateDate(int take = 4);
        IEnumerable<Models.Page> GetPageByGroupId(int id);
        IEnumerable<Models.Page> GetPageByBeforeWeek(int take = 11);
        IEnumerable<Models.Page> GetLeastVisitedNews(int take = 5);
        IEnumerable<Models.Page> SearchPage(string parameter);
        Models.Page GetPageByID(int id);
        string TopTags();
        int GetGroupIdByPageId(int pageId);
        bool InsertPage(Models.Page page);
        bool UpdatePage(Models.Page page);
        bool DeletePage(Models.Page page);
        bool DeletePage(int id);
        bool PagesExists(int id);
        void Save();
    }
}
