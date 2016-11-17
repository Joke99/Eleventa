using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PuntoVentaApp
{
    class conexion
    {
        public string cadenaconexion;
        protected string sql;
        protected int resultado;
        protected SqlConnection cnn;
        protected SqlCommand comandosql;
        protected string mensaje;
        public conexion()
        {
            this.cadenaconexion = (@"Data Source=(local); Initial Catalog=Eleventa; Integrated security=true");
            this.cnn = new SqlConnection(this.cadenaconexion);
        }
        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }
        }
    }
}
