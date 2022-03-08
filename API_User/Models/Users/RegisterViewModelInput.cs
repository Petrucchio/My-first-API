using System.ComponentModel.DataAnnotations;

namespace API_User.Models.Users
{
    public class RegisterViewModelInput
    {
        [Required(ErrorMessage = "Os dados de login são obrigatórios")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Passsword { get; set; }
        [Required(ErrorMessage = "O Email é obrigatório")]
        public string Email { get; set; }
    }
}
