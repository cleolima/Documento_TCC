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
    public partial class CursoForm : Form
    {
        public CursoForm()
        {
            InitializeComponent();
        }

        private void CursoForm_Load(object sender, EventArgs e)
        {
            CursoDao dao = new CursoDao();
            tabelaCurso.DataSource = dao.ListarTodosCursos();

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Curso obj = new Curso();

                obj.Descricao = txtdescricao.Text;


                CursoDao dao = new CursoDao();
                dao.cadastrar(obj);
                MessageBox.Show("Curso Cadastrado com Sucesso!");

                tabelaCurso.DataSource = dao.ListarTodosCursos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro);
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            try
            {
                Curso obj = new Curso();

                obj.Descricao = txtdescricao.Text;

                obj.id = int.Parse(txtid.Text);

                CursoDao dao = new CursoDao();
                dao.alterar(obj);
                MessageBox.Show("Curso Alterado com Sucesso!");

                tabelaCurso.DataSource = dao.ListarTodosCursos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Curso obj = new Curso();

                obj.id = int.Parse(txtid.Text);

                CursoDao dao = new CursoDao();
                dao.excluir(obj);

                MessageBox.Show("Curso Excluido com Sucesso ");
                tabelaCurso.DataSource = dao.ListarTodosCursos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro);
            }
        }


        private void btnlimpar_Click_1(object sender, EventArgs e)
        {
            txtid.Clear();
            txtdescricao.Clear();
        }

        private void tabelaCurso_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = tabelaCurso.CurrentRow.Cells[0].Value.ToString();
            txtdescricao.Text = tabelaCurso.CurrentRow.Cells[1].Value.ToString();

        }
    }
}
