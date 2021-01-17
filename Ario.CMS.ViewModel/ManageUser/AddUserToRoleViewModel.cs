using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ario.CMS.ViewModel.ManageUser
{
    public class AddUserToRoleViewModel
    {
        public AddUserToRoleViewModel()
        {
            UserRoles = new List<UserRolesViewModel>();
        }

        public string UserId { get; set; }

        public List<UserRolesViewModel> UserRoles { get; set; }
    }

    public class UserRolesViewModel
    {
        public string RoleName { get; set; }
        public bool IsSelected { get; set; }
    }
}
