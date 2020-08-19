using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNExportacionDetalle : IDisposable
    {

        CDExportacionDetalle objDatos = new CDExportacionDetalle();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public List<CEExportacionDetalle> MostrarExportacionesDetalle(int sDatoBuscar)
        {
            return objDatos.MostrarExportacionesDetalle(sDatoBuscar);
        }

        public void InsertarExportacionDetalle(CEExportacionDetalle objCE)
        {
            objDatos.InsertarExportacionDetalle(objCE);
        }

        public void ModificarExportacionDetalle(CEExportacionDetalle objCE)
        {
            objDatos.ModificarExportacionDetalle(objCE);
        }

        public void EliminarExportacionDetalle(CEExportacionDetalle objCE)
        {
            objDatos.EliminarExportacionDetalle(objCE);
        }

        //public List<CEExportacionDetalle> ConsultaExportacionDetalleFecha(string sFecDesde, string sFecHasta, int iVehId)
        //{
        //    return objDatos.ConsultaExportacionDetalleFecha(sFecDesde,sFecHasta,iVehId);
        //}
        
    }
}
