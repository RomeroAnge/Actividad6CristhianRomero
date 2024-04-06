namespace ReporteVentas.VISTA.ReportesVistas
{
    partial class ReportesVentasPorRangoFecha
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
            this.reportesEnGeneral = new ReporteVentas.VISTA.ReportesEnGeneral();
            this.reporteDeVentasPorRangoFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteDeVentasPorRangoFechasTableAdapter = new ReporteVentas.VISTA.ReportesEnGeneralTableAdapters.ReporteDeVentasPorRangoFechasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportesEnGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeVentasPorRangoFechasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteDeVentas";
            reportDataSource1.Value = this.reporteDeVentasPorRangoFechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReporteVentas.VISTA.ReporteDeVentasPorRangoFechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportesEnGeneral
            // 
            this.reportesEnGeneral.DataSetName = "ReportesEnGeneral";
            this.reportesEnGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteDeVentasPorRangoFechasBindingSource
            // 
            this.reporteDeVentasPorRangoFechasBindingSource.DataMember = "ReporteDeVentasPorRangoFechas";
            this.reporteDeVentasPorRangoFechasBindingSource.DataSource = this.reportesEnGeneral;
            // 
            // reporteDeVentasPorRangoFechasTableAdapter
            // 
            this.reporteDeVentasPorRangoFechasTableAdapter.ClearBeforeFill = true;
            // 
            // ReportesVentasPorRangoFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesVentasPorRangoFecha";
            this.Text = "ReportesVentasPorRangoFecha";
            this.Load += new System.EventHandler(this.ReportesVentasPorRangoFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportesEnGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeVentasPorRangoFechasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteDeVentasPorRangoFechasBindingSource;
        private ReportesEnGeneral reportesEnGeneral;
        private ReportesEnGeneralTableAdapters.ReporteDeVentasPorRangoFechasTableAdapter reporteDeVentasPorRangoFechasTableAdapter;
    }
}