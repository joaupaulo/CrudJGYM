using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaJGYM.Models
{

    [Table("Cadastros")]
    public class Aluno
    {
        public string  Id { get; set; }

        [Display(Name="Aluno")]
        public string Nome { get; set; }

        [Display(Name = " N° Matricula")]
        public  float Matricula { get; set; }


        [Display(Name = " Ultimo Pagamento ")]
        public float Pagamento { get; set; }

        [Display(Name = "Data De Chegada")]
        public DateTime Chegada { get; set; }

    }
}
