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
    public class TipoLaboratorio : IDapper<Laboratorio>
    {
        private SqlConnection _con;
        public TipoLaboratorio()
        {
            SqlServe Conexao = new SqlServe();
            _con = Conexao.ConexaoBanco();
        }
        public Laboratorio BuscarPorID(int Id)
        {
            Laboratorio _lab = new Laboratorio();
            _con.Open();
            _lab = _con.Get<Laboratorio>(Id);
            _con.Close();
            return _lab;
        }

        public bool Delete(int id, Laboratorio item)
        {
            _con.Open();
            var a = _con.Delete<Laboratorio>(item = new Laboratorio { ID = id, Bloco = "", Nome = "", Observacao = "" });
            _con.Close();
            return a;
        }

        public int insert(Laboratorio item)
        {
            _con.Open();
            _con.Insert(item);
            _con.Close();
            return Convert.ToInt16(true);

        }

        public IEnumerable<Laboratorio> listar()
        {
            IEnumerable<Laboratorio> _listar;
            _con.Open();
            _listar = _con.Query<Laboratorio>("Select * from Laboratorio order by Bloco,Nome;");
            _con.Close();
            return _listar;
        }

        public bool Update(Laboratorio item)
        {
            _con.Open();
            bool Laboratorio = _con.Update(item);
            _con.Close();
            return Laboratorio;
        }
    }
}