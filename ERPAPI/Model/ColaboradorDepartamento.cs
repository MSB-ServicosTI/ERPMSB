using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPAPI.Model
{
    public class ColaboradorDepartamento
    {
        public string IDColaborador { get; set; }
        public string IDDepartamento { get; set; }
    }
}
