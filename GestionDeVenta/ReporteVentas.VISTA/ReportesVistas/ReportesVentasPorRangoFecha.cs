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
    public partial class ReportesVentasPorRangoFecha : Form
    {
        DateTime a;
        DateTime b;
        public ReportesVentasPorRangoFecha(DateTime x, DateTime y)
        {
            a= x; 
            b = y;
            InitializeComponent();
        }

        private void ReportesVentasPorRangoFecha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportesEnGeneral.ReporteDeVentasPorRangoFechas' Puede moverla o quitarla según sea necesario.
            this.reporteDeVentasPorRangoFechasTableAdapter.Fill(this.reportesEnGeneral.ReporteDeVentasPorRangoFechas, a, b);

            this.reportViewer1.RefreshReport();
        }
    }
}
