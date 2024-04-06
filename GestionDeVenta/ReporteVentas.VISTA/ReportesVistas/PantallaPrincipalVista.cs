using ReporteVentas.VISTA.ReportesEnGeneralTableAdapters;
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
    public partial class PantallaPrincipalVista : Form
    {
        public PantallaPrincipalVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportesVentasPorRangoFecha fr = new ReportesVentasPorRangoFecha(dateTimePicker1.Value,dateTimePicker2.Value);
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteDeProductosMasVendidos fr = new ReporteDeProductosMasVendidos();
            fr.ShowDialog();
        }

        private void PantallaPrincipalVista_Load(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ReporteDeVentaPorCliente fr = new ReporteDeVentaPorCliente(Convert.ToInt32(textBox1.Text));
            fr.ShowDialog();
        }
    }
}
