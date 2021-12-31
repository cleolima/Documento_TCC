
namespace TCC2021.br.com.projeto.views
{
    partial class UsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbperfil = new System.Windows.Forms.TextBox();
            this.lblperfil = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblTelaUsuario = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.cbperfil);
            this.groupBox1.Controls.Add(this.lblperfil);
            this.groupBox1.Controls.Add(this.txtsenha);
            this.groupBox1.Controls.Add(this.lblsenha);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.lblemail);
            this.groupBox1.Controls.Add(this.lblTelaUsuario);
            this.groupBox1.Controls.Add(this.dgvUsuario);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 469);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Usuario";
            // 
            // cbperfil
            // 
            this.cbperfil.Location = new System.Drawing.Point(527, 188);
            this.cbperfil.Name = "cbperfil";
            this.cbperfil.Size = new System.Drawing.Size(113, 20);
            this.cbperfil.TabIndex = 37;
            // 
            // lblperfil
            // 
            this.lblperfil.AutoSize = true;
            this.lblperfil.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperfil.ForeColor = System.Drawing.Color.DarkRed;
            this.lblperfil.Location = new System.Drawing.Point(473, 185);
            this.lblperfil.Name = "lblperfil";
            this.lblperfil.Size = new System.Drawing.Size(48, 23);
            this.lblperfil.TabIndex = 36;
            this.lblperfil.Text = "Perfil";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(181, 190);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(221, 20);
            this.txtsenha.TabIndex = 35;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.Color.DarkRed;
            this.lblsenha.Location = new System.Drawing.Point(123, 190);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(58, 23);
            this.lblsenha.TabIndex = 34;
            this.lblsenha.Text = "Senha";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(185, 131);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(455, 20);
            this.txtemail.TabIndex = 33;
            this.txtemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemail_KeyPress);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.DarkRed;
            this.lblemail.Location = new System.Drawing.Point(123, 131);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(56, 23);
            this.lblemail.TabIndex = 32;
            this.lblemail.Text = "E-mail";
            // 
            // lblTelaUsuario
            // 
            this.lblTelaUsuario.AutoSize = true;
            this.lblTelaUsuario.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelaUsuario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTelaUsuario.Location = new System.Drawing.Point(327, 33);
            this.lblTelaUsuario.Name = "lblTelaUsuario";
            this.lblTelaUsuario.Size = new System.Drawing.Size(159, 33);
            this.lblTelaUsuario.TabIndex = 31;
            this.lblTelaUsuario.Text = "Tela Usuario";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(20, 233);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(740, 150);
            this.dgvUsuario.TabIndex = 30;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(320, 406);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 37);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(597, 406);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(119, 37);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Gold;
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.Location = new System.Drawing.Point(42, 406);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(137, 37);
            this.btnAlterar.TabIndex = 26;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(185, 85);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(50, 20);
            this.txtid.TabIndex = 1;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.DarkRed;
            this.lblid.Location = new System.Drawing.Point(127, 85);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(24, 23);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Id";
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsuarioForm";
            this.Text = "UsuarioForm";
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblperfil;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblTelaUsuario;
        private System.Windows.Forms.TextBox cbperfil;
    }
}