using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPMSB.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Usuário é obrigatório.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória")]
        public string? Password { get; set; }
    }
}
