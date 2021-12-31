
namespace TCC2021.br.com.projeto.views
{
    partial class CursoForm
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
            this.gpCurso = new System.Windows.Forms.GroupBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.tabelaCurso = new System.Windows.Forms.DataGridView();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblcadastrocurso = new System.Windows.Forms.Label();
            this.gpCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // gpCurso
            // 
            this.gpCurso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gpCurso.Controls.Add(this.btnlimpar);
            this.gpCurso.Controls.Add(this.btnexcluir);
            this.gpCurso.Controls.Add(this.btnalterar);
            this.gpCurso.Controls.Add(this.btnsalvar);
            this.gpCurso.Controls.Add(this.txtdescricao);
            this.gpCurso.Controls.Add(this.txtid);
            this.gpCurso.Controls.Add(this.tabelaCurso);
            this.gpCurso.Controls.Add(this.lbldescricao);
            this.gpCurso.Controls.Add(this.lblid);
            this.gpCurso.Controls.Add(this.lblcadastrocurso);
            this.gpCurso.Location = new System.Drawing.Point(12, 12);
            this.gpCurso.Name = "gpCurso";
            this.gpCurso.Size = new System.Drawing.Size(776, 469);
            this.gpCurso.TabIndex = 0;
            this.gpCurso.TabStop = false;
            this.gpCurso.Text = "Dados do Curso";
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnlimpar.Location = new System.Drawing.Point(581, 389);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(146, 37);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click_1);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.Red;
            this.btnexcluir.Location = new System.Drawing.Point(581, 329);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(146, 37);
            this.btnexcluir.TabIndex = 8;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.BackColor = System.Drawing.Color.Gold;
            this.btnalterar.Location = new System.Drawing.Point(581, 271);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(146, 37);
            this.btnalterar.TabIndex = 7;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = false;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsalvar.Location = new System.Drawing.Point(581, 217);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(146, 37);
            this.btnsalvar.TabIndex = 6;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(356, 169);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(233, 20);
            this.txtdescricao.TabIndex = 5;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(162, 166);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(72, 20);
            this.txtid.TabIndex = 4;
            // 
            // tabelaCurso
            // 
            this.tabelaCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaCurso.Location = new System.Drawing.Point(123, 217);
            this.tabelaCurso.Name = "tabelaCurso";
            this.tabelaCurso.Size = new System.Drawing.Size(391, 209);
            this.tabelaCurso.TabIndex = 3;
            this.tabelaCurso.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaCurso_CellContentDoubleClick);
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricao.ForeColor = System.Drawing.Color.DarkRed;
            this.lbldescricao.Location = new System.Drawing.Point(264, 163);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(86, 23);
            this.lbldescricao.TabIndex = 2;
            this.lbldescricao.Text = "Descrição";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Enabled = false;
            this.lblid.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.DarkRed;
            this.lblid.Location = new System.Drawing.Point(120, 166);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(24, 23);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Id";
            // 
            // lblcadastrocurso
            // 
            this.lblcadastrocurso.AutoSize = true;
            this.lblcadastrocurso.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadastrocurso.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblcadastrocurso.Location = new System.Drawing.Point(262, 37);
            this.lblcadastrocurso.Name = "lblcadastrocurso";
            this.lblcadastrocurso.Size = new System.Drawing.Size(231, 33);
            this.lblcadastrocurso.TabIndex = 0;
            this.lblcadastrocurso.Text = "Cadastro do Curso";
            // 
            // CursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.gpCurso);
            this.Name = "CursoForm";
            this.Text = "CursoForm";
            this.Load += new System.EventHandler(this.CursoForm_Load);
            this.gpCurso.ResumeLayout(false);
            this.gpCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpCurso;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView tabelaCurso;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblcadastrocurso;
    }
}