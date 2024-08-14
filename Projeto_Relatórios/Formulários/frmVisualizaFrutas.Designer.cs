
namespace Projeto_Relatórios.Formulários
{
    partial class frmVisualizaFrutas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bdrelatoriosDataSet = new Projeto_Relatórios.bdrelatoriosDataSet();
            this.bdrelatoriosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbfrutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbfrutasTableAdapter = new Projeto_Relatórios.bdrelatoriosDataSetTableAdapters.tbfrutasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdrelatoriosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdrelatoriosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfrutasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet_Frutas";
            reportDataSource2.Value = this.tbfrutasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Relatórios.Relatórios.RelatorioFrutas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bdrelatoriosDataSet
            // 
            this.bdrelatoriosDataSet.DataSetName = "bdrelatoriosDataSet";
            this.bdrelatoriosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdrelatoriosDataSetBindingSource
            // 
            this.bdrelatoriosDataSetBindingSource.DataSource = this.bdrelatoriosDataSet;
            this.bdrelatoriosDataSetBindingSource.Position = 0;
            // 
            // tbfrutasBindingSource
            // 
            this.tbfrutasBindingSource.DataMember = "tbfrutas";
            this.tbfrutasBindingSource.DataSource = this.bdrelatoriosDataSet;
            // 
            // tbfrutasTableAdapter
            // 
            this.tbfrutasTableAdapter.ClearBeforeFill = true;
            // 
            // frmVisualizaFrutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVisualizaFrutas";
            this.Text = "Visualizador de Relatórios";
            this.Load += new System.EventHandler(this.frmVisualizaFrutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdrelatoriosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdrelatoriosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfrutasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private bdrelatoriosDataSet bdrelatoriosDataSet;
        private System.Windows.Forms.BindingSource bdrelatoriosDataSetBindingSource;
        private System.Windows.Forms.BindingSource tbfrutasBindingSource;
        private bdrelatoriosDataSetTableAdapters.tbfrutasTableAdapter tbfrutasTableAdapter;
    }
}