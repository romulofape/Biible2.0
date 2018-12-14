using System;
using System.ComponentModel.DataAnnotations;

namespace Biible.Models
{
    public class Referencia
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Data_Cadastro { get; set; }
        [Required]
        public string Descricao { get; set; }
        public string Url { get; set; }
    }
}
