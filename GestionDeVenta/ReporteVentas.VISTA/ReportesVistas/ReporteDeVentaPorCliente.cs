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
    public partial class ReporteDeVentaPorCliente : Form
    {
        int id;
        public ReporteDeVentaPorCliente(int n)
        {
            id = n;
            InitializeComponent();
        }

        private void ReporteDeVentaPorCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportesEnGeneral.ReportesDeVentaPorCliente' Puede moverla o quitarla según sea necesario.
            this.reportesDeVentaPorClienteTableAdapter.Fill(this.reportesEnGeneral.ReportesDeVentaPorCliente, id);

            this.reportViewer1.RefreshReport();
        }
    }
}
