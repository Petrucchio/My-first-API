using System.ComponentModel.DataAnnotations;

namespace API_User.Models.Users
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "Os dados de login são obrigatórios")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Passsword { get; set; }
    }
}
