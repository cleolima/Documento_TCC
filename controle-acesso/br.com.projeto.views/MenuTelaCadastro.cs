using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC2021.br.com.projeto.model;
using TCC2021.br.com.projeto.views;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.SqlClient;

namespace TCC2021
{
    public partial class MenuTelaCadastro : Form
    {

        public MenuTelaCadastro()
        {
            InitializeComponent();
            
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PessoaForm p = new PessoaForm();
            p.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioForm u = new UsuarioForm();
            u.Show();
        }

        private void cursoAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuTelaCadastro_Load(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();

            if(p.Perfil != "Funcionario")
            {
                //relatoriosToolStripMenuItem.Enabled = false;
            }

           
        }

        private void TurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurmaForm t = new TurmaForm();
            t.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cursoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
             CursoForm c = new CursoForm();
            c.Show();
        }

        private void controledeAcessoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ControleAcessoform ca = new ControleAcessoform();
            ca.Show();
        }

        private void controledeAcessoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ControleAcessoRelatorioForm Rc = new ControleAcessoRelatorioForm();
            Rc.ShowDialog();
            Rc.Dispose();

        }
    }
}
