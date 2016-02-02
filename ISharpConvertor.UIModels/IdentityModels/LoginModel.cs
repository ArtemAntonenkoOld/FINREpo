using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.UIModels.IdentityModels
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Mail/Phone")]
        public string UserNick { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(100, ErrorMessage = "Мнимальная длина пароля 6 символов.", MinimumLength = 6)]
        public string Password { get; set; }

        //[Display(Name = "Remember me?")]
        //public bool RememberMe { get; set; }
    }
}
