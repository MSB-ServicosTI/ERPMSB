using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPGarcia.Model
{
    internal class RoleModel
    {
        [Required]
        public string Name { get; set; }
    }
}
