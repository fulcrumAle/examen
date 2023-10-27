using System.ComponentModel.DataAnnotations;

namespace practicadetaller.Models
{
    public class Musica
    {
        [Key]
        public int idMusica { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Numero_reproducciones { get; set; }
        public int idDisco { get; set; }
    }
}