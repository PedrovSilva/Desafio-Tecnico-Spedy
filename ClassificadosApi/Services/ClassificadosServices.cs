using ClassificadosApi.Models;

namespace ClassificadosApi.Services
{
    public class ClassificadosServices : IClassificadoService
    {
        public async Task CreateClassificado(Classificado Classificado)
        {
            throw new NotImplementedException();
        }

        public async Task<Classificado> GetClassificado(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Classificado>> GetClassificados()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Classificado>> GetClassificadosByDate(DateTime data)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Classificado>> GetClassificadosByTitulo(string titulo)
        {
            throw new NotImplementedException();
        }
    }
}
