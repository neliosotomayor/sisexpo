using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNPuerto : IDisposable
    {

        CDPuerto objDatos = new CDPuerto();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public List<CEPuerto> MostrarPuertos(string sDatoBuscar)
        {
            return objDatos.MostrarPuertos(sDatoBuscar);
        }

        public void InsertarPuerto(CEPuerto objCE)
        {
            objDatos.InsertarPuerto(objCE);
        }

        public void ModificarPuerto(CEPuerto objCE)
        {
            objDatos.ModificarPuerto(objCE);
        }

        public void EliminarPuerto(CEPuerto objCE)
        {
            objDatos.EliminarPuerto(objCE);
        }

        public string MostrarPuertoId(int sDatoBuscar)
        {
            return objDatos.MostrarPuertoId(sDatoBuscar);
        }

    }
}
