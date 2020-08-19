using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNNotaCreditoTipo : IDisposable
    {

        CDNotaCreditoTipo objDatos = new CDNotaCreditoTipo();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public List<CENotaCreditoTipo> MostrarNotaCreditoTipos(string sDatoBuscar)
        {
            return objDatos.MostrarNotaCreditoTipos(sDatoBuscar);
        }

        public void InsertarNotaCreditoTipo(CENotaCreditoTipo objCE)
        {
            objDatos.InsertarNotaCreditoTipo(objCE);
        }

        public void ModificarNotaCreditoTipo(CENotaCreditoTipo objCE)
        {
            objDatos.ModificarNotaCreditoTipo(objCE);
        }

        public void EliminarNotaCreditoTipo(CENotaCreditoTipo objCE)
        {
            objDatos.EliminarNotaCreditoTipo(objCE);
        }

        //public string MostrarNotaCreditoTipoId(int sDatoBuscar)
        //{
        //    return objDatos.MostrarNotaCreditoTipoId(sDatoBuscar);
        //}

    }
}
