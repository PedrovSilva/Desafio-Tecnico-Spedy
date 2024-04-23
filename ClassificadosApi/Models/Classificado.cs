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
        [StringLength (250)]
        public string Descricao { get; set; }
        [Required]
        public  DateTime Data { get; set; }
        public Classificado() {
            Data = DateTime.Now; // Preenche automaticamente com a data atual do sistema
        }
    }
}
