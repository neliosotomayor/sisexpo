using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNExportacion : IDisposable
    {

        CDExportacion objDatos = new CDExportacion();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public List<CEExportacion> MostrarExportaciones(string sDatoBuscar)
        {
            return objDatos.MostrarExportaciones(sDatoBuscar);
        }

        public void InsertarExportacion(CEExportacion objCE)
        {
            objDatos.InsertarExportacion(objCE);
        }

        public void ModificarExportacion(CEExportacion objCE)
        {
            objDatos.ModificarExportacion(objCE);
        }

        public void EliminarExportacion(CEExportacion objCE)
        {
            objDatos.EliminarExportacion(objCE);
        }

        //public string MostrarExportacionId(int sDatoBuscar)
        //{
        //    return objDatos.MostrarExportacionId(sDatoBuscar);
        //}

    }
}
