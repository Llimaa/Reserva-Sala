using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace DapperWeb.Models
{
    [Table("Professor")]
    public class Professor
    {
        public int ID { get; set; }
        [Display(Name ="Codigo de Identificaçao")]
        public string CodIdentificacao { get; set; }
        public string Nome { get; set; }
        public string  Disciplina { get; set; }
    }
}