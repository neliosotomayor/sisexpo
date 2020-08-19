using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNAeropuerto : IDisposable
    {

        CDAeropuerto objDatos = new CDAeropuerto();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public List<CEAeropuerto> MostrarAeropuertos(string sDatoBuscar)
        {
            return objDatos.MostrarAeropuertos(sDatoBuscar);
        }

        public void InsertarAeropuerto(CEAeropuerto objCE)
        {
            objDatos.InsertarAeropuerto(objCE);
        }

        public void ModificarAeropuerto(CEAeropuerto objCE)
        {
            objDatos.ModificarAeropuerto(objCE);
        }

        public void EliminarAeropuerto(CEAeropuerto objCE)
        {
            objDatos.EliminarAeropuerto(objCE);
        }

        public string MostrarAeropuertoId(int sDatoBuscar)
        {
            return objDatos.MostrarAeropuertoId(sDatoBuscar);
        }

    }
}
