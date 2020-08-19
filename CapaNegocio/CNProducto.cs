using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNProducto : IDisposable
    {

        CDProducto objDatos = new CDProducto();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public List<CEProducto> MostrarProductos(string sDatoBuscar)
        {
            return objDatos.MostrarProductos(sDatoBuscar);
        }

        public void InsertarProducto(CEProducto objCE)
        {
            objDatos.InsertarProducto(objCE);
        }

        public void ModificarProducto(CEProducto objCE)
        {
            objDatos.ModificarProducto(objCE);
        }

        public void EliminarProducto(CEProducto objCE)
        {
            objDatos.EliminarProducto(objCE);
        }

        public string MostrarProductoId(int sDatoBuscar)
        {
            return objDatos.MostrarProductoId(sDatoBuscar);
        }

    }
}
