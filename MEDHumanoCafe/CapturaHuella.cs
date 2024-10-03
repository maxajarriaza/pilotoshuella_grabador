using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MEDHumanoCafe
{
    public partial class CapturaHuella : CaptureForm
    {
        public decimal pilotoid { get; set; }
        public string licencia { get; set; }
        public string nombre { get; set; }

        public int UltIde;
        public DPFP.Template xtemple;

        MySqlCommand SQLComm = new MySqlCommand("set net_write_timeout=99999; set net_read_timeout=99999");

        public delegate void OnTemplateEventHandler(DPFP.Template template);
        public event OnTemplateEventHandler OnTemplate;

        protected override void Init()
        {
            base.Init();
            base.Text = "Captura Huella Digital";
            Enroller = new DPFP.Processing.Enrollment();			// Creo enrolamiento
            UpdateStatus();
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Se toma huella para enrolar.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            // Chequea calidad de imagen
            if (features != null) try
                {
                    MakeReport("Huella Digital fue grabada con exito....");
                    Enroller.AddFeatures(features);		// Agrega imagen
                }
                finally
                {
                    UpdateStatus();

                    // Chequea si imagen fue creada
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:	// Si fue exitoso, se detiene
                            byte[] serializedTemplate = null;
                            Enroller.Template.Serialize(ref serializedTemplate);
                            if (serializedTemplate != null)
                            {
                                //string result = System.Text.Encoding.UTF8.GetString(serializedTemplate);
                                //Console.Write(result);
                                using (MySqlConnection SQLConn = DBConexion.EstableConexion())
                                {
                                    UltIde += 1;
                                    int Quality = 1;
                                    SQLConn.Close();
                                    SQLComm.Connection = SQLConn;
                                    SQLComm.Parameters.Clear();
                                    SQLComm.Parameters.Add(new MySqlParameter("@pilotoid", MySqlDbType.Decimal)).Value = pilotoid;
                                    SQLComm.Parameters.Add(new MySqlParameter("@licencia", MySqlDbType.VarChar, 12)).Value = licencia;
                                    SQLComm.Parameters.AddWithValue("@IdeFinger", UltIde);
                                    SQLComm.Parameters.AddWithValue("@Finger", serializedTemplate);
                                    SQLComm.Parameters.AddWithValue("@Quality", Quality);
                                    SQLComm.CommandText = "INSERT INTO pilotosfinger(pilotoid, IdeFinger, Finger, Quality) VALUES(@pilotoid, @IdeFinger, @Finger, @Quality)";
                                    SQLConn.Open();
                                    try
                                    {
                                        SQLComm.ExecuteNonQuery();
                                    }
                                    catch (Exception xErr)
                                    { MessageBox.Show("Error : No se agrego registro de huella digital." + xErr.ToString(), "Captura de Huella Digital"); }
                                    SQLConn.Close();
                                }
                            }
                            OnTemplate(Enroller.Template);
                            SetPrompt("Huella Digital grabada, Click en boton Retornar.");
                            Stop();
                            break;

                        case DPFP.Processing.Enrollment.Status.Failed:	// Si fallo, restaura proceso
                            Enroller.Clear();
                            Stop();
                            UpdateStatus();
                            OnTemplate(null);
                            Start();
                            break;
                    }
                }
        }

        // Muestra numero necesario de huellas
        private void UpdateStatus()
        {
            nFingerprint();
            SetStatus(String.Format("Registros de huella digital necesarios: {0}", Enroller.FeaturesNeeded));
        }

        private DPFP.Processing.Enrollment Enroller;

        public CapturaHuella()
        {
            InitializeComponent();
        }

        private void CapturaHuella_Load(object sender, EventArgs e)
        {
            lblExpediente.Text = this.pilotoid.ToString();
            lblCodigo.Text = this.licencia.Trim();
            lblApeNom.Text = this.nombre.Trim();
        }

        private void nFingerprint()
        {
            using (MySqlConnection SQLConn = DBConexion.EstableConexion())
            {
                SQLConn.Close();
                MySqlDataReader xCorre;
                SQLComm.Connection = SQLConn;
                SQLComm.Parameters.Clear();
                SQLComm.Parameters.Add(new MySqlParameter("@pilotoid", MySqlDbType.Decimal)).Value = this.pilotoid;
                SQLComm.CommandText = "Select * From pilotoulthuella Where pilotoid = @pilotoid";
                SQLConn.Open();
                xCorre = SQLComm.ExecuteReader();
                if (xCorre.HasRows)
                {
                    xCorre.Read();
                    UltIde = xCorre.GetInt16(1);
                }
                else { UltIde = 0; }
                SQLConn.Close();
            }
        }
    }
}
