using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MEDHumanoCafe
{
    public partial class ValidaHuella : ValidaForm
    {
        public int AAActual = DateTime.Now.Year, MMActual = DateTime.Now.Month, DDActual = DateTime.Now.Day, xIntentos;
        public string NameMes;
        public decimal xPiloto;

        MySqlCommand SQLComm = new MySqlCommand("set net_write_timeout=99999; set net_read_timeout=99999");

        public DPFP.Template xPlantilla;
        public delegate void OnTemplateEventHandler(DPFP.Template Plantilla);
        private DPFP.Processing.Enrollment Enrolar;

        public ValidaHuella()
        {
            InitializeComponent();
            NameMes = obtenerNombreMesNumero(MMActual);         // se obtiene nombre de mes actual
            lblFch.Text = "GUATEMALA, " + NameMes.Trim().ToUpper() + " " + DDActual + " DEL " + AAActual + ".";
        }

        private string obtenerNombreMesNumero(int numeroMes)
        {
            try
            {
                DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;
                string nombreMes = formatoFecha.GetMonthName(numeroMes);
                return nombreMes;
            }
            catch
            { return "Desconocido"; }
        }

        protected override void Inicio()
        {
            base.Inicio();
            base.Text = "Verifica Huella Digital";
            Enrolar = new DPFP.Processing.Enrollment();			// Creo enrolamiento
        }

        protected override void Procesos(DPFP.Sample Muestra)
        {
            base.Procesos(Muestra);

            DPFP.FeatureSet features = ExtractFeatures(Muestra, DPFP.Processing.DataPurpose.Verification);
            DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
            if (features != null)
            {
                using (MySqlConnection SQLConn = DBConexion.EstableConexion())
                {
                    SQLConn.Close();
                    DPFP.Verification.Verification Verificator = new DPFP.Verification.Verification();
                    MySqlDataReader xFinger;
                    SQLComm.Connection = SQLConn;
                    SQLComm.CommandText = "SELECT p.pilotoid, IdeFinger, Finger, Quality FROM pilotosfinger h LEFT JOIN pilotos p on p.pilotoid = h.pilotoid";
                    SQLConn.Open();
                    xFinger = SQLComm.ExecuteReader();
                    while (xFinger.Read())
                    {
                        xPiloto = Convert.ToDecimal(xFinger["pilotoid"]);
                        int xIdeFinger = Convert.ToInt16(xFinger["IdeFinger"]);
                        byte[] xHuella = (byte[])xFinger["Finger"];

                        Stream stream = new MemoryStream(xHuella);
                        DPFP.Template tmpObj = new DPFP.Template(stream);

                        Verificator.Verify(features, tmpObj, ref result);
                        if (result.Verified)
                        {
                            MakeReport("Huella Digital VERIFICADA.");
                            //MessageBox.Show("Huella digital de piloto verificada.", "HUELLA DIGITAL");
                            string xResult = MyMessage.ShowBox("Huella digital de piloto verificada.", "HUELLA DIGITAL");
                            break;
                        }
                    }
                    SQLConn.Close();
                }
                if (result.Verified)
                { }
                else
                {
                    //MessageBox.Show("Error : HUELLA DIGITAL incorrecta, debera de capturar una nueva huella.", "HUELLA DIGITAL");
                    string xResult = MyMessage.ShowBox("Error : HUELLA DIGITAL incorrecta, debera de capturar una nueva huella.", "HUELLA DIGITAL");
                }
            }
        }
    }
}
