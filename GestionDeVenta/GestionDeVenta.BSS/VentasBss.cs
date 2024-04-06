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
    public class VentasBss
    {
        VentasDal ventadal = new VentasDal();
        public DataTable ListarVentasBss()
        {
            return ventadal.ListarVentasDal();
        }
        public int InsertarVentasBss(Ventas venta)
        {
            return ventadal.InsertarVentasDal(venta);
        }
        public Ventas ObtenerVentasIdBss(int id)
        {
            return ventadal.ObtenerVentasIdDal(id);
        }
        public void EditarVentasBss(Ventas venta)
        {
            ventadal.EditarVentasDal(venta);
        }
        public void EliminarVentasBss(int id)
        {
            ventadal.EliminarVentasDal(id);
        }
    }
}
