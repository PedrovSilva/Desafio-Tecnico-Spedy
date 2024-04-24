using System.ComponentModel.DataAnnotations;

namespace ClassificadosApi.Models
{
    public class Classificado
    {
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Titulo { get; set; }
        [Required]
        [StringLength (2500)]
        public string Descricao { get; set; }
        [Required]
        public  DateTime DataCadastro { get; set; }
        public Classificado() {
            DataCadastro = DateTime.Now; // Preenche automaticamente com a data atual do sistema
        }
    }
}
