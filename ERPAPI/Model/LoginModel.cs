using System.ComponentModel.DataAnnotations;

namespace ERPAPI.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Usuário é obrigatório.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória")]
        public string? Password { get; set; }
    }
}
