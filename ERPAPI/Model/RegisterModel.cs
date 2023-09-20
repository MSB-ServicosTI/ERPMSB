using System.ComponentModel.DataAnnotations;

namespace ERPAPI.Model
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Usuário é obrigatório.")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "E-Mail é obrigatório")]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "O nome do colaborador é obrigatório")]
        public string NomeColaborador { get; set; }

        [Required(ErrorMessage = "A data de nascimento do colaborador é obrigatório")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "O tipo de contratação é obrigatório")]
        public TipoContrato TipoContrato { get; set; }
    }

    public class RegisterModelUserToRole
    {
        [Required(ErrorMessage = "Especificar o usuário ao qual será adicionado ao departamento é obrigatório.")]
        public string ColaboradorId { get; set; }
        [Required(ErrorMessage = "Especificar o departamento ao qual o usuário será adicionado é obrigatório.")]
        public string DepartamentoId { get; set; }
    }
}
