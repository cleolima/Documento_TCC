
namespace TCC2021.br.com.projeto.views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnacessar = new System.Windows.Forms.Button();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnsair);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btncadastrar);
            this.groupBox1.Controls.Add(this.btnacessar);
            this.groupBox1.Controls.Add(this.txtsenha);
            this.groupBox1.Controls.Add(this.lblsenha);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.lblemail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Crimson;
            this.btnsair.Location = new System.Drawing.Point(410, 197);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(77, 35);
            this.btnsair.TabIndex = 10;
            this.btnsair.Text = "SAIR";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(169, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(288, 258);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(199, 35);
            this.btncadastrar.TabIndex = 5;
            this.btncadastrar.Text = "CADASTRAR";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnacessar
            // 
            this.btnacessar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnacessar.Location = new System.Drawing.Point(288, 197);
            this.btnacessar.Name = "btnacessar";
            this.btnacessar.Size = new System.Drawing.Size(77, 35);
            this.btnacessar.TabIndex = 4;
            this.btnacessar.Text = "ACESSAR";
            this.btnacessar.UseVisualStyleBackColor = false;
            this.btnacessar.Click += new System.EventHandler(this.btnacessar_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(288, 153);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(218, 20);
            this.txtsenha.TabIndex = 3;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.Color.Black;
            this.lblsenha.Location = new System.Drawing.Point(227, 148);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(58, 23);
            this.lblsenha.TabIndex = 2;
            this.lblsenha.Text = "Senha";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(288, 84);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(218, 20);
            this.txtemail.TabIndex = 1;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Black;
            this.lblemail.Location = new System.Drawing.Point(227, 84);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(56, 23);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "E-mail";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(556, 351);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnacessar;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button btnsair;
    }
}