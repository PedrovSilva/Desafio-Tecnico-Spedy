using ClassificadosApi.Context;
using ClassificadosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassificadosApi.Services
{
    public class ClassificadoServices : IClassificadoServices
    {
        private readonly AppDbContext _context;

        public ClassificadoServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateClassificado(Classificado Classificado)
        {
            _context.Classificados.Add(Classificado);
            await _context.SaveChangesAsync();
        }

        public async Task<Classificado> GetClassificado(int Id)
        {
            var classificado = await _context.Classificados.FindAsync(Id);
            return classificado;
        }

        public async Task<IEnumerable<Classificado>> GetClassificados()
        {
            return await _context.Classificados.ToListAsync();
        }

        public async Task<IEnumerable<Classificado>> GetClassificadosByData()
        {
            return await _context.Classificados.OrderByDescending(n=> n.Data).ToListAsync();
        }

        public async Task<IEnumerable<Classificado>> GetClassificadosByTitulo(string titulo)
        {
            IEnumerable<Classificado> classificados;
            if (!string.IsNullOrWhiteSpace(titulo))
            {
                classificados = await _context.Classificados.Where(n=> n.Titulo.Contains(titulo)).ToListAsync();
            }
            else 
            { 
                classificados = await GetClassificados();
            }
            return classificados;
        } 
    }
}
