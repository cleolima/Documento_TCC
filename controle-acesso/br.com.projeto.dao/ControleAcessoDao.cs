using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC2021.br.com.projeto.model;

namespace TCC2021.br.com.projeto.dao
{
    public class ControleAcessoDao
    {
        private SqlConnection conexao;

        public ControleAcessoDao()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrarAcesso(ControleAcesso obj)
        {
            string sql = @"insert into controle_acesso(cpf, nome, turmas, tipo, data )values (@cpf, @nome, @turmas, @tipo, @data)";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@cpf", obj.Cpf);
            comando.Parameters.AddWithValue("@nome", obj.Nome);
            comando.Parameters.AddWithValue("@turmas", obj.Turmas);
            comando.Parameters.AddWithValue("@tipo", obj.Tipo);
            comando.Parameters.AddWithValue("@data", DateTime.Today);
            




            conexao.Open();

            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
