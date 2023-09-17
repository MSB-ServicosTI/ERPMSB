using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ERPAPI.Model
{
    public class Colaborador : IdentityUser
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public TipoContrato TipoContrato { get; set; }
    }

    public enum TipoContrato
    {
        PJ = 0,
        CLT = 1,
        Cooperativo = 2,
    }
}
