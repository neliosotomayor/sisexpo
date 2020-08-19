using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNProductoPresentacion : IDisposable
    {

        CDProductoPresentacion objDatos = new CDProductoPresentacion();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public List<CEProductoPresentacion> MostrarProductoPresentaciones(string sDatoBuscar)
        {
            return objDatos.MostrarProductoPresentaciones(sDatoBuscar);
        }

        public void InsertarProductoPresentacion(CEProductoPresentacion objCE)
        {
            objDatos.InsertarProductoPresentacion(objCE);
        }

        public void ModificarProductoPresentacion(CEProductoPresentacion objCE)
        {
            objDatos.ModificarProductoPresentacion(objCE);
        }

        public void EliminarProductoPresentacion(CEProductoPresentacion objCE)
        {
            objDatos.EliminarProductoPresentacion(objCE);
        }

        public List<CEProductoPresentacion> MostrarPresentacionesPorProducto(int sDatoBuscar)
        {
            return objDatos.MostrarPresentacionesPorProducto(sDatoBuscar);
        }

        //public List<CEIncidencia> ConsultaIncidenciasFecha(string sFecDesde, string sFecHasta, int iVehiculo, int iIncidencia)
        //{
        //    return objDatos.ConsultaIncidenciasFecha(sFecDesde,sFecHasta,iVehiculo,iIncidencia);
        //}

    }
}
