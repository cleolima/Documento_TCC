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
    public class PessoaDao
    {
        private SqlConnection conexao;

        public PessoaDao()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrar(Pessoa obj)
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

        public void alterar(Pessoa obj)
        {

            string sql = @"update pessoa set " +
               "nome =@nome, rm =@rm, cpf =@cpf, dt_nasc =@dt_nasc, email =@email,  perfil =@perfil, foto =@foto, id_turma =@id_turma where id =@id";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome", obj.Nome);
            comando.Parameters.AddWithValue("@rm", obj.RM);
            comando.Parameters.AddWithValue("@cpf", obj.Cpf);
            comando.Parameters.AddWithValue("@dt_nasc", obj.Dt_Nasc);
            comando.Parameters.AddWithValue("@email", obj.Email);
            comando.Parameters.AddWithValue("@perfil", obj.Perfil);
            comando.Parameters.AddWithValue("@foto", obj.Foto);
            comando.Parameters.AddWithValue("@id_turma", obj.Id_Turma);

            comando.Parameters.AddWithValue("@id", obj.id);

            conexao.Open();

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void excluir(Pessoa obj)
        {
            string sql = @"delete from pessoa where id = @id";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", obj.id);

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

        public DataTable buscarPorNome(Pessoa obj)
        {
            string sql = @"select * from pessoa where nome like '%'+ @nome + '%'";

            SqlCommand executacmdsql = new SqlCommand(sql, conexao);
            executacmdsql.Parameters.AddWithValue("@nome", obj.Nome);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(executacmdsql);
            DataTable tabelaPessoa = new DataTable();
            da.Fill(tabelaPessoa);

            conexao.Close();

            return tabelaPessoa;


        }

        public DataTable buscarPorCpf(Pessoa obj)
        {
            string sql = @"select * from pessoa where cpf like '%'+ @cpf + '%'";

            SqlCommand executacmdsql = new SqlCommand(sql, conexao);
            executacmdsql.Parameters.AddWithValue("@cpf", obj.Cpf);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(executacmdsql);
            DataTable tabelaPessoa = new DataTable();
            da.Fill(tabelaPessoa);

            conexao.Close();

            return tabelaPessoa;


        }

        public Pessoa BuscarPessoaPorCpf(string cpf)
        {
            //  string sql = @"select * from pessoa where cpf = @cpf";
            string sql = @" select pessoa.nome, turma.turma,pessoa.foto,pessoa.id_turma from pessoa, turma where pessoa.id_turma = turma.id and cpf =@cpf";

            SqlCommand executacmdsql = new SqlCommand(sql, conexao);
            executacmdsql.Parameters.AddWithValue("@cpf", cpf);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            SqlDataReader da = executacmdsql.ExecuteReader();

            Pessoa obj = new Pessoa();

            if (da.Read())
            {
                //obj.id = da.GetInt32(0);
                obj.Nome = da.GetString(0);
               // obj.RM = da.GetString(2);
             //   obj.Cpf = da.GetString(3);
              //  obj.Dt_Nasc = da.GetString(4);
              //  obj.Email = da.GetString(5);
               // obj.Perfil = da.GetString(6);
              //  obj.Foto = da.GetString(7);
             //   obj.Id_Turma = da.GetInt32(8);
                obj.Turma = da.GetString(1);
                obj.Foto = da.GetString(2);
                obj.Id_Turma = da.GetInt32(3);

            }

            return obj;


        }

        public Pessoa BuscarPessoaPorEmail(string email)
        {
            string sql = @"select * from pessoa where email = @email";

            SqlCommand executacmdsql = new SqlCommand(sql, conexao);
            executacmdsql.Parameters.AddWithValue("@email", email);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            SqlDataReader da = executacmdsql.ExecuteReader();

            Pessoa obj = new Pessoa();

            if (da.Read())
            {
                obj.id = da.GetInt32(0);
                obj.Nome = da.GetString(1);
                obj.RM = da.GetString(2);
                obj.Cpf = da.GetString(3);
                obj.Dt_Nasc = da.GetString(4);
                obj.Email = da.GetString(5);
                obj.Perfil = da.GetString(6);
                obj.Foto = da.GetString(7);

            }

            return obj;


        }




    }
}
