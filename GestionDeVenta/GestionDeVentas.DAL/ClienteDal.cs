using GestionDeVenta.DAL;
using GestionPedidos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPedidos.DAL
{
    public class ClienteDal
    {
        Cliente cliente = new Cliente();
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from cliente";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values('" + cliente.Nombre + "'," +
                                                         "'" + cliente.Apellido + "')";
            conexion.Ejecutar(consulta);
        }
        
        public Cliente ObtenerClienteIdDal(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "cliente");
            if (tabla.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                cliente.Nombre = tabla.Rows[0]["nombre"].ToString();
                cliente.Apellido = tabla.Rows[0]["apellido"].ToString();

            }
            return cliente;
        }
        public void EditarClienteDal(Cliente cliente)
        {
            string consulta = "update cliente set nombre='" + cliente.Nombre + "'," +
                                                        "apellido='" + cliente.Apellido + "'  " +
                                                "where idcliente=" + cliente.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
