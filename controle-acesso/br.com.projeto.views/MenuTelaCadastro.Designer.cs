
namespace TCC2021
{
    partial class MenuTelaCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuTelaCadastro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controledeAcessoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controledeAcessoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.turmaToolStripMenuItem,
            this.cursoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(91, 27);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(139, 28);
            this.pessoaToolStripMenuItem.Text = "Pessoa";
            this.pessoaToolStripMenuItem.Click += new System.EventHandler(this.pessoaToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(139, 28);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.turmaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(139, 28);
            this.turmaToolStripMenuItem.Text = "Turma";
            this.turmaToolStripMenuItem.Click += new System.EventHandler(this.TurmaToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(139, 28);
            this.cursoToolStripMenuItem.Text = "Curso";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click_1);
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controledeAcessoToolStripMenuItem1});
            this.movimentaçãoToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(133, 27);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // controledeAcessoToolStripMenuItem1
            // 
            this.controledeAcessoToolStripMenuItem1.BackColor = System.Drawing.Color.Violet;
            this.controledeAcessoToolStripMenuItem1.Name = "controledeAcessoToolStripMenuItem1";
            this.controledeAcessoToolStripMenuItem1.Size = new System.Drawing.Size(239, 28);
            this.controledeAcessoToolStripMenuItem1.Text = "Controle_de_Acesso";
            this.controledeAcessoToolStripMenuItem1.Click += new System.EventHandler(this.controledeAcessoToolStripMenuItem1_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controledeAcessoToolStripMenuItem2});
            this.relatoriosToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // controledeAcessoToolStripMenuItem2
            // 
            this.controledeAcessoToolStripMenuItem2.BackColor = System.Drawing.Color.Pink;
            this.controledeAcessoToolStripMenuItem2.Name = "controledeAcessoToolStripMenuItem2";
            this.controledeAcessoToolStripMenuItem2.Size = new System.Drawing.Size(239, 28);
            this.controledeAcessoToolStripMenuItem2.Text = "Controle_de_Acesso";
            this.controledeAcessoToolStripMenuItem2.Click += new System.EventHandler(this.controledeAcessoToolStripMenuItem2_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(51, 27);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // MenuTelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuTelaCadastro";
            this.Text = "Menu-Tela de Cadastro";
            this.Load += new System.EventHandler(this.MenuTelaCadastro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controledeAcessoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controledeAcessoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
    }
}

