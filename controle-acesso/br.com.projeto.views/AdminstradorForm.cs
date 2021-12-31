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
    public partial class AdminstradorForm : Form
    {
        
        public AdminstradorForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            try
            {
                Administrador p = new Administrador();


                p.Nome = txtnome.Text;
                p.RM = txtrm.Text;
                p.Cpf = txtcpf.Text;
                p.Dt_Nasc = txtdtnasc.Text;
                p.Email = txtemail.Text;
                p.Perfil = txtperfil.Text;
                p.Foto = txtfoto.Text;
                p.Id_Turma = int.Parse(cbturma.SelectedValue.ToString());


                AdminstradorDao dao = new AdminstradorDao();
                dao.cadastrar(p);
                MessageBox.Show("Pessoa Cadastrado com Sucesso!");

                tabelaPessoa.DataSource = dao.ListarTodasPessoas();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro);
            }
        }

        private void AdminstradorForm_Load(object sender, EventArgs e)
        {
            TurmaDao tdao = new TurmaDao();
            cbturma.DataSource = tdao.ListarTodasTurmas();
            cbturma.DisplayMember = "turma";
            cbturma.ValueMember = "id";

            //carregar grid de Pessoa
            PessoaDao pdao = new PessoaDao();
            tabelaPessoa.DataSource = pdao.ListarTodasPessoas();

            AdminstradorDao dao = new AdminstradorDao();
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

        private void BtnLimpar_Click(object sender, EventArgs e)
        {

            txtid.Clear();
            txtnome.Clear();
            txtrm.Clear();
            txtcpf.Clear();
            txtdtnasc.Clear();
            txtemail.Clear();
            txtperfil.Clear();
            txtfoto.Clear();
            cbturma.Text = "";
            
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            LoginForm lo = new LoginForm();
            lo.Show();
        }
    }
}
