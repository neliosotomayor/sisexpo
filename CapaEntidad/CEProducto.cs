using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEProducto
    {

        private int _Pro_Id;
        private string _Pro_Nombre;
        private string _Usuario_Creacion;
        private string _Fecha_Creacion;
        private string _Usuario_Modificacion;
        private string _Fecha_Modificacion;

        public int Pro_Id
        {
            get
            {
                return _Pro_Id;
            }

            set
            {
                _Pro_Id = value;
            }
        }

        public string Pro_Nombre
        {
            get
            {
                return _Pro_Nombre;
            }

            set
            {
                _Pro_Nombre = value;
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
