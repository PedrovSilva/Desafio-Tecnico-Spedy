using ClassificadosApi.Models;

namespace ClassificadosApi.Services
{
    public interface IClassificadoService
    {
        Task<IEnumerable<Classificado>> GetClassificados();
        Task<Classificado> GetClassificado(int Id);
        Task<IEnumerable<Classificado>> GetClassificadosByTitulo(string titulo);
        Task <IEnumerable<Classificado>> GetClassificadosByDate(DateTime data);
        Task CreateClassificado(Classificado Classificado);
    }
}
