using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DapperWeb.AcessBanco
{
    public class SqlServe
    {
        public SqlConnection ConexaoBanco()
        {
            return new SqlConnection(@"server=MARCOS-PC\SQLEXPRESS; database=ReservaSala; User Id =root; Password=123;");
        }
    }
}