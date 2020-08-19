using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNAbono : IDisposable
    {

        CDAbono objDatos = new CDAbono();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public List<CEAbono> MostrarAbonosPorExportacion(int sDatoBuscar)
        {
            return objDatos.MostrarAbonosPorExportacion(sDatoBuscar);
        }

        public void InsertarAbono(CEAbono objCE)
        {
            objDatos.InsertarAbono(objCE);
        }

        public void ModificarAbono(CEAbono objCE)
        {
            objDatos.ModificarAbono(objCE);
        }

        public void EliminarAbono(CEAbono objCE)
        {
            objDatos.EliminarAbono(objCE);
        }

    }
}
