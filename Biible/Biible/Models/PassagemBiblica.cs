using System.ComponentModel.DataAnnotations;

namespace Biible.Models
{
    public class PassagemBiblica
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Livro { get; set; }
        public int Capitulo { get; set; }
        public int Versiculo { get; set; }
    }
}
