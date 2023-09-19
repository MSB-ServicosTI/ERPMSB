using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ERPAPI.Model
{
    public class Departamento : IdentityRole
    {
        [Required]
        public string Nome { get; set; }
        public string? ResponsavelID { get; set; }
    }
}
