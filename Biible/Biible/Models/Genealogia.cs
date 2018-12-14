using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biible.Models
{
    public class Genealogia
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Data_Cadastro { get; set; }
        [Required]
        public int IdPersonagem1 { get; set; }
        [Required]
        public int IdPersonagem2 { get; set; }
        public List<PassagemBiblica> Passagens_Biblicas { get; set; }
    }
}
