using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteVentas.VISTA.ReportesVistas
{
    public partial class ReporteDeProductosMasVendidos : Form
    {
        public ReporteDeProductosMasVendidos()
        {
            InitializeComponent();
        }

        private void ReporteDeProductosMasVendidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportesEnGeneral.ReporteDeProductosMasVendidos' Puede moverla o quitarla según sea necesario.
            this.reporteDeProductosMasVendidosTableAdapter.Fill(this.reportesEnGeneral.ReporteDeProductosMasVendidos);

            this.reportViewer1.RefreshReport();
        }
    }
}
