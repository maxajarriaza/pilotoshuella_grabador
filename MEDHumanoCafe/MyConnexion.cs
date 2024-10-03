using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MEDHumanoCafe.Properties;
using MySql.Data.MySqlClient;

namespace MEDHumanoCafe
{
    public class DBConexion
    {
        // Lectura de App Config
        public static string ObtenerConfig()
        {
            return Settings.Default.MySqlConexion;
        }

        public static MySqlConnection EstableConexion()
        {
            //MySqlConnection oConnection = new MySqlConnection("data source=192.90.4.46; port=3306; initial catalog=monitoreo_rfid; user id=rfid; password=rf1dm3x; persist security info=false; connect timeout=90000000");
            MySqlConnection oConnection = new MySqlConnection(ObtenerConfig());
            oConnection.Open();

            return oConnection;
        }

        //MySqlConnection Conexion = new MySqlConnection();

        //static string servidor = "192.90.4.46;";
        //static string puerto = "port=3306;";
        //static string usuario = "superadmin;";
        //static string password = "ms56MEX201$;";
        //static string BDatos = "maqxsa;";

        //string cadenaconexion = "server=" + servidor + "user_id=" + usuario + "password=" + password + "persistsecurityinfo=True;database=" + BDatos + "port=" + puerto;

        //public MySqlConnection estableconexion()
        //{
        //    try
        //    {
        //        Conexion.ConnectionString = cadenaconexion;
        //        Conexion.Open();

        //    }
        //    catch (MySqlException e)
        //    {
        //        MessageBox.Show("Conexion a base de datos, Error: " e.ToString());
        //    }

        //    return Conexion;
        //}
    }
}
