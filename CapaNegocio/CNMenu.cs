using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class CNMenu : IDisposable
    {

        CDMenu objDatos = new CDMenu();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }


        public DataTable HabilitaMenu(int iUsuId)
        {
            return objDatos.HabilitaMenu(iUsuId);
        }

        //public List<CEMenu> MostrarMenu(int iUsuario)
        //{
        //    return objDatos.MostrarMenu(iUsuario);
        //}

    }
}
