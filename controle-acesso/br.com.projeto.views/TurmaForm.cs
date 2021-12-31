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
    public partial class TurmaForm : Form
    {
        public TurmaForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Turma t = new Turma();

                t.Curso_id = int.Parse(cbcurso.SelectedValue.ToString());
                t.Turmas = txtturma.Text;
                t.Periodo = cmbperiodo.Text;
               


                TurmaDao dao = new TurmaDao();
                dao.cadastrarTurma(t);
                MessageBox.Show("Dados cadastrado com sucesso!");
                tabelaTurma.DataSource = dao.ListarTodasTurmas();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar" + erro);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Turma obj = new Turma();

                obj.Curso_id = int.Parse(cbcurso.SelectedValue.ToString());
                obj.Turmas = txtturma.Text;
                obj.Periodo = cmbperiodo.Text;
                



                obj.id = int.Parse(txtid.Text);

                TurmaDao dao = new TurmaDao();
                dao.alterarTurma(obj);
                MessageBox.Show("Dados alterados com sucesso!");

                tabelaTurma.DataSource = dao.ListarTodasTurmas();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro : " + erro);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Turma obj = new Turma();

                obj.id = int.Parse(txtid.Text);

                TurmaDao dao = new TurmaDao();
                dao.deletarTurma(obj);

                MessageBox.Show("Dados Excluido com Sucesso ");
                tabelaTurma.DataSource = dao.ListarTodasTurmas();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro);
            }
        }

        private void TurmaForm_Load(object sender, EventArgs e)
        {
            //Carrega  comboboxCurso
            CursoDao cdao = new CursoDao();
            cbcurso.DataSource = cdao.ListarTodosCursos();
            cbcurso.DisplayMember = "descricao";
            cbcurso.ValueMember = "id";

            //carrega DataGridView Turma
            TurmaDao tdao = new TurmaDao();
            tabelaTurma.DataSource = tdao.ListarTodasTurmas();

        }

               

        private void tabelaTurma_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = tabelaTurma.CurrentRow.Cells[0].Value.ToString();
            cbcurso.Text = tabelaTurma.CurrentRow.Cells[1].Value.ToString();
            txtturma.Text = tabelaTurma.CurrentRow.Cells[2].Value.ToString();
            cmbperiodo.Text = tabelaTurma.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            cbcurso.Text = "";
            cmbperiodo.Text = "";
            txtturma.Clear();

        }
    }
}
