using GestionDeVenta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeVenta.DAL
{
    public class DetalleVentaDal
    {
        DetalleVenta detalleventa = new DetalleVenta();
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from detalleventa";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable DatoDetalleVentaDal(int id)
        {
            string consulta = "SELECT    PRODUCTOS.IDPRODUCTO, PRODUCTOS.NOMBREPRODUCTO, SUM(DETALLEVENTA.CANTIDAD)CANTIDAD, DETALLEVENTA.PRECIOUNITARIO, SUM(DETALLEVENTA.TOTALDETALLE)TOTALDETALLE " +
                "FROM         DETALLEVENTA INNER JOIN" +
                "                      PRODUCTOS ON DETALLEVENTA.IDPRODUCTO = PRODUCTOS.IDPRODUCTO INNER JOIN" +
                "                      VENTAS ON DETALLEVENTA.IDVENTA = VENTAS.IDVENTA " +
                "WHERE VENTAS.IDVENTA = "+id+"" +
                "GROUP BY PRODUCTOS.IDPRODUCTO, PRODUCTOS.NOMBREPRODUCTO, DETALLEVENTA.PRECIOUNITARIO";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleVentaDal(DetalleVenta dventa)
        {
            string consulta = "insert into detalleventa values(" + dventa.IdVenta + "," +
                                                                +dventa.IdProducto + "," +
                                                                +dventa.Cantidad+ "," +
                                                                +dventa.PrecioUnitario + "," +
                                                         "" + dventa.TotalDetalle + ")";
            try
            {
                conexion.Ejecutar(consulta);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public DetalleVenta ObtenerDetalleVentaIdDal(int id)
        {
            string consulta = "select * from detalleventa where iddetalleventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0)
            {
                detalleventa.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["iddetalleventa"]);
                detalleventa.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                detalleventa.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                detalleventa.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                detalleventa.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["preciounitario"]);
                detalleventa.TotalDetalle = Convert.ToDecimal(tabla.Rows[0]["totaldetalle"]);
            }
            return detalleventa;
        }
        public void EditarDetalleVentaDal(DetalleVenta deventa)
        {
            string consulta = "update detalleventa set idventa=" + deventa.IdVenta + "," +
                                                        "idproducto=" + deventa.IdVenta + ", " +
                                                        "cantidad=" + deventa.Cantidad + ", " +
                                                        "preciounitario=" + deventa.PrecioUnitario + ", " +
                                                        "totaldetalle=" + deventa.TotalDetalle + "  " +

                                                "where iddetalleventa=" + deventa.IdDetalleVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
