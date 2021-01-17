using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ario.CMS.Data.Context;
using Ario.CMS.Data.Interfaces.PageGroups;
using Ario.CMS.ViewModel.PageGroup;
using Microsoft.EntityFrameworkCore;

namespace Ario.CMS.Data.Services.PageGroups
{
    public class PageGroup : IPageGroup
    {
        private ArioCMSContext db;
        public PageGroup(ArioCMSContext context)
        {
            this.db = context;
        }
        public List<Models.PageGroups> GetAllGroups()
        {
            return db.PageGroups.ToList();
        }

        public Models.PageGroups GetGroupByID(int id)
        {
            return db.PageGroups.Find(id);
        }

        public string GetGroupNameByID(int id)
        {
            return db.PageGroups.Find(id).GroupTitle;
        }

        public bool InsertGroup(Models.PageGroups pageGroup)
        {
            try
            {
                db.PageGroups.Add(pageGroup);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateGroup(Models.PageGroups pageGroup)
        {
            try
            {
                db.Entry(pageGroup).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteGroup(Models.PageGroups pageGroup)
        {
            try
            {
                db.Entry(pageGroup).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteGroup(int id)
        {
            try
            {
                var pageGroup = GetGroupByID(id);
                DeleteGroup(pageGroup);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool PageGroupsExists(int id)
        {
            return db.PageGroups.Any(e => e.GroupID == id);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
