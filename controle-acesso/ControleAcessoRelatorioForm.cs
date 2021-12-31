using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC2021
{
    public partial class ControleAcessoRelatorioForm : Form
    {
        public ControleAcessoRelatorioForm()
        {
            InitializeComponent();
        }

        private void ControleAcessoRelatorioForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdtcc2021DataSet.controle_acesso'. Você pode movê-la ou removê-la conforme necessário.
            this.controle_acessoTableAdapter.Fill(this.bdtcc2021DataSet.controle_acesso);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
