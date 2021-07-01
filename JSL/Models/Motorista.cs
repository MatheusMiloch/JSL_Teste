using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JSL.Models
{
    public class Motorista
    {
        public int Id { get; set; }

        [Display(Name = "Nome do motorista")]
        public string nomeMotorista { get; set; }

        [Display(Name = "Endereço")]
        public string enderecoMotorista { get; set; }

        [Display(Name = "Cidade")]
        public string cidadeMotorista { get; set; }

        [Display(Name = "Estado")]
        public string estadoMotorista { get; set; }

        [Display(Name = "Marca")]
        public string marcaCaminhao { get; set; }

        [Display(Name = "Modelo")]
        public string modeloCaminhao { get; set; }

        [Display(Name = "Placa")]
        public string placaCaminhao { get; set; }

        [Display(Name = "Eixos")]
        public int qntEixos { get; set; }

        
    }
}
