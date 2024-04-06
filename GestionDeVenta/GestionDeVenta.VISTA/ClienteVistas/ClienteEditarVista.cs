using GestionPedidos.BSS;
using GestionPedidos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPedidos.VISTA.ClienteVistas
{
    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        Cliente cliente = new Cliente();
        ClienteBss clientebss = new ClienteBss();
        public ClienteEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            cliente.Nombre = textBox1.Text;
            cliente.Apellido = textBox2.Text;


            clientebss.EditarClienteBss(cliente);
            MessageBox.Show("Datos Actualizados");
        }

        private void ClienteEditarVista_Load_1(object sender, EventArgs e)
        {
            cliente = clientebss.ObtenerClienteIdBss(idx);
            textBox1.Text = cliente.Nombre;
            textBox2.Text = cliente.Apellido;

        }
    }
}
