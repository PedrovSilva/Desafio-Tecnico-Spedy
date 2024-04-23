using ClassificadosApi.Models;

namespace ClassificadosApi.Services
{
    public interface IClassificadoServices
    {
        Task<IEnumerable<Classificado>> GetClassificados();
        Task<Classificado> GetClassificado(int Id);
        Task<IEnumerable<Classificado>> GetClassificadosByTitulo(string titulo);
        Task <IEnumerable<Classificado>> GetClassificadosByData();
        Task CreateClassificado(Classificado Classificado);
    }
}
