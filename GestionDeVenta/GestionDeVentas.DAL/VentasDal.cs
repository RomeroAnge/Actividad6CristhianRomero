using GestionDeVenta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeVenta.DAL
{
    public class VentasDal
    {
        Ventas ventas = new Ventas();
        public DataTable ListarVentasDal()
        {
            string consulta = "select * from ventas";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public int InsertarVentasDal(Ventas ventas)
        {
            string consulta = "insert into ventas values( "+ventas.IdCliente+",'" + ventas.FechaVenta + "'," +
                                                         "" + ventas.TotalVenta+ ")";
            conexion.Ejecutar(consulta);

            string consulta2 = "select max(idventa) from ventas";
            return conexion.EjecutarEscalar(consulta2);

        }

        public Ventas ObtenerVentasIdDal(int id)
        {
            string consulta = "select * from ventas where idventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0)
            {
                ventas.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                ventas.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                ventas.FechaVenta = Convert.ToDateTime(tabla.Rows[0]["fechaventa"]);
                ventas.TotalVenta = Convert.ToDecimal(tabla.Rows[0]["totalventa"]);
            }
            return ventas;
        }
        public void EditarVentasDal(Ventas venta)
        {
            string consulta = "update ventas set idcliente = "+venta.IdCliente +", fechaventa='" + venta.FechaVenta + "'," +
                                                        "totalventa=" + venta.TotalVenta+ " " +

                                                "where idventa=" + venta.IdVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarVentasDal(int id)
        {
            string consulta = "delete from ventas where idventa=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
