using GestionDeVenta.BSS;
using GestionDeVenta.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeVenta.VISTA.ProductosVistas
{
    public partial class ListarProductosVista : Form
    {
        public ListarProductosVista()
        {
            InitializeComponent();
        }
        ProductosBss productobss = new ProductosBss();
        private void ListarProductosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productobss.ListarProductosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentasVistas.RegistrarVentaVista.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertarProductosVista fr = new InsertarProductosVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = productobss.ListarProductosBss();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
