using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ario.CMS.ViewModel.PageGroup;

namespace Ario.CMS.Data.Interfaces.PageGroups
{
    public interface IPageGroup : IDisposable
    {
        List<Models.PageGroups> GetAllGroups();
        Models.PageGroups GetGroupByID(int id);
        string GetGroupNameByID(int id);
        bool InsertGroup(Models.PageGroups pageGroup);
        bool UpdateGroup(Models.PageGroups pageGroup);
        bool DeleteGroup(Models.PageGroups pageGroup);
        bool DeleteGroup(int id);
        bool PageGroupsExists(int id);
        void Save();
    }
}
