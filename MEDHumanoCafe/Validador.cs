using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MEDHumanoCafe
{
    class Validador
    {
        private static int Piloto, Huellas;
        private static string Licencia, Nombre;

        public static int xPiloto
        { get { return Piloto; } }
        public static string xLicencia
        { get { return Licencia; } }
        public static string xNombre
        { get { return Nombre; } }
        public static int xHuellas
        { get { return Huellas; } }
        public static Boolean ValidaLicencia(String pLicencia)
        {
            MySqlCommand oComm = new MySqlCommand("set net_write_timeout=99999; set net_read_timeout=99999");

            bool resultado = false;
            using (MySqlConnection DBConn = DBConexion.EstableConexion())
            {
                oComm.Connection = DBConn;
                MySqlDataReader Data;
                oComm.Parameters.Clear();
                oComm.Parameters.Add(new MySqlParameter("@PilLicencia", MySqlDbType.VarChar, 40)).Value = pLicencia;
                //oComm.CommandText = "SELECT pilotoid, licencia, nombre FROM pilotos WHERE licencia = @PilLicencia ORDER BY licencia";
                oComm.CommandText = "SELECT p.pilotoid as IDE_PILOTO, licencia as NUMERO_LICENCIA, nombre as NOMBRES_APELLIDOS , IFNULL(huellas,0) as HUELLAS FROM maqxsa.pilotos p LEFT OUTER JOIN (SELECT pilotoid, count(*) as huellas FROM maqxsa.pilotosfinger group by pilotoid) h on h.pilotoid = p.pilotoid WHERE CHAR_LENGTH(licencia) = 13 AND licencia = @PilLicencia ORDER BY licencia";
                Data = oComm.ExecuteReader();
                if (Data.HasRows)
                {
                    Data.Read();
                    Piloto = Data.GetInt32("IDE_PILOTO");
                    Licencia = Data.GetString("NUMERO_LICENCIA");
                    Nombre = Data.GetString("NOMBRES_APELLIDOS");
                    Huellas = Data.GetInt32("HUELLAS");
                    resultado = true;
                }
                Data.Close();
                DBConn.Close();
            }
            return resultado;
        }
    }

    class ValidaUsuario
    {
        private static string usrIde, usrNom, usrApe, usrPas, usrPasAnt, usrNiv;
        private static DateTime usrPasFchCam;

        public static string usuario
        {
            get { return usrIde; }
        }
        public static string nombres
        {
            get { return usrNom; }
        }
        public static string apellidos
        {
            get { return usrApe; }
        }
        public static string password
        {
            get { return usrPas; }
        }
        public static string passanterior
        {
            get { return usrPasAnt; }
        }
        public static DateTime passfchcambio
        {
            get { return usrPasFchCam; }
        }
        public static string nivel
        {
            get { return usrNiv; }
        }
        public static Boolean usuarioInicioSesion(string xusuario)
        {
            bool resultado = false;
            MySqlCommand oComm = new MySqlCommand("set net_write_timeout=99999; set net_read_timeout=99999");
            using (MySqlConnection DBConn = DBConexion.EstableConexion())
            {
                //DBConn.Close();
                oComm.Connection = DBConn;
                MySqlDataReader Data;
                oComm.Parameters.Clear();
                oComm.Parameters.Add(new MySqlParameter("@UsrIde", MySqlDbType.VarChar, 20)).Value = xusuario;
                oComm.CommandText = "SELECT * FROM usuarios_finger WHERE UsrEst = 'A' and UsrIde = @UsrIde ORDER BY UsrIde";
                Data = oComm.ExecuteReader();
                if (Data.HasRows)
                {
                    Data.Read();
                    usrIde = Data.GetString("UsrIde");
                    usrNom = Data.GetString("UsrNom");
                    usrApe = Data.GetString("UsrApe");
                    usrPas = Data.GetString("UsrPas");
                    usrPasAnt = Data.GetString("UsrPasAnt");
                    usrPasFchCam = Data.GetDateTime("UsrPasFchCam");
                    usrNiv = Data.GetString("UsrNiv");
                    resultado = true;
                }
                Data.Close();
                DBConn.Close();
            }
            return resultado;
        }
    }

    class ValidaNuevoUsr
    {
        private static string usrIde, usrNom, usrApe, usrPas, usrPasAnt, usrNiv;
        private static DateTime usrPasFchCam;

        public static string usuario
        {
            get { return usrIde; }
        }
        public static string nombres
        {
            get { return usrNom; }
        }
        public static string apellidos
        {
            get { return usrApe; }
        }
        public static string password
        {
            get { return usrPas; }
        }
        public static string passanterior
        {
            get { return usrPasAnt; }
        }
        public static DateTime passfchcambio
        {
            get { return usrPasFchCam; }
        }
        public static string nivel
        {
            get { return usrNiv; }
        }
        public static Boolean nuevoUsuario(string xusuario)
        {
            bool resultado = false;
            MySqlCommand oComm = new MySqlCommand("set net_write_timeout=99999; set net_read_timeout=99999");
            using (MySqlConnection DBConn = DBConexion.EstableConexion())
            {
                //DBConn.Close();
                oComm.Connection = DBConn;
                MySqlDataReader Data;
                oComm.Parameters.Clear();
                oComm.Parameters.Add(new MySqlParameter("@UsrIde", MySqlDbType.VarChar, 20)).Value = xusuario;
                oComm.CommandText = "SELECT * FROM usuarios_finger WHERE UsrEst = 'A' and UsrIde = @UsrIde ORDER BY UsrIde";
                Data = oComm.ExecuteReader();
                if (Data.HasRows)
                {
                    Data.Read();
                    usrIde = Data.GetString("UsrIde");
                    usrNom = Data.GetString("UsrNom");
                    usrApe = Data.GetString("UsrApe");
                    usrPas = Data.GetString("UsrPas");
                    usrPasAnt = Data.GetString("UsrPasAnt");
                    usrPasFchCam = Data.GetDateTime("UsrPasFchCam");
                    usrNiv = Data.GetString("UsrNiv");
                    resultado = true;
                }
                Data.Close();
                DBConn.Close();
            }
            return resultado;
        }
    }
}
