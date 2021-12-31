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
    public class AdminstradorDao
    {
        private SqlConnection conexao;

        public AdminstradorDao()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrar(Administrador obj)
        {
            string sql = @"insert into pessoa(nome, rm, cpf,dt_nasc, email, perfil, foto, id_turma) " +
                "values(@nome, @rm, @cpf,@dt_nasc, @email,@perfil,@foto, @id_turma)";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome", obj.Nome);
            comando.Parameters.AddWithValue("@rm", obj.RM);
            comando.Parameters.AddWithValue("@cpf", obj.Cpf);
            comando.Parameters.AddWithValue("@dt_nasc", obj.Dt_Nasc);
            comando.Parameters.AddWithValue("@email", obj.Email);
            comando.Parameters.AddWithValue("@perfil", obj.Perfil);
            comando.Parameters.AddWithValue("@foto", obj.Foto);
            comando.Parameters.AddWithValue("@id_turma", obj.Id_Turma);

            conexao.Open();

            comando.ExecuteNonQuery();
            conexao.Close();


        }

        public DataTable ListarTodasPessoas()
        {
            //string sql = @"select * from pessoa";
            string sql = @"select p.id, p.nome, p.rm, p.cpf, p.dt_nasc, p.email, p.perfil, p.foto, t.turma  from pessoa as p inner join turma t on (p.id_turma = t.id)";




            SqlCommand executacmdsql = new SqlCommand(sql, conexao);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(executacmdsql);
            DataTable tabelaPessoa = new DataTable();
            da.Fill(tabelaPessoa);

            conexao.Close();

            return tabelaPessoa;
        }

    }
}
