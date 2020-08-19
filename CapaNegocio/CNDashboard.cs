using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNDashboard : IDisposable
    {

        CDDashboard objDatos = new CDDashboard();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public DataTable MostrarDatos()
        {
            return objDatos.MostrarDatos();
        }

        public DataTable MostrarGrafico(int iOpcion)
        {
            return objDatos.MostrarGrafico(iOpcion);
        }
    }
}
