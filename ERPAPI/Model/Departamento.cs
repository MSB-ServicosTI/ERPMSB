using ERPCommon;
using Microsoft.AspNetCore.Identity;
using Riok.Mapperly.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace ERPAPI.Model
{
    public class Departamento : IdentityRole
    {
        [Required]
        public string Nome { get; set; }
        public string? ResponsavelID { get; set; }
    }

    [Mapper(PropertyNameMappingStrategy = PropertyNameMappingStrategy.CaseInsensitive)]
    public static partial class DepartamentoMapper
    {
        public static partial DepartamentoDTO DepartamentoToDepartamentoDTO(Departamento departamento);
        public static partial IQueryable<DepartamentoDTO> ProjectToDTO(this IQueryable<Departamento> q);
        public static partial List<DepartamentoDTO> ProjectToDTO(this List<Departamento> q);
    }
}
