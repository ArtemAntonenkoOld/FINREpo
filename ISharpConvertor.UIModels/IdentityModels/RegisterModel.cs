using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.UIModels.IdentityModels
{
    public class RegisterModel
    {

        [Required]
        [Display(Name = "Email")]

        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Не верный мейл адрес")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Мнимальная длина пароля 6 символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают.")]
        public string ConfirmPassword { get; set; }
    }
}
