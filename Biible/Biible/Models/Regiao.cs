using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Biible.Models
{
    public class Regiao
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Data_Cadastro { get; set; }
        [Required]
        public string Nome { get; set; }
        public List<PassagemBiblica> Passagens_Biblicas { get; set; }
    }
}
