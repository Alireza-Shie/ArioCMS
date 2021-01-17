using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ario.CMS.Data.Models
{
    public class PageGroups
    {
        [Key]
        public int GroupID { get; set; }
        [Display(Name = "عنوان گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(300)]
        public string GroupTitle { get; set; }

        //Relations
        public virtual ICollection<Page> Pages { get; set; }
        public PageGroups()
        {

        }
    }
}
