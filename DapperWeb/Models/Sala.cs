using Dapper.Contrib.Extensions;


namespace DapperWeb.Models
{
  [Table("Sala")]
    public class Sala
    {
        public int ID { get; set; }
        public string BlocoSala { get; set; }
        public string Nome { get; set; }
        public string  Observacao { get; set; }
    }
}