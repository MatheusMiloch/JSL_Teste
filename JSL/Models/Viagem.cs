using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JSL.Models
{
    public class Viagem
    {
        public int Id { get; set; }

        [Display(Name = "Data da viagem")]
        public DateTime date {get;set;}

        [Display(Name = "Local da entrega")]
        public string LocalEntrega { get; set; }

        [Display(Name = "Local de saída")]
        public string LocalSaida { get; set; }

        [Display(Name = "Km total da viagem")]
        public int KmTotal { get; set; }

        [Display(Name = "Motorista")]
        public int motoristaId { get; set; }

        public Motorista Motorista { get; set; }

      
                
    }
}
