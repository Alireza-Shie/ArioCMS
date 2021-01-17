using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ario.CMS.ViewModel.ManageUser
{
    public class IndexViewModel
    {
        [Key]
        public string ID { get; set; }

        [Display(Name = "نام")]
        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
