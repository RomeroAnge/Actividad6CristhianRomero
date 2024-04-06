using GestionDeVenta.BSS;
using GestionDeVenta.MODELOS;
using GestionDeVenta.VISTA.ProductosVistas;
using GestionPedidos.BSS;
using GestionPedidos.Modelos;
using GestionPedidos.VISTA.ClienteVistas;
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
    public partial class RegistrarVentaVista : Form
    {
        public RegistrarVentaVista()
        {
            InitializeComponent();
        }
        private void RegistrarVentaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("idproductos", "IdProductos");
            dataGridView1.Columns["idproductos"].ReadOnly = true;
            dataGridView1.Columns.Add("productos", "Productos");
            dataGridView1.Columns["productos"].ReadOnly = true;
            dataGridView1.Columns.Add("cantidad", "Cantidad");
            dataGridView1.Columns.Add("preciounitario", "PrecioUnitario");
            dataGridView1.Columns.Add("subtotal", "SubTotal");


        }
        private decimal SumarColumna(string columna)
        {
            decimal suma = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[columna].Value != null)
                    suma += Convert.ToDecimal(row.Cells[columna].Value);
            }
            return suma;
        }
        private void MultiplicarFila()
        {
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                decimal xd = (Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value));
                dataGridView1["subtotal", i].Value = xd;
            }
        }

        ProductosBss productosbss = new ProductosBss();
        public static int IdProductoSeleccionado = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            ListarProductosVista fr = new ListarProductosVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Productos producto = productosbss.ObtenerProductosIdBss(IdProductoSeleccionado);
                dataGridView1.Rows.Add(producto.IdProducto, producto.NombreProducto, 1, producto.PrecioUnitario);
                MultiplicarFila();
                label4.Text = SumarColumna("subtotal").ToString();
            }
        }
        DetalleVentaBss deventabss = new DetalleVentaBss();
        VentasBss ventasbss = new VentasBss();
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && IdClienteSeleccionado != 0)
            {
                Ventas venta = new Ventas();
                venta.IdCliente = IdClienteSeleccionado;
                venta.FechaVenta = dateTimePicker1.Value;
                venta.TotalVenta = SumarColumna("subtotal");
                int VentaActual = ventasbss.InsertarVentasBss(venta);

                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    DetalleVenta deventa = new DetalleVenta();
                    deventa.IdVenta = VentaActual;
                    deventa.IdProducto = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    deventa.Cantidad = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    deventa.PrecioUnitario = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                    deventa.TotalDetalle = Convert.ToDecimal(deventa.Cantidad * deventa.PrecioUnitario);
                    deventabss.InsertarDetalleVentaBss(deventa);
                }
                MessageBox.Show("El Registro Fue un Exito");
                dataGridView1.Rows.Clear();
                label4.Text = string.Empty;
                textBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Ingrese Algunos Productos y/o Cliente");
            }

        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = SumarColumna("subtotal").ToString();
            MultiplicarFila();
        }

        ClienteBss clientebss = new ClienteBss();
        public static int IdClienteSeleccionado = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = clientebss.ObtenerClienteIdBss(IdClienteSeleccionado);
                textBox1.Text = cliente.Nombre + cliente.Apellido;
            }
        }


    }
}
