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
using TCC2021.br.com.projeto.dao;
using TCC2021.br.com.projeto.model;

namespace TCC2021.br.com.projeto.views
{
    public partial class PessoaForm : Form
    {
        public PessoaForm()
        {
            InitializeComponent();
        }

        private void PessoaForm_Load(object sender, EventArgs e)
        {
            //Carrega  comboboxTurma
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();


                p.Nome = txtnome.Text;
                p.RM = txtrm.Text;
                p.Cpf = txtcpf.Text;
                p.Dt_Nasc = txtdtnasc.Text;
                p.Email = txtemail.Text;
                p.Perfil = cbperfil.Text;
                p.Foto = txtfoto.Text;
                p.Id_Turma = int.Parse(cbturma.SelectedValue.ToString());


                PessoaDao dao = new PessoaDao();
                dao.cadastrar(p);
                MessageBox.Show("Pessoa Cadastrado com Sucesso!");

                tabelaPessoa.DataSource = dao.ListarTodasPessoas();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro);
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa obj = new Pessoa();


                obj.Nome = txtnome.Text;
                obj.RM = txtrm.Text;
                obj.Cpf = txtcpf.Text;
                obj.Dt_Nasc = txtdtnasc.Text;
                obj.Email = txtemail.Text;
                obj.Perfil = cbperfil.Text;
                obj.Foto = txtfoto.Text;
                obj.Id_Turma = int.Parse(cbturma.SelectedValue.ToString());

                obj.id = int.Parse(txtid.Text);

                PessoaDao dao = new PessoaDao();
                dao.alterar(obj);
                MessageBox.Show("Dados alterados com sucesso!");

                tabelaPessoa.DataSource = dao.ListarTodasPessoas();
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
                Pessoa obj = new Pessoa();

                obj.id = int.Parse(txtid.Text);

                PessoaDao dao = new PessoaDao();
                dao.excluir(obj);

                MessageBox.Show("Cliente Excluido com Sucesso ");
                tabelaPessoa.DataSource = dao.ListarTodasPessoas();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro);
            }
        }

        private void tabelaPessoa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = tabelaPessoa.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaPessoa.CurrentRow.Cells[1].Value.ToString();
            txtrm.Text = tabelaPessoa.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaPessoa.CurrentRow.Cells[3].Value.ToString();
            txtdtnasc.Text = tabelaPessoa.CurrentRow.Cells[4].Value.ToString();
            txtemail.Text = tabelaPessoa.CurrentRow.Cells[5].Value.ToString();
            cbperfil.Text = tabelaPessoa.CurrentRow.Cells[6].Value.ToString();
            txtfoto.Text = tabelaPessoa.CurrentRow.Cells[7].Value.ToString();
            
            cbturma.Text = tabelaPessoa.CurrentRow.Cells[8].Value.ToString();


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtnome.Clear();
            txtrm.Clear();
            txtcpf.Clear();
            txtdtnasc.Clear();
            txtemail.Clear();
            cbperfil.Text = "";
            txtfoto.Clear();
            cbturma.Text = "";
            cmbPesquisar.Text = "";


        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa obj = new Pessoa();
                PessoaDao dao = new PessoaDao();

                if (cmbPesquisar.Text == "Nome")
                {
                    obj.Nome = txtnome.Text;
                    tabelaPessoa.DataSource = dao.buscarPorNome(obj);
                }
                else if (cmbPesquisar.Text == "CPF")
                {

                    obj.Cpf = txtcpf.Text;
                    tabelaPessoa.DataSource = dao.buscarPorCpf(obj);
                }
                else
                {
                    tabelaPessoa.DataSource = dao.ListarTodasPessoas();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro :" + erro);
            }
        }

        private void PessoaForm_Load_1(object sender, EventArgs e)
        {            
            //carregar combo de turma
            TurmaDao tdao = new TurmaDao();
            cbturma.DataSource = tdao.ListarTodasTurmas();
            cbturma.DisplayMember = "turma";
            cbturma.ValueMember = "id";

            //carregar grid de Pessoa
            PessoaDao pdao = new PessoaDao();
            tabelaPessoa.DataSource = pdao.ListarTodasPessoas();
        }

        private void BtnAddFoto_Click(object sender, EventArgs e)
        {
            if (txtfoto.Text != "")
            {
                string caminho = @"C:\Users\Cleonice\Desktop\TCC2021\foto\";
                Stream myStream = null;
                OpenFileDialog abrir = new OpenFileDialog();
                abrir.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                abrir.FilterIndex = 1;
                abrir.RestoreDirectory = true;
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = abrir.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            Bitmap imagem = new Bitmap(abrir.FileName);//Pega o nome do arquivo escolhido
                            Bitmap igm = new Bitmap(imagem, 119, 110);//Padronisa o tamanho da imagaem ao picturebox
                            pb_foto.Image = igm;
                            pb_foto.Image.Save(caminho + txtfoto.Text + ".Png", System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo foto");
            }

        }
    
    }
}
