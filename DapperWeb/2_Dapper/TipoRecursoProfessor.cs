using Dapper.Contrib.Extensions;
using DapperWeb.AcessBanco;
using DapperWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DapperWeb._1_Infra.Dapper
{
    public class TipoRecursoProfessor : IDapper<Professor>
    {
        private SqlConnection _con;
        public TipoRecursoProfessor()
        {
            SqlServe _serve = new SqlServe();
            _con = _serve.ConexaoBanco();
            
        }

        public Professor BuscarPorID(int Id)
        {
            _con.Open();
            _con.Close();
            return listar().Where(l => l.ID == Id).FirstOrDefault();

        }

        public bool Delete(int id, Professor item)
        {

            _con.Open();
            var a = _con.Delete(item = new Professor() { ID = id, Nome = "", Disciplina = "", CodIdentificacao= "" });
            _con.Close();
            return a;
        }

        public int insert(Professor item)
        {
            try
            {
                _con.Open();
                _con.Insert(item);
                _con.Close();
                return Convert.ToInt16(true);
            }
            catch
            {
                return Convert.ToInt16(false);
            }
        }

        public IEnumerable<Professor> listar()
        {
            IEnumerable<Professor> _lista;

            try
            {
                _con.Open();
                _lista = _con.GetAll<Professor>();
                _con.Close();
                return _lista;


            }
            catch
            {
                return null;
            }
        }
       
            public bool Update(Professor item)
            {
                _con.Open();
            bool professor=_con.Update(item);
                _con.Close();
            return professor;
            }
        
    }
}