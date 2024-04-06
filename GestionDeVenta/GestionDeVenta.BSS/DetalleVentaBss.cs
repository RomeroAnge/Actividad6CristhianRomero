using GestionDeVenta.DAL;
using GestionDeVenta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeVenta.BSS
{
    public class DetalleVentaBss
    {
        DetalleVentaDal deventadal = new DetalleVentaDal();
        public DataTable ListarDetalleVentaBss()
        {
            return deventadal.ListarDetalleVentaDal();
        }
        public DataTable DatoDetalleVentaBss(int id)
        {
            return deventadal.DatoDetalleVentaDal(id);
        }
        public void InsertarDetalleVentaBss(DetalleVenta venta)
        {
            deventadal.InsertarDetalleVentaDal(venta);
        }
        public DetalleVenta ObtenerDetalleVentaIdBss(int id)
        {
            return deventadal.ObtenerDetalleVentaIdDal(id);
        }
        public void EditarDetalleVentaBss(DetalleVenta venta)
        {
            deventadal.EditarDetalleVentaDal(venta);
        }
        public void EliminarDetalleVentaBss(int id)
        {
            deventadal.EliminarDetalleVentaDal(id);
        }
    }
}
