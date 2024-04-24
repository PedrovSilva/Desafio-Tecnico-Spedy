using ClassificadosApi.Models;

namespace ClassificadosApi.Services
{
    public interface IClassificadoServices
    {
        Task<Classificado> GetClassificado(int Id);
        Task <IEnumerable<Classificado>> GetClassificadosByData();
        Task CreateClassificado(Classificado Classificado);
    }
}
