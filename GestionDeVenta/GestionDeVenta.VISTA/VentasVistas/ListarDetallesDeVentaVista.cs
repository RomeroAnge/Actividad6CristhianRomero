using GestionDeVenta.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeVenta.VISTA.VentasVistas
{
    public partial class ListarDetallesDeVentaVista : Form
    {
        int idx;
        public ListarDetallesDeVentaVista(int id)
        {
            idx= id;
            InitializeComponent();
        }
        DetalleVentaBss deventabss = new DetalleVentaBss();
        private void ListarDetallesDeVentaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = deventabss.DatoDetalleVentaBss(idx);
        }
    }
}
