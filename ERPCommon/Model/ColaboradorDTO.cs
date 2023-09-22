using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCommon
{
    public class ColaboradorDTO
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public TipoContrato TipoContrato { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public enum TipoContrato
    {
        PJ = 0,
        CLT = 1,
        Cooperativo = 2,
    }

    public class ColaboradorUserEmail
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
    }

    public class EsqueciMinhaSenha
    {
        public string ColaboradorId { get; set; }
        public Guid CodigoConfirmacao { get; set; }
        public bool JaUtilizado { get; set; }
    }
}
