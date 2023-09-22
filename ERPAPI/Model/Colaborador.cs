using ERPCommon;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Riok.Mapperly.Abstractions;
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

    [Mapper(PropertyNameMappingStrategy = PropertyNameMappingStrategy.CaseInsensitive)]
    public static partial class ColaboradorMapper
    {
        public static partial ColaboradorDTO ColaboradorToColaboradorDTO(Colaborador colaborador);
        public static partial IQueryable<ColaboradorDTO> ProjectToDTO(this IQueryable<Colaborador> q);
        public static partial List<ColaboradorDTO> ProjectToDTO(this List<Colaborador> q);
    }
}

