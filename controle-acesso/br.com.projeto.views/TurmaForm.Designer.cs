namespace TCC2021.br.com.projeto.views
{
    partial class TurmaForm
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
            this.gbdadosturmas = new System.Windows.Forms.GroupBox();
            this.txtturma = new System.Windows.Forms.TextBox();
            this.lblmodulo = new System.Windows.Forms.Label();
            this.tabelaTurma = new System.Windows.Forms.DataGridView();
            this.cbcurso = new System.Windows.Forms.ComboBox();
            this.cmbperiodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblcurso = new System.Windows.Forms.Label();
            this.gbdadosturmas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // gbdadosturmas
            // 
            this.gbdadosturmas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbdadosturmas.Controls.Add(this.txtturma);
            this.gbdadosturmas.Controls.Add(this.lblmodulo);
            this.gbdadosturmas.Controls.Add(this.tabelaTurma);
            this.gbdadosturmas.Controls.Add(this.cbcurso);
            this.gbdadosturmas.Controls.Add(this.cmbperiodo);
            this.gbdadosturmas.Controls.Add(this.label1);
            this.gbdadosturmas.Controls.Add(this.btnLimpar);
            this.gbdadosturmas.Controls.Add(this.btnSalvar);
            this.gbdadosturmas.Controls.Add(this.btnExcluir);
            this.gbdadosturmas.Controls.Add(this.btnAlterar);
            this.gbdadosturmas.Controls.Add(this.lbldescricao);
            this.gbdadosturmas.Controls.Add(this.txtid);
            this.gbdadosturmas.Controls.Add(this.lblid);
            this.gbdadosturmas.Controls.Add(this.lblcurso);
            this.gbdadosturmas.Location = new System.Drawing.Point(12, 12);
            this.gbdadosturmas.Name = "gbdadosturmas";
            this.gbdadosturmas.Size = new System.Drawing.Size(776, 469);
            this.gbdadosturmas.TabIndex = 0;
            this.gbdadosturmas.TabStop = false;
            this.gbdadosturmas.Text = "Dados da Turma";
            // 
            // txtturma
            // 
            this.txtturma.Location = new System.Drawing.Point(401, 149);
            this.txtturma.Name = "txtturma";
            this.txtturma.Size = new System.Drawing.Size(119, 20);
            this.txtturma.TabIndex = 3;
            // 
            // lblmodulo
            // 
            this.lblmodulo.AutoSize = true;
            this.lblmodulo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblmodulo.Location = new System.Drawing.Point(328, 148);
            this.lblmodulo.Name = "lblmodulo";
            this.lblmodulo.Size = new System.Drawing.Size(59, 23);
            this.lblmodulo.TabIndex = 3;
            this.lblmodulo.Text = "Turma";
            this.lblmodulo.UseWaitCursor = true;
            // 
            // tabelaTurma
            // 
            this.tabelaTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaTurma.Location = new System.Drawing.Point(62, 199);
            this.tabelaTurma.Name = "tabelaTurma";
            this.tabelaTurma.Size = new System.Drawing.Size(474, 247);
            this.tabelaTurma.TabIndex = 5;
            this.tabelaTurma.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaTurma_CellContentDoubleClick_1);
            // 
            // cbcurso
            // 
            this.cbcurso.FormattingEnabled = true;
            this.cbcurso.Location = new System.Drawing.Point(120, 148);
            this.cbcurso.Name = "cbcurso";
            this.cbcurso.Size = new System.Drawing.Size(190, 21);
            this.cbcurso.TabIndex = 2;
            // 
            // cmbperiodo
            // 
            this.cmbperiodo.FormattingEnabled = true;
            this.cmbperiodo.Items.AddRange(new object[] {
            "Manha",
            "Tarde",
            "Noite",
            "Integral"});
            this.cmbperiodo.Location = new System.Drawing.Point(616, 148);
            this.cmbperiodo.Name = "cmbperiodo";
            this.cmbperiodo.Size = new System.Drawing.Size(121, 21);
            this.cmbperiodo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(541, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Periodo";
            this.label1.UseWaitCursor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(554, 409);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(146, 37);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(554, 211);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(146, 37);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(554, 348);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(146, 37);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Gold;
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.Location = new System.Drawing.Point(554, 276);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(146, 37);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricao.ForeColor = System.Drawing.Color.DarkRed;
            this.lbldescricao.Location = new System.Drawing.Point(58, 148);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(56, 23);
            this.lbldescricao.TabIndex = 24;
            this.lbldescricao.Text = "Curso";
            this.lbldescricao.UseWaitCursor = true;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(102, 77);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(57, 20);
            this.txtid.TabIndex = 1;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.DarkRed;
            this.lblid.Location = new System.Drawing.Point(57, 74);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(24, 23);
            this.lblid.TabIndex = 22;
            this.lblid.Text = "Id";
            // 
            // lblcurso
            // 
            this.lblcurso.AutoSize = true;
            this.lblcurso.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurso.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblcurso.Location = new System.Drawing.Point(232, 23);
            this.lblcurso.Name = "lblcurso";
            this.lblcurso.Size = new System.Drawing.Size(233, 33);
            this.lblcurso.TabIndex = 21;
            this.lblcurso.Text = "Cadastro de Turma";
            // 
            // TurmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.gbdadosturmas);
            this.Name = "TurmaForm";
            this.Text = "Turma";
            this.Load += new System.EventHandler(this.TurmaForm_Load);
            this.gbdadosturmas.ResumeLayout(false);
            this.gbdadosturmas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTurma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdadosturmas;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblcurso;
        private System.Windows.Forms.ComboBox cmbperiodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbcurso;
        private System.Windows.Forms.DataGridView tabelaTurma;
        private System.Windows.Forms.Label lblmodulo;
        private System.Windows.Forms.TextBox txtturma;
    }
}