using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEAeropuerto
    {

        private int _Aer_Id;
        private string _Aer_Nombre;
        private string _Usuario_Creacion;
        private string _Fecha_Creacion;
        private string _Usuario_Modificacion;
        private string _Fecha_Modificacion;

        public int Aer_Id
        {
            get
            {
                return _Aer_Id;
            }

            set
            {
                _Aer_Id = value;
            }
        }

        public string Aer_Nombre
        {
            get
            {
                return _Aer_Nombre;
            }

            set
            {
                _Aer_Nombre = value;
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
