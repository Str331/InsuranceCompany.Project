using Microsoft.AspNetCore.Cors;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace CompanyProj.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Логин")]
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        [Display(Name ="Пароль")]
        public string Password { get; set; }

        [Display(Name ="Запомнить пароль?")]
        public bool RememberMe { get; set; }
    }
}
