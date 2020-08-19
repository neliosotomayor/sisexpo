using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNCliente : IDisposable
    {

        CDCliente objDatos = new CDCliente();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public List<CECliente> MostrarClientes(string sDatoBuscar)
        {
            return objDatos.MostrarClientes(sDatoBuscar);
        }

        public void InsertarCliente(CECliente objCE)
        {
            objDatos.InsertarCliente(objCE);
        }

        public void ModificarCliente(CECliente objCE)
        {
            objDatos.ModificarCliente(objCE);
        }

        public void EliminarCliente(CECliente objCE)
        {
            objDatos.EliminarCliente(objCE);
        }

        public string MostrarClienteId(int sDatoBuscar)
        {
            return objDatos.MostrarClienteId(sDatoBuscar);
        }

    }
}
