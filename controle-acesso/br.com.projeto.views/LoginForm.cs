using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC2021.br.com.projeto.model;
using TCC2021.br.com.projeto.views;

namespace TCC2021.br.com.projeto.views
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnacessar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();

            if(txtemail.Text == "cleolima@gmail.com" &&  txtsenha.Text == "1234")
            {
                MessageBox.Show("Bem vindo ");
                
                //p.Perfil = cmbPerfil.Text;
                MenuTelaCadastro m = new MenuTelaCadastro();
                m.Show();

               
            }
            else
            {
                MessageBox.Show("Login ou senha invalidos!");
            }
        }
        private void MenuTelaCadastro()
        {
            Application.Run(new MenuTelaCadastro());
        }

        private  void btncadastrar_Click(object sender, EventArgs e)
        {
            AdminstradorForm ad = new AdminstradorForm();
            ad.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
