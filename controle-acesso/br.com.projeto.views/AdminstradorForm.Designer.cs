
namespace TCC2021.br.com.projeto.views
{
    partial class AdminstradorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminstradorForm));
            this.cbturma = new System.Windows.Forms.ComboBox();
            this.lblturma = new System.Windows.Forms.Label();
            this.txtdtnasc = new System.Windows.Forms.MaskedTextBox();
            this.lbldtnasc = new System.Windows.Forms.Label();
            this.txtfoto = new System.Windows.Forms.TextBox();
            this.lblfoto = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.lblperfil = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblrm = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblcadastroadmin = new System.Windows.Forms.Label();
            this.gpdadosPessoa = new System.Windows.Forms.GroupBox();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.btnAddFoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtperfil = new System.Windows.Forms.TextBox();
            this.tabelaPessoa = new System.Windows.Forms.DataGridView();
            this.txtrm = new System.Windows.Forms.MaskedTextBox();
            this.gpdadosPessoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // cbturma
            // 
            this.cbturma.FormattingEnabled = true;
            this.cbturma.Location = new System.Drawing.Point(620, 252);
            this.cbturma.Name = "cbturma";
            this.cbturma.Size = new System.Drawing.Size(117, 21);
            this.cbturma.TabIndex = 9;
            // 
            // lblturma
            // 
            this.lblturma.AutoSize = true;
            this.lblturma.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblturma.ForeColor = System.Drawing.Color.DarkRed;
            this.lblturma.Location = new System.Drawing.Point(555, 254);
            this.lblturma.Name = "lblturma";
            this.lblturma.Size = new System.Drawing.Size(0, 23);
            this.lblturma.TabIndex = 33;
            // 
            // txtdtnasc
            // 
            this.txtdtnasc.Location = new System.Drawing.Point(139, 188);
            this.txtdtnasc.Mask = "00/00/0000";
            this.txtdtnasc.Name = "txtdtnasc";
            this.txtdtnasc.Size = new System.Drawing.Size(100, 20);
            this.txtdtnasc.TabIndex = 4;
            this.txtdtnasc.ValidatingType = typeof(System.DateTime);
            // 
            // lbldtnasc
            // 
            this.lbldtnasc.AutoSize = true;
            this.lbldtnasc.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtnasc.ForeColor = System.Drawing.Color.DarkRed;
            this.lbldtnasc.Location = new System.Drawing.Point(13, 185);
            this.lbldtnasc.Name = "lbldtnasc";
            this.lbldtnasc.Size = new System.Drawing.Size(120, 23);
            this.lbldtnasc.TabIndex = 30;
            this.lbldtnasc.Text = "Dt Nascimento";
            // 
            // txtfoto
            // 
            this.txtfoto.Location = new System.Drawing.Point(245, 252);
            this.txtfoto.Name = "txtfoto";
            this.txtfoto.Size = new System.Drawing.Size(123, 20);
            this.txtfoto.TabIndex = 7;
            // 
            // lblfoto
            // 
            this.lblfoto.AutoSize = true;
            this.lblfoto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfoto.ForeColor = System.Drawing.Color.DarkRed;
            this.lblfoto.Location = new System.Drawing.Point(194, 250);
            this.lblfoto.Name = "lblfoto";
            this.lblfoto.Size = new System.Drawing.Size(45, 23);
            this.lblfoto.TabIndex = 26;
            this.lblfoto.Text = "Foto";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(581, 527);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 40);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(236, 527);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(260, 40);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.LightGreen;
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(32, 527);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(125, 40);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(633, 136);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(100, 20);
            this.txtcpf.TabIndex = 3;
            // 
            // lblperfil
            // 
            this.lblperfil.AutoSize = true;
            this.lblperfil.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperfil.ForeColor = System.Drawing.Color.DarkRed;
            this.lblperfil.Location = new System.Drawing.Point(13, 247);
            this.lblperfil.Name = "lblperfil";
            this.lblperfil.Size = new System.Drawing.Size(48, 23);
            this.lblperfil.TabIndex = 11;
            this.lblperfil.Text = "Perfil";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(425, 188);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(312, 20);
            this.txtemail.TabIndex = 5;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.DarkRed;
            this.lblemail.Location = new System.Drawing.Point(363, 183);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(56, 23);
            this.lblemail.TabIndex = 9;
            this.lblemail.Text = "E-mail";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.ForeColor = System.Drawing.Color.DarkRed;
            this.lblcpf.Location = new System.Drawing.Point(586, 136);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(41, 23);
            this.lblcpf.TabIndex = 7;
            this.lblcpf.Text = "CPF";
            // 
            // lblrm
            // 
            this.lblrm.AutoSize = true;
            this.lblrm.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrm.ForeColor = System.Drawing.Color.DarkRed;
            this.lblrm.Location = new System.Drawing.Point(408, 133);
            this.lblrm.Name = "lblrm";
            this.lblrm.Size = new System.Drawing.Size(34, 23);
            this.lblrm.TabIndex = 5;
            this.lblrm.Text = "RM";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(73, 136);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(309, 20);
            this.txtnome.TabIndex = 1;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.Color.DarkRed;
            this.lblnome.Location = new System.Drawing.Point(13, 133);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(54, 23);
            this.lblnome.TabIndex = 3;
            this.lblnome.Text = "Nome";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(82, 89);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(50, 20);
            this.txtid.TabIndex = 2;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.DarkRed;
            this.lblid.Location = new System.Drawing.Point(13, 89);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(24, 23);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Id";
            // 
            // lblcadastroadmin
            // 
            this.lblcadastroadmin.AutoSize = true;
            this.lblcadastroadmin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcadastroadmin.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadastroadmin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblcadastroadmin.Location = new System.Drawing.Point(271, 31);
            this.lblcadastroadmin.Name = "lblcadastroadmin";
            this.lblcadastroadmin.Size = new System.Drawing.Size(289, 33);
            this.lblcadastroadmin.TabIndex = 0;
            this.lblcadastroadmin.Text = "Cadastro Administrador";
            // 
            // gpdadosPessoa
            // 
            this.gpdadosPessoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gpdadosPessoa.Controls.Add(this.txtrm);
            this.gpdadosPessoa.Controls.Add(this.tabelaPessoa);
            this.gpdadosPessoa.Controls.Add(this.pb_foto);
            this.gpdadosPessoa.Controls.Add(this.btnAddFoto);
            this.gpdadosPessoa.Controls.Add(this.label1);
            this.gpdadosPessoa.Controls.Add(this.txtperfil);
            this.gpdadosPessoa.Controls.Add(this.cbturma);
            this.gpdadosPessoa.Controls.Add(this.lblturma);
            this.gpdadosPessoa.Controls.Add(this.txtdtnasc);
            this.gpdadosPessoa.Controls.Add(this.lbldtnasc);
            this.gpdadosPessoa.Controls.Add(this.txtfoto);
            this.gpdadosPessoa.Controls.Add(this.lblfoto);
            this.gpdadosPessoa.Controls.Add(this.btnLimpar);
            this.gpdadosPessoa.Controls.Add(this.btnSalvar);
            this.gpdadosPessoa.Controls.Add(this.btnVoltar);
            this.gpdadosPessoa.Controls.Add(this.txtcpf);
            this.gpdadosPessoa.Controls.Add(this.lblperfil);
            this.gpdadosPessoa.Controls.Add(this.txtemail);
            this.gpdadosPessoa.Controls.Add(this.lblemail);
            this.gpdadosPessoa.Controls.Add(this.lblcpf);
            this.gpdadosPessoa.Controls.Add(this.lblrm);
            this.gpdadosPessoa.Controls.Add(this.txtnome);
            this.gpdadosPessoa.Controls.Add(this.lblnome);
            this.gpdadosPessoa.Controls.Add(this.txtid);
            this.gpdadosPessoa.Controls.Add(this.lblid);
            this.gpdadosPessoa.Controls.Add(this.lblcadastroadmin);
            this.gpdadosPessoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gpdadosPessoa.Location = new System.Drawing.Point(12, 12);
            this.gpdadosPessoa.Name = "gpdadosPessoa";
            this.gpdadosPessoa.Size = new System.Drawing.Size(776, 582);
            this.gpdadosPessoa.TabIndex = 1;
            this.gpdadosPessoa.TabStop = false;
            this.gpdadosPessoa.Text = "Dados do Administrador";
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Location = new System.Drawing.Point(448, 226);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(85, 113);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 37;
            this.pb_foto.TabStop = false;
            // 
            // btnAddFoto
            // 
            this.btnAddFoto.BackColor = System.Drawing.Color.Linen;
            this.btnAddFoto.ForeColor = System.Drawing.Color.Black;
            this.btnAddFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFoto.Image")));
            this.btnAddFoto.Location = new System.Drawing.Point(402, 299);
            this.btnAddFoto.Name = "btnAddFoto";
            this.btnAddFoto.Size = new System.Drawing.Size(40, 40);
            this.btnAddFoto.TabIndex = 36;
            this.btnAddFoto.UseVisualStyleBackColor = false;
            this.btnAddFoto.Click += new System.EventHandler(this.BtnAddFoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(555, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Turma";
            // 
            // txtperfil
            // 
            this.txtperfil.Location = new System.Drawing.Point(67, 252);
            this.txtperfil.Name = "txtperfil";
            this.txtperfil.Size = new System.Drawing.Size(100, 20);
            this.txtperfil.TabIndex = 6;
            // 
            // tabelaPessoa
            // 
            this.tabelaPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaPessoa.Location = new System.Drawing.Point(17, 352);
            this.tabelaPessoa.Name = "tabelaPessoa";
            this.tabelaPessoa.Size = new System.Drawing.Size(720, 150);
            this.tabelaPessoa.TabIndex = 38;
            // 
            // txtrm
            // 
            this.txtrm.Location = new System.Drawing.Point(448, 133);
            this.txtrm.Mask = "00.000";
            this.txtrm.Name = "txtrm";
            this.txtrm.Size = new System.Drawing.Size(100, 20);
            this.txtrm.TabIndex = 3;
            // 
            // AdminstradorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.gpdadosPessoa);
            this.Name = "AdminstradorForm";
            this.Text = "AdminstradorForm";
            this.Load += new System.EventHandler(this.AdminstradorForm_Load);
            this.gpdadosPessoa.ResumeLayout(false);
            this.gpdadosPessoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbturma;
        private System.Windows.Forms.Label lblturma;
        private System.Windows.Forms.MaskedTextBox txtdtnasc;
        private System.Windows.Forms.Label lbldtnasc;
        private System.Windows.Forms.TextBox txtfoto;
        private System.Windows.Forms.Label lblfoto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label lblperfil;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblrm;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblcadastroadmin;
        private System.Windows.Forms.GroupBox gpdadosPessoa;
        private System.Windows.Forms.TextBox txtperfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Button btnAddFoto;
        private System.Windows.Forms.DataGridView tabelaPessoa;
        private System.Windows.Forms.MaskedTextBox txtrm;
    }
}