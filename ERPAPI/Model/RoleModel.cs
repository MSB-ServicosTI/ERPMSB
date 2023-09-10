using System.ComponentModel.DataAnnotations;

namespace ERPAPI.Model
{
    public class RoleModel
    {
        [Required]
        public string Name { get; set; }
    }
}
