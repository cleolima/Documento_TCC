
namespace TCC2021.br.com.projeto.views
{
    partial class ControleAcessoform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleAcessoform));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtturma = new System.Windows.Forms.TextBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.txtnome);
            this.groupBox2.Controls.Add(this.lblnome);
            this.groupBox2.Controls.Add(this.txtturma);
            this.groupBox2.Controls.Add(this.txtdata);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pb_foto);
            this.groupBox2.Controls.Add(this.cmbtipo);
            this.groupBox2.Controls.Add(this.txtcpf);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnConfirmar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 484);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Usuario";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(249, 163);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(229, 20);
            this.txtnome.TabIndex = 47;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.Color.DarkRed;
            this.lblnome.Location = new System.Drawing.Point(187, 161);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(54, 23);
            this.lblnome.TabIndex = 46;
            this.lblnome.Text = "Nome";
            // 
            // txtturma
            // 
            this.txtturma.Location = new System.Drawing.Point(546, 163);
            this.txtturma.Name = "txtturma";
            this.txtturma.Size = new System.Drawing.Size(121, 20);
            this.txtturma.TabIndex = 45;
            this.txtturma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(546, 232);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(156, 20);
            this.txtdata.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(484, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(484, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Turma";
            // 
            // pb_foto
            // 
            this.pb_foto.Image = ((System.Drawing.Image)(resources.GetObject("pb_foto.Image")));
            this.pb_foto.Location = new System.Drawing.Point(23, 89);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(146, 201);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 40;
            this.pb_foto.TabStop = false;
            // 
            // cmbtipo
            // 
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Items.AddRange(new object[] {
            "Entrada",
            "Saida"});
            this.cmbtipo.Location = new System.Drawing.Point(235, 244);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(121, 21);
            this.cmbtipo.TabIndex = 39;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(235, 101);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(113, 20);
            this.txtcpf.TabIndex = 38;
            this.txtcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcpf_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(188, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(188, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(278, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tela Controle de Acesso";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(257, 352);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(283, 37);
            this.btnConfirmar.TabIndex = 29;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // ControleAcessoform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControleAcessoform";
            this.Text = "ControleAcessoform";
            this.Load += new System.EventHandler(this.ControleAcessoform_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtturma;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
    }
}