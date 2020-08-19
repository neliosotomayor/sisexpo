using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNOperador : IDisposable
    {

        CDOperador objDatos = new CDOperador();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public List<CEOperador> MostrarOperadores(string sDatoBuscar)
        {
            return objDatos.MostrarOperadores(sDatoBuscar);
        }

        public void InsertarOperador(CEOperador objCE)
        {
            objDatos.InsertarOperador(objCE);
        }

        public void ModificarOperador(CEOperador objCE)
        {
            objDatos.ModificarOperador(objCE);
        }

        public void EliminarOperador(CEOperador objCE)
        {
            objDatos.EliminarOperador(objCE);
        }

        //public string MostrarSeguroId(int sDatoBuscar)
        //{
        //    return objDatos.MostrarSeguroId(sDatoBuscar);

        //}

    }
}
