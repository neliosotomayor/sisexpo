using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEProductoPresentacion
    {

        private int _ProPre_Id;
        private int _Producto_Id;
        private string _Pro_Nombre;
        private string _ProPre_Descripcion;
        private decimal _ProPre_Kilos;
        private string _Usuario_Creacion;
        private string _Fecha_Creacion;
        private string _Usuario_Modificacion;
        private string _Fecha_Modificacion;

        public int ProPre_Id
        {
            get
            {
                return _ProPre_Id;
            }

            set
            {
                _ProPre_Id = value;
            }
        }

        public int Producto_Id
        {
            get
            {
                return _Producto_Id;
            }

            set
            {
                _Producto_Id = value;
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

        public string ProPre_Descripcion
        {
            get
            {
                return _ProPre_Descripcion;
            }

            set
            {
                _ProPre_Descripcion = value;
            }
        }

        public decimal ProPre_Kilos
        {
            get
            {
                return _ProPre_Kilos;
            }

            set
            {
                _ProPre_Kilos = value;
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
