using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteProjeto.Models
{
    public class CadastroVeiculo : Tipo
    {
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo placa é obrigatório.")]
        public string Placa { get; set; }
        public string TipoVeiculo { get; set; }
        
        
        

    }
}