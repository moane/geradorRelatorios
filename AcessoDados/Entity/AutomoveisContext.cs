using AcessoDados.Entity.Models;
using System.Data.Entity;


namespace AcessoDados.Entity
{
    public class AutomoveisContext : DbContext
    {
        public AutomoveisContext() : base("name = AutomoveisContextDB")
        {
        }

        public DbSet<LogExecucao> LogExecucao { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }

    }
}