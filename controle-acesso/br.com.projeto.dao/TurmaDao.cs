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
    public class TurmaDao
    {
        private SqlConnection conexao;

        public TurmaDao()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrarTurma(Turma obj)
        {
            string sql = @"insert into turma(id_curso, turma, periodo)values (@id_curso, @turma, @periodo)";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id_curso", obj.Curso_id);
            comando.Parameters.AddWithValue("@turma", obj.Turmas);
            comando.Parameters.AddWithValue("@periodo", obj.Periodo);          




            conexao.Open();

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void alterarTurma(Turma obj)
        {

            string sql = @"update turma set id_curso =@id_curso, turma =@turma, periodo =@periodo where id =@id";
			
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id_curso", obj.Curso_id);
            comando.Parameters.AddWithValue("@turma", obj.Turmas);
            comando.Parameters.AddWithValue("@periodo", obj.Periodo);
            



            comando.Parameters.AddWithValue("@id", obj.id);

            conexao.Open();

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void deletarTurma(Turma obj)
        {
            string sql = @"delete from turma where id = @id";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", obj.id);

            conexao.Open();

            comando.ExecuteNonQuery();
            conexao.Close();


        }

        public DataTable ListarTodasTurmas()
        {
            string sql = @"select t.id, c.descricao as 'curso', t.turma, t.periodo from turma as t inner join curso c on(t.id_curso = c.id)";

            SqlCommand executacmdsql = new SqlCommand(sql, conexao);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(executacmdsql);

            DataTable tabelaTurma = new DataTable();
            da.Fill(tabelaTurma);

            conexao.Close();

            return tabelaTurma;
        }


    }
}
