using Dapper;
using Dapper.Contrib.Extensions;
using DapperWeb._1_Infra;
using DapperWeb.AcessBanco;
using DapperWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DapperWeb._2_Dapper
{
     
    public class TipoCaixaSom : IDapper<CaixaSom>
    {
        private SqlConnection _con;
        public TipoCaixaSom()
        {
            SqlServe _conexao = new SqlServe();
            _con = _conexao.ConexaoBanco();
        }
        public CaixaSom BuscarPorID(int Id)
        {
            CaixaSom _Som = new CaixaSom();
            _con.Open();
            _Som=_con.Get<CaixaSom>(Id);
            _con.Close();
            return _Som;
        }

        public bool Delete(int id, CaixaSom item)
        {
            _con.Open();
            var a = _con.Delete<CaixaSom>(item = new CaixaSom { ID = id, Descricao = "", Observacao = "" });
            _con.Close();
            return a;
          
        }

        public int insert(CaixaSom item)
        {
            _con.Open();
            _con.Insert(item);
            _con.Close();
            return Convert.ToInt16(true);
        }

        public IEnumerable<CaixaSom> listar()
        {
            IEnumerable<CaixaSom> _listar;
            _con.Open();
            _listar = _con.Query<CaixaSom>("Select * from CaixaSom order by Descicao,Observacao;");
            _con.Close();
            return _listar;
        }

        public bool Update(CaixaSom item)
        {
            _con.Open();
            bool CaixaSom = _con.Update(item);
            _con.Close();
            return CaixaSom;
        }
    }
}