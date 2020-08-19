using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEUsuario
    {

        private int _Usu_Id;
        private string _Usu_Nombre;
        private string _Usu_Apellido;
        private string _Usu_Usuario;
        private string _Usu_Password;
        private string _Usuario_Creacion;
        private string _Fecha_Creacion;
        private string _Usuario_Modificacion;
        private string _Fecha_Modificacion;

        public int Usu_Id
        {
            get
            {
                return _Usu_Id;
            }

            set
            {
                _Usu_Id = value;
            }
        }

        public string Usu_Nombre
        {
            get
            {
                return _Usu_Nombre;
            }

            set
            {
                _Usu_Nombre = value;
            }
        }

        public string Usu_Apellido
        {
            get
            {
                return _Usu_Apellido;
            }

            set
            {
                _Usu_Apellido = value;
            }
        }

        public string Usu_Usuario
        {
            get
            {
                return _Usu_Usuario;
            }

            set
            {
                _Usu_Usuario = value;
            }
        }

        public string Usu_Password
        {
            get
            {
                return _Usu_Password;
            }

            set
            {
                _Usu_Password = value;
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
