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
    public partial class ListarVentasVista : Form
    {
        public ListarVentasVista()
        {
            InitializeComponent();
        }
        VentasBss bss = new VentasBss();
        private void ListarVentasVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentasBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarDetallesDeVentaVista fr = new ListarDetallesDeVentaVista(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            fr.Show();
        }
    }
}
