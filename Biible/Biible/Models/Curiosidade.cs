using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biible.Models
{
    public class Curiosidade
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Data_Cadastro { get; set; }
        [Required]
        public string Descricao { get; set; }
        public int Curtida { get; set; }
        public List<PassagemBiblica> Passagens_Biblicas { get; set; }
    }
}
