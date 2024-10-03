using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MEDHumanoCafe
{
    public partial class CaptureForm : Form, DPFP.Capture.EventHandler
    {
        MySqlCommand SQLComm = new MySqlCommand("set net_write_timeout=99999; set net_read_timeout=99999");

        public CaptureForm()
        { 
            InitializeComponent();
        }

        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Crear captura

                if (null != Capturer)
                    Capturer.EventHandler = this;					// Subscribe captura.
                else
                    SetPrompt("NO se inicio operacion de captura.!");
            }
            catch
            { MessageBox.Show("NO se pudo iniciar operación de captura de imagen.!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // Toma imagen de huella digital (dibuja).
        protected virtual void Process(DPFP.Sample Sample)
        { DrawPicture(ConvertSampleToBitmap(Sample)); }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Lector listo, registre huella digital.");
                }
                catch
                { SetPrompt("NO se inicio captura de huella.!"); }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                { Capturer.StopCapture(); }
                catch
                { SetPrompt("NO se termino captura.!"); }
            }
        }

        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            MakeReport("Huella digital capturada...");
            SetPrompt("Vuelva a registrar la misma huella.");
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        { MakeReport("El dedo fue quitado del lector."); }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        { MakeReport("Se toco el lector de huella."); }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        { MakeReport("El lector de huella ha sido conectado."); }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        { MakeReport("El lector de huella fue desconectado."); }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("La calidad de imagen es buena.");
            else
                MakeReport("La calidad de imagen es regular.");
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
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        protected void SetStatus(string status)
        { this.Invoke(new Function(delegate() { StatusLine.Text = status; })); }

        protected void SetPrompt(string prompt)
        { this.Invoke(new Function(delegate() { Prompt.Text = prompt; })); }

        protected void MakeReport(string message)
        { this.Invoke(new Function(delegate() { StatusText.AppendText(message + "\r\n"); })); }

        // hubica huella en picture
        private void DrawPicture(Bitmap bitmap)
        { this.Invoke(new Function(delegate() { Picture.Image = new Bitmap(bitmap, Picture.Size);	}));  }

        private DPFP.Capture.Capture Capturer;

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Stop();
            this.Close();
        }

        private void CaptureForm_Load(object sender, EventArgs e)
        {
            Init();
            Start();
        }

        private void CaptureForm_FormClosed(object sender, FormClosedEventArgs e)
        { Stop(); }
    }
}
