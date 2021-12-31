using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC2021.br.com.projeto.model;

namespace TCC2021.br.com.projeto.dao
{
    public class UsuarioDao
    {
        private SqlConnection conexao;

        public UsuarioDao()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrarUsuario(Usuario obj)
        {
            string sql = @"insert into usuario(email, senha,perfil)values (@email, @senha, @perfil)";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@email", obj.Email);
            comando.Parameters.AddWithValue("@senha", obj.Senha);
            comando.Parameters.AddWithValue("@perfil", obj.Perfil);


            conexao.Open();

            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }

}
