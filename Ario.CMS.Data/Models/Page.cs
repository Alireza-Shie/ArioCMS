using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ario.CMS.Data.Models
{
    public class Page
    {
        [Key] public int PageID { get; set; }

        [Display(Name = "گروه صفحه")]
        public int GroupID { get; set; }

        [Display(Name = "عنوان صفحه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string PageTitle { get; set; }

        [Display(Name = "توضیح کوتاه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
        public string ShortDescription { get; set; }

        [Display(Name = "متن صفحه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
        public string PageText { get; set; }

        [Display(Name = "بازدید")]
        public int Visit { get; set; }

        [Display(Name = "کلمات کلیدی")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Tags { get; set; }

        [Display(Name = "تصویر")]
        public string ImageName { get; set; }

        [Display(Name = "در اسلاید نمایش داده شود ؟")]
        public bool ShowInSlider { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        public DateTime CreateDate { get; set; }

        //Relations
        public virtual PageGroups PageGroup { get; set; }
        public virtual ICollection<PageComment> PageComments { get; set; }
        public Page()
        {

        }
    }
}
