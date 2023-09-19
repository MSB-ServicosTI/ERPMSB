using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPMSB.Model
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
    }
}
