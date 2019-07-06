using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IPTTransportes.Models
{
    public class Utilizadores
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="O nome é de preenchimento obrigatório")]
        [StringLength(30)]
        [RegularExpression("[A-ZÁÉÍÓÚ][a-záéíóúàèìòù]", ErrorMessage = "só são aceites palavras, começadas por maiúsculas," +
            " separadas por um espaço em branco")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O apelido é de preenchimento obrigatório")]
        [StringLength(30)]
        [RegularExpression("[A-ZÁÉÍÓÚ][a-záéíóúàèìòù]", ErrorMessage = "só são aceites palavras, começadas por maiúsculas," +
            " separadas por um espaço em branco")]
        public string Apelido {get; set;}

    }
}