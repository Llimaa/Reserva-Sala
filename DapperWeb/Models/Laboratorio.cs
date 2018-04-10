using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DapperWeb.Models
{
    [Table("Laboratorio")]
    public class Laboratorio
    {
        public int ID { get; set; }
        public string  Nome { get; set; }
        public string  Bloco { get; set; }
        public string  Observacao { get; set; }
    }
}