using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEExportacionDetalle
    {

        private int _ExpDet_Id;
        private int _Exportacion_Id;
        private int _Presentacion_Id;
        private string _ProPre_Descripcion;
        private int _ExpDet_Cajas;
        private decimal _ExpDet_Kilos;
        private decimal _ExpDet_Precio;
        private decimal _ExpDet_TotalPresentacion;
        private string _Usuario_Creacion;
        private string _Fecha_Creacion;
        private string _Usuario_Modificacion;
        private string _Fecha_Modificacion;

        public int ExpDet_Id
        {
            get
            {
                return _ExpDet_Id;
            }

            set
            {
                _ExpDet_Id = value;
            }
        }

        public int Exportacion_Id
        {
            get
            {
                return _Exportacion_Id;
            }

            set
            {
                _Exportacion_Id = value;
            }
        }

        public int Presentacion_Id
        {
            get
            {
                return _Presentacion_Id;
            }

            set
            {
                _Presentacion_Id = value;
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

        public int ExpDet_Cajas
        {
            get
            {
                return _ExpDet_Cajas;
            }

            set
            {
                _ExpDet_Cajas = value;
            }
        }

        public decimal ExpDet_Kilos
        {
            get
            {
                return _ExpDet_Kilos;
            }

            set
            {
                _ExpDet_Kilos = value;
            }
        }

        public decimal ExpDet_Precio
        {
            get
            {
                return _ExpDet_Precio;
            }

            set
            {
                _ExpDet_Precio = value;
            }
        }

        public decimal ExpDet_TotalPresentacion
        {
            get
            {
                return _ExpDet_TotalPresentacion;
            }

            set
            {
                _ExpDet_TotalPresentacion = value;
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
