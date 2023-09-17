using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPAPI.Model
{
    public class ColaboradorDepartamento
    {
        public string ID { get; set; }
        public int IDDepartamento { get; set; }
    }
}
