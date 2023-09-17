using System.ComponentModel.DataAnnotations;

namespace ERPAPI.Model
{
    public class Departamento
    {
        [Key]
        public int IDDepartamento { get; set; }
        public string Nome { get; set; }
    }
}
