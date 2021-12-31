
namespace TCC2021
{
    partial class ControleAcessoRelatorioForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bdtcc2021DataSet = new TCC2021.bdtcc2021DataSet();
            this.controle_acessoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_acessoTableAdapter = new TCC2021.bdtcc2021DataSetTableAdapters.controle_acessoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdtcc2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_acessoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.controle_acessoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TCC2021.ControleAcessoRelatorio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bdtcc2021DataSet
            // 
            this.bdtcc2021DataSet.DataSetName = "bdtcc2021DataSet";
            this.bdtcc2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controle_acessoBindingSource
            // 
            this.controle_acessoBindingSource.DataMember = "controle_acesso";
            this.controle_acessoBindingSource.DataSource = this.bdtcc2021DataSet;
            // 
            // controle_acessoTableAdapter
            // 
            this.controle_acessoTableAdapter.ClearBeforeFill = true;
            // 
            // ControleAcessoRelatorioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ControleAcessoRelatorioForm";
            this.Text = "ControleAcessoRelatorioForm";
            this.Load += new System.EventHandler(this.ControleAcessoRelatorioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdtcc2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_acessoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource controle_acessoBindingSource;
        private bdtcc2021DataSet bdtcc2021DataSet;
        private bdtcc2021DataSetTableAdapters.controle_acessoTableAdapter controle_acessoTableAdapter;
    }
}