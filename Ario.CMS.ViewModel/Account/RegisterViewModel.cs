using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ario.CMS.ViewModel.Account
{
    public class RegisterViewModel
    {
        [Key]
        public int UserID { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(300)]
        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [MaxLength(300)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Email { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Password { get; set; }

        [Display(Name = "تکرار رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
