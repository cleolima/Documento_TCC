using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC2021.br.com.projeto.dao
{
    public class ConnectionFactory
    {
        public SqlConnection getConnection()
        {
            try
            {
                string conexao = ConfigurationManager.ConnectionStrings["bdtcc2021"].ConnectionString;
                return new SqlConnection(conexao);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao conectar: " + erro);
                return null;
            }
        }
    }
}
