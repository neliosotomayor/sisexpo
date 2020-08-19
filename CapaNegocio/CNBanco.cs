using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CNBanco : IDisposable
    {

        CDBanco objDatos = new CDBanco();

        public void Dispose()
        {
            if (objDatos != null)
            {
                objDatos.Dispose();
                objDatos = null;
            }
        }

        public List<CEBanco> MostrarBancos(string sDatoBuscar)
        {
            return objDatos.MostrarBancos(sDatoBuscar);
        }

        public void InsertarBanco(CEBanco objCE)
        {
            objDatos.InsertarBanco(objCE);
        }

        public void ModificarBanco(CEBanco objCE)
        {
            objDatos.ModificarBanco(objCE);
        }

        public void EliminarBanco(CEBanco objCE)
        {
            objDatos.EliminarBanco(objCE);
        }

        public string MostrarBancoId(int sDatoBuscar)
        {
            return objDatos.MostrarBancoId(sDatoBuscar);
        }

    }
}
