using Microsoft.EntityFrameworkCore;

namespace P2_2020MC601_2020GL601_2020RJ601.Models
{
    public class casos_covidContext : DbContext
    {
        public casos_covidContext(DbContextOptions<casos_covidContext> options) : base(options)
        {

        }

        public DbSet<CasosReportados> CasosReportados { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Generos> Generos { get; set; }
    }
}
