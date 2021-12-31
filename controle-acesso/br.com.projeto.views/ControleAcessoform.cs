using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC2021.br.com.projeto.dao;
using TCC2021.br.com.projeto.model;

namespace TCC2021.br.com.projeto.views
{
    public partial class ControleAcessoform : Form
    {
        
        public ControleAcessoform()
        {
            InitializeComponent();
          
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ControleAcessoform_Load(object sender, EventArgs e)
        {
            //txtdata.Text = DateTime.Now.ToShortDateString();
            txtdata.Text = DateTime.Now.ToString();
        }

        private void Txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Pessoa obj = new Pessoa();
                PessoaDao dao = new PessoaDao();

                obj = dao.BuscarPessoaPorCpf(txtcpf.Text);

                if (obj.Nome != null )
                {
                    txtnome.Text = obj.Nome;
                    txtturma.Text = obj.Turma;
                    string foto = obj.Foto;
                    int codigo_turma = obj.Id_Turma;
                    pb_foto.ImageLocation = @"C:\Users\Cleonice\Desktop\TCC2021\foto\" + foto+".png";
                    

                }
                else
                {
                    MessageBox.Show("Usuario  não encontrado");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ControleAcesso ca = new ControleAcesso();

                
                ca.Cpf = txtcpf.Text;
                ca.Nome = txtnome.Text;
                ca.Turmas = txtturma.Text;
                ca.Tipo = cmbtipo.Text;
                ca.Data = DateTime.Today;                    
               



                ControleAcessoDao dao = new ControleAcessoDao();
                dao.cadastrarAcesso(ca);
                MessageBox.Show("Acesso Liberado!");
                

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar" + erro);
            }
        }
    }
}
