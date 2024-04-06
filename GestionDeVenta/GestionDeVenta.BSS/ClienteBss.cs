using GestionPedidos.DAL;
using GestionPedidos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPedidos.BSS
{
    public class ClienteBss
    {
        ClienteDal clientedal = new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return clientedal.ListarClienteDal();
        }
        public void InsertarClienteBss(Cliente Cliente)
        {
            clientedal.InsertarClienteDal(Cliente);
        }
        public Cliente ObtenerClienteIdBss(int id)
        {
            return clientedal.ObtenerClienteIdDal(id);
        }
        public void EditarClienteBss(Cliente cliente)
        {
            clientedal.EditarClienteDal(cliente);
        }
        public void EliminarClienteBss(int id)
        {
            clientedal.EliminarClienteDal(id);
        }
    }
}
