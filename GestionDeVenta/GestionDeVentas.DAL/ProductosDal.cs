using GestionDeVenta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeVenta.DAL
{
    public class ProductosDal
    {
        Productos producto = new Productos();
        public DataTable ListarProductosDal()
        {
            string consulta = "select * from productos";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProductosDal(Productos producto)
        {
            string consulta = "insert into productos values('" + producto.NombreProducto + "'," +
                                                         "" + producto.PrecioUnitario + ")";
            conexion.Ejecutar(consulta);
        }

        public Productos ObtenerProductosIdDal(int id)
        {
            string consulta = "select * from productos where idproducto=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0)
            {
                producto.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                producto.NombreProducto= (tabla.Rows[0]["nombreproducto"]).ToString();
                producto.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["preciounitario"]);
            }
            return producto;
        }
        public void EditarProductosDal(Productos productos)
        {
            string consulta = "update ventas set nombreproducto='" + productos.NombreProducto + "'," +
                                                        "preciounitario=" + productos.PrecioUnitario + " " +

                                                "where idproducto=" + productos.IdProducto + ")";
        }
        public void EliminarProductosDal(int id)
        {
            string consulta = "delete from productos where idproducto=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
