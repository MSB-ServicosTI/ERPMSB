using ERPAPI.Model;
using ERPCommon;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ERPAPI.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ColaboradorDepartamento>().HasKey(cd => new { cd.IDColaborador, cd.IDDepartamento });
            builder.Entity<EsqueciMinhaSenha>().HasKey(ems => new { ems.CodigoConfirmacao });
        }

        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<ColaboradorDepartamento> ColaboradoresDepartamentos { get; set; }
        public DbSet<EsqueciMinhaSenha> EsqueciMinhaSenha { get; set; }

    }
}
