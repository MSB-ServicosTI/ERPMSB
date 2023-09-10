using System.ComponentModel.DataAnnotations;

namespace ERPAPI.Model
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Usuário é obrigatório.")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "E-Mail é obrigatório")]
        public string? EmailAddress { get; set;}

        [Required(ErrorMessage = "Senha é obrigatória")]
        public string? Password { get; set; }
    }
}
