using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CECliente
    {

        private int _Cli_Id;
        private string _Cli_Nombre;
        private int _Cli_Credito;
        private string _Usuario_Creacion;
        private string _Fecha_Creacion;
        private string _Usuario_Modificacion;
        private string _Fecha_Modificacion;

        public int Cli_Id
        {
            get
            {
                return _Cli_Id;
            }

            set
            {
                _Cli_Id = value;
            }
        }

        public string Cli_Nombre
        {
            get
            {
                return _Cli_Nombre;
            }

            set
            {
                _Cli_Nombre = value;
            }
        }

        public int Cli_Credito
        {
            get
            {
                return _Cli_Credito;
            }

            set
            {
                _Cli_Credito = value;
            }
        }

        public string Usuario_Creacion
        {
            get
            {
                return _Usuario_Creacion;
            }

            set
            {
                _Usuario_Creacion = value;
            }
        }

        public string Fecha_Creacion
        {
            get
            {
                return _Fecha_Creacion;
            }

            set
            {
                _Fecha_Creacion = value;
            }
        }

        public string Usuario_Modificacion
        {
            get
            {
                return _Usuario_Modificacion;
            }

            set
            {
                _Usuario_Modificacion = value;
            }
        }

        public string Fecha_Modificacion
        {
            get
            {
                return _Fecha_Modificacion;
            }

            set
            {
                _Fecha_Modificacion = value;
            }
        }
    }
}
