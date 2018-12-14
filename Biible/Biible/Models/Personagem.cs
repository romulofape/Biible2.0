using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biible.Models
{
    public class Personagem
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Data_Cadastro { get; set; }
        [Required]
        public string Nome { get; set; }
        public int Ano_Inicio { get; set; }
        public int Ano_Fim { get; set; }
        public bool Ano_Inicio_Incerto { get; set; }
        public bool Ano_Fim_Incerto { get; set; }
        public bool Ano_Inicio_AcDc { get; set; }
        public bool Ano_Fim_AcDc { get; set; }
        public int Curtida { get; set; }
        public byte Foto { get; set; }
        public string Usuario_Cadastro { get; set; }
        public string Etnia { get; set; }
        public string Referencia { get; set; }

        public List<Genealogia> Genealogias { get; set; }
        public List<Outro_Nome> Outros_Nomes { get; set; }
        public List<Curiosidade> Curiosidades { get; set; }
        public List<Referencia> Referencias { get; set; }
        public List<Regiao> Regioes { get; set; }
    }
}
