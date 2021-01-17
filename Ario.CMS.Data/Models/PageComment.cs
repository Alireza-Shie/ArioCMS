using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ario.CMS.Data.Models
{
    public class PageComment
    {
        [Key]
        public int CommentID { get; set; }

        [Display(Name = "خبر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int PageID { get; set; }

        [Display(Name = "نام خبر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string PageTitle { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string Name { get; set; }

        [Display(Name = "ایمیل")]
        [MaxLength(150)]
        public string Email { get; set; }

        [Display(Name = "متن نظر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string CommentText { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        public DateTime DateTime { get; set; }

        //Relations
        public virtual Page Page { get; set; }
        public PageComment()
        {

        }
    }
}
