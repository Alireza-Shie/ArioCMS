using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ario.CMS.Data.Context;
using Ario.CMS.Data.Interfaces.Pages;
using Microsoft.EntityFrameworkCore;

namespace Ario.CMS.Data.Services.Pages
{
    public class Page : IPage
    {
        private ArioCMSContext db;
        public Page(ArioCMSContext context)
        {
            this.db = context;
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public List<Models.Page> GetAllPages()
        {
            return db.Pages.ToList();
        }

        public IEnumerable<Models.Page> TopNews(int take = 4)
        {
            return db.Pages.OrderByDescending(n => n.Visit).Take(take);
        }

        public IEnumerable<Models.Page> GetPageBySlider(int take = 4)
        {
            return db.Pages.Where(p => p.ShowInSlider == true);
        }

        public IEnumerable<Models.Page> GetPageByCerateDate(int take = 4)
        {
            return db.Pages.OrderByDescending(p => p.CreateDate).Take(take);
        }

        public IEnumerable<Models.Page> GetPageByGroupId(int id)
        {
            return db.Pages.Where(p => p.GroupID == id);
        }

        public IEnumerable<Models.Page> GetPageByBeforeWeek(int take = 11)
        {
            return db.Pages.OrderBy(p => p.CreateDate).Take(take);
        }

        public IEnumerable<Models.Page> GetLeastVisitedNews(int take = 5)
        {
            return db.Pages.OrderBy(p => p.Visit).Take(take);
        }

        public Models.Page GetPageByID(int id)
        {
            return db.Pages.Find(id);
        }

        public bool InsertPage(Models.Page page)
        {
            try
            {
                db.Pages.Add(page);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePage(Models.Page page)
        {
            try
            {
                db.Entry(page).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePage(Models.Page page)
        {
            try
            {
                db.Entry(page).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePage(int id)
        {
            try
            {
                var page = GetPageByID(id);
                DeletePage(page);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool PagesExists(int id)
        {
            return db.Pages.Any(e => e.GroupID == id);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
