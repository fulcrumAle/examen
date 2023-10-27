using System.ComponentModel.DataAnnotations;

namespace practicadetaller.Models
{
    public class Disco
    {
        [Key]
        public int idDisco { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
    }
}