using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDHumanoCafe
{
    public partial class ValidaForm : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;

        public ValidaForm()
        {
            InitializeComponent();
        }

        protected virtual void Inicio()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Crear captura
                if (null != Capturer)
                {
                    Capturer.EventHandler = this;                   // Subscribe captura.
                }
                else
                {
                    SetPrompt("NO se inicio operacion de captura.!");
                }
            }
            catch
            { 
                string xResult = MyMessage.ShowBox("NO se pudo iniciar operación de captura de Huella Digital.!", "ERROR DE CAPTURA DE HUELLA"); 
            }
        }

        protected virtual void Procesos(DPFP.Sample Muestra)
        { 
            DrawPicture(ConvertSampleToBitmap(Muestra)); 
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    //SetPrompt("Lector listo, registre huella digital.");
                }
                catch
                { 
                    SetPrompt("NO se inicio captura de huella.!"); 
                }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try { Capturer.StopCapture(); }
                catch { SetPrompt("NO se termino captura.!"); }
            }
        }

        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Muestra)
        {
            MakeReport("Huella Digital CAPTURADA...");
            //SetPrompt("Vuelva a registrar la misma huella.");
            Procesos(Muestra);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        { MakeReport("Dedo quitado de lector."); Picture.Image = null; }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        { MakeReport("Toco el Lector de Huella Digital."); }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        { MakeReport("Lector de Huella Digital CONECTADO."); }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        { MakeReport("Lector de Huella Digital DESCONECTADO."); }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good) MakeReport("La calidad de imagen es buena.");
            else MakeReport("La calidad de imagen es regular.");
        }

        #endregion

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();	// Convierte imagen
            Bitmap bitmap = null;												            // TODO: No importa tamaño
            Convertor.ConvertToPicture(Sample, ref bitmap);									// TODO: Retorna resultado de imagen
            return bitmap;
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();	// Extrae imagen
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);			// TODO: retorna resultado?
            if (feedback == DPFP.Capture.CaptureFeedback.Good) return features;
            else return null;
        }

        protected void SetStatus(string status)
        { this.Invoke(new Function(delegate () { /*StatusLine.Text = status;*/ })); }

        protected void SetPrompt(string prompt)
        { this.Invoke(new Function(delegate () { /*Prompt.Text = prompt;*/ })); }

        protected void MakeReport(string message)
        { this.Invoke(new Function(delegate () { /*StatusText.AppendText(message + "\r\n"); */ })); }

        // hubica huella en picture
        private void DrawPicture(Bitmap bitmap)
        { this.Invoke(new Function(delegate () { Picture.Image = new Bitmap(bitmap, Picture.Size); })); }


        private void ValidaForm_Load(object sender, EventArgs e)
        {
            Inicio();
            Start();
        }

        private void ValidaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }
    }
}
