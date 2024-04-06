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

namespace GestionDeVenta.VISTA.ProductosVistas
{
    public partial class InsertarProductosVista : Form
    {
        public InsertarProductosVista()
        {
            InitializeComponent();
        }
        ProductosBss bss = new ProductosBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.NombreProducto = textBox1.Text;
            productos.PrecioUnitario = Convert.ToDecimal(textBox2.Text);  
            bss.InsertarProductosBss(productos);
            MessageBox.Show("Se guardó correctamente al Producto");
        }
    }
}
