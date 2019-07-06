using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IPTTransportes.Models
{
    public class Gestor
    {
        public int Id { get; set; }

        [ForeignKey("Utilizadorfk")]
        public Utilizadores Utilizador { get; set; }
        public int Utilizadorfk { get; set; }
    }
}