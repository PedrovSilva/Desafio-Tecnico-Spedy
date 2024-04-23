using ClassificadosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassificadosApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        } 
        public DbSet<Classificado> Classificados { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classificado>().HasData(
                new Classificado
                {
                    Id = 1,
                    Titulo = "Teste 1",
                    Descricao = "Descricao teste teste teste"
                },
                new Classificado
                {
                    Id = 2,
                    Titulo = "Teste 2",
                    Descricao = "teste Descriao"
                }
                );
        }
    }
}
