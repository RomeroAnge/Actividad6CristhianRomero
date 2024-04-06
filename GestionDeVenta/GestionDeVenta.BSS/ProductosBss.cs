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
    public class ProductosBss
    {
        ProductosDal productodal = new ProductosDal();
        public DataTable ListarProductosBss()
        {
            return productodal.ListarProductosDal();
        }
        public void InsertarProductosBss(Productos productos)
        {
            productodal.InsertarProductosDal(productos);
        }
        public Productos ObtenerProductosIdBss(int id)
        {
            return productodal.ObtenerProductosIdDal(id);
        }
        public void EditarProductosBss(Productos producto)
        {
            productodal.EditarProductosDal(producto);
        }
        public void EliminarProductosBss(int id)
        {
            productodal.EliminarProductosDal(id);
        }
    }
}
