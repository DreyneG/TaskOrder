using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
namespace TaskOrder.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o e-mail")]
        [Display(Name = "E-mail")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Informe a senha")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}