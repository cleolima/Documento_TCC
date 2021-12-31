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
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Pessoa obj = new Pessoa();
                PessoaDao dao = new PessoaDao();

                obj = dao.BuscarPessoaPorEmail(txtemail.Text);

                if (obj.Perfil != null)
                {
                    cbperfil.Text = obj.Perfil;
                }
                else
                {
                    MessageBox.Show("Usuario não encontrado");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario obj = new Usuario();

                obj.Email = txtemail.Text;
                obj.Senha = txtsenha.Text;
                obj.Perfil = cbperfil.Text;
                


                UsuarioDao dao = new UsuarioDao();
                dao.cadastrarUsuario(obj);
                MessageBox.Show("Usuario Cadastrado com Sucesso!");

                //tabelaPessoa.DataSource = dao.ListarTodasPessoas();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {

            txtid.Clear();
            
            txtemail.Clear();
            txtsenha.Clear();
            cbperfil.Text = "";
            
            
        }
    }
}
