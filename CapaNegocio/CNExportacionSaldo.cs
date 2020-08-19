using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNExportacionSaldo : IDisposable
    {

        CDExportacionSaldo objDatos = new CDExportacionSaldo();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public List<CEExportacionSaldo> MostrarExportacionesSaldos(string sDatoBuscar)
        {
            return objDatos.MostrarExportacionesSaldos(sDatoBuscar);
        }

    }
}
