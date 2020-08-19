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
    public class CNUsuario : IDisposable
    {

        CDUsuario objDatos = new CDUsuario();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public List<CEUsuario> MostrarUsuarios(string sDatoBuscar)
        {
            return objDatos.MostrarUsuarios(sDatoBuscar);
        }

        public void InsertarUsuario(CEUsuario objCE)
        {
            objDatos.InsertarUsuario(objCE);
        }

        public void ModificarUsuario(CEUsuario objCE)
        {
            objDatos.ModificarUsuario(objCE);
        }

        public void EliminarUsuario(CEUsuario objCE)
        {
            objDatos.EliminarUsuario(objCE);
        }

        public DataTable ValidaUsuario(string sUsu , string sPass)
        {
            CEUsuario ObjUsuario = new CEUsuario()
            {
              Usu_Usuario = sUsu,
              Usu_Password = sPass
            };
            return objDatos.ValidaUsuario(ObjUsuario);
        }

    }
}
