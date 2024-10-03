using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDHumanoCafe
{
    public partial class MyMessage : Form
    {
        static MyMessage newMsg;
        public Timer msgTimer;
        static string btn_id;
        int disposeFormTimer;

        public MyMessage()
        {
            InitializeComponent();
        }

        public static string ShowBox(string txtMsg)
        {
            newMsg = new MyMessage();
            newMsg.lblMessage.Text = txtMsg;
            newMsg.ShowDialog();
            return btn_id;
        }

        public static string ShowBox(string txtMsg, string TitMsg)
        {
            newMsg = new MyMessage();
            newMsg.lblMessage.Text = txtMsg;
            if (TitMsg == "USRNOEXISTE")
            {
                // ROJO
                newMsg.lblMessage.BackColor = Color.FromArgb(255, 64, 64);
                TitMsg = "USUARIO DE SISTEMA";
            }
            if (TitMsg == "USRNOPASSWORD")
            {
                // AMARILLO
                newMsg.lblMessage.BackColor = Color.FromArgb(255, 242, 0);
                TitMsg = "CONTRASEÑA USUARIO";
            }
            if (TitMsg == "OKHUELLA")
            {
                // VERDE
                newMsg.lblMessage.BackColor = Color.FromArgb(0, 255, 125);
                TitMsg = "HUELLA DIGITAL PILOTO";
            }
            if (TitMsg == "NOHUELLA")
            {
                // ROJO
                newMsg.lblMessage.BackColor = Color.FromArgb(255, 64, 64);
                TitMsg = "HUELLA DIGITAL PILOTO";
            }
            if (TitMsg == "NOLICENCIA")
            {
                // AMARILLO
                newMsg.lblMessage.BackColor = Color.FromArgb(255, 242, 0);
                TitMsg = "LICENCIA PILOTO";
            }
            newMsg.lblTitle.Text = TitMsg;
            newMsg.ShowDialog();
            return btn_id;
        }

        private void myMessage_Paint(object sender, PaintEventArgs e)
        {
            Graphics mGraphics = e.Graphics;
            Pen pen1 = new Pen(Color.FromArgb(255, 242, 0), 1);

            Rectangle Area1 = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush LGB = new LinearGradientBrush(Area1, Color.FromArgb(255, 242, 0), Color.FromArgb(255, 255, 255), LinearGradientMode.Vertical);
            mGraphics.FillRectangle(LGB, Area1);
            mGraphics.DrawRectangle(pen1, Area1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            newMsg.msgTimer.Stop();
            newMsg.msgTimer.Dispose();
            btn_id = "1";
            newMsg.Dispose();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            disposeFormTimer--;

            if (disposeFormTimer >= 0)
            {
                newMsg.lblTimer.Text = disposeFormTimer.ToString();
                Console.Beep(415, 1000);
            }
            else
            {
                newMsg.msgTimer.Stop();
                newMsg.msgTimer.Dispose();
                newMsg.Dispose();
            }
        }

        private void MyMessage_Load(object sender, EventArgs e)
        {
            disposeFormTimer = 6;
            newMsg.lblTimer.Text = disposeFormTimer.ToString();
            msgTimer = new Timer();
            msgTimer.Interval = 1000;
            msgTimer.Enabled = true;
            msgTimer.Start();
            msgTimer.Tick += new EventHandler(this.timer_tick);
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {

        }
    }
}
