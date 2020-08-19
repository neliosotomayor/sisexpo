using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNNotaCredito : IDisposable
    {

        CDNotaCredito objDatos = new CDNotaCredito();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public List<CENotaCredito> MostrarNotasDeCreditoPorExportacion(int sDatoBuscar)
        {
            return objDatos.MostrarNotasDeCreditoPorExportacion(sDatoBuscar);
        }

        public void InsertarNotaCredito(CENotaCredito objCE)
        {
            objDatos.InsertarNotaCredito(objCE);
        }

        public void ModificarNotaCredito(CENotaCredito objCE)
        {
            objDatos.ModificarNotaCredito(objCE);
        }

        public void EliminarNotaCredito(CENotaCredito objCE)
        {
            objDatos.EliminarNotaCredito(objCE);
        }

        //public List<CENotaCredito> ConsultaNotaCreditosFecha(string sFecDesde, string sFecHasta, int iVehId)
        //{
        //    return objDatos.ConsultaNotaCreditosFecha(sFecDesde, sFecHasta, iVehId);
        //}

    }
}
