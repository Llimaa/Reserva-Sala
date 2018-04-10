using Dapper;
using Dapper.Contrib.Extensions;
using DapperWeb._1_Infra;
using DapperWeb.AcessBanco;
using DapperWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DapperWeb._2_Dapper
{
    public class TipoSala : IDapper<Sala>
    {
        private SqlConnection _con;
        Sala _sala = new Sala();
        public TipoSala()
        {
            SqlServe _conexao = new SqlServe();
            _con = _conexao.ConexaoBanco();
        }
        public Sala BuscarPorID(int Id)
        {
            _con.Open();
            _sala = _con.Get<Sala>(Id);
            _con.Close();
            return _sala;
        }

        public bool Delete(int id, Sala item)
        {
            _con.Open();
            var a = _con.Delete<Sala>(item = new Sala { ID = id, BlocoSala = "", Nome = "",Observacao="" });
            _con.Close();
            return a;
        }

        public int insert(Sala item)
        {
            _con.Open();
            _con.Insert(item);
            _con.Close();
            return Convert.ToInt16(true);
        }

        public IEnumerable<Sala> listar()
        {
            IEnumerable<Sala> _listar;
            _con.Open();
            _listar = _con.Query<Sala>("Select * from Sala order by Nome,BlocoSala;");
            return _listar;

        }

        public bool Update(Sala item)
        {
            _con.Open();
            bool Sala = _con.Update(item);
            _con.Close();
            return Sala;
        }
    }
}