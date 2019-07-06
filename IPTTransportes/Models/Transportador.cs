using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IPTTransportes.Models
{
    public class Transportador
    {
        public int Id { get; set; }

        public string Fotografia { get; set; }

        [ForeignKey("Utilizadorfk")]
        public Utilizadores Utilizador { get; set; }
        public int Utilizadorfk { get; set; }
        [ForeignKey("Transportadorafk")]
        public Transportadora Transportadora { get; set; }
        public int Transportadorafk { get; set; }
    }
}