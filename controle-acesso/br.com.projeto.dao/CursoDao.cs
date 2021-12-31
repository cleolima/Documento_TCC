using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC2021.br.com.projeto.model;

namespace TCC2021.br.com.projeto.dao
{
    public class CursoDao
    {
        private SqlConnection conexao;

        public CursoDao()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrar(Curso obj)
        {
            string sql = @"insert into curso(descricao) values(@descricao)";
           

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@descricao", obj.Descricao);
            

            conexao.Open();

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void alterar(Curso obj)
        {

            string sql = @"update curso set descricao =@descricao where id =@id";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@descricao", obj.Descricao);
           

            comando.Parameters.AddWithValue("@id", obj.id);

            conexao.Open();

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void excluir(Curso obj)
        {
            string sql = @"delete from curso where id = @id";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", obj.id);

            conexao.Open();

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public DataTable ListarTodosCursos()
        {
            string sql = @"select * from curso";

            SqlCommand executacmdsql = new SqlCommand(sql, conexao);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(executacmdsql);
            DataTable tabelaCurso = new DataTable();
            da.Fill(tabelaCurso);

            conexao.Close();

            return tabelaCurso;
        }
    }
}
