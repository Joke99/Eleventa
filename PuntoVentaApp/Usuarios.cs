using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PuntoVentaApp
{
    class Usuarios:conexion
    {
        private string usuario;
        private string contraseña;

        public Usuarios()
        {
            usuario = string.Empty;
            contraseña = string.Empty;
            this.sql = string.Empty;
        }
        public  string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }
        public string Contraseña
        {
            get { return this.contraseña; }
            set { this.contraseña = value; }
        }
        public bool Buscar()
        {
            bool Resultado = false;

           this.sql = string.Format(@"SELECT Id_Usuario FROM Usuarios where NickName='{0}'AND Contraseña='{1}'", this.usuario, this.contraseña);
            this.comandosql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read())
            {
                Resultado = true;
                this.mensaje = "Bienvenidos,Datos correctos";
            }
            else
            {
                this.mensaje = "Datos Incorrectos ,Verifique por favor";
            }
            this.cnn.Close();
            return Resultado;
        }
    }
}
