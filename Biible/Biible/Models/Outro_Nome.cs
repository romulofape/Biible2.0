using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biible.Models
{
    public class Outro_Nome
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Data_Cadastro { get; set; }
        [Required]
        public string Nome { get; set; }
        public int Ano { get; set; }
        public List<PassagemBiblica> Passagens_Biblicas { get; set; }
    }
}
