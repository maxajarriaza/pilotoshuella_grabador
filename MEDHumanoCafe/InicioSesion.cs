using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MEDHumanoCafe
{
    public partial class InicioSesion : Form
    {
        // Variables publicas
        public string namemes, xidentificador, xbuscador = "-", msgresultado;
        public string outPassword = string.Empty;
        public int aaActual = DateTime.Now.Year, mmActual = DateTime.Now.Month, ddActual = DateTime.Now.Day;
        public int xposicion, xdias;
        public DateTime camPassword;

        // contextor mysql
        MySqlCommand oComm = new MySqlCommand("set net_write_timeout=99999; set net_read_timeout=99999");

        // evento de inicio
        public InicioSesion()
        {
            InitializeComponent();
            namemes = obtenerNombreMesNumero(mmActual);         // se obtiene nombre de mes actual
            lblFcha.Text = "Guatemala, " + namemes.Trim() + " " + ddActual + " del " + aaActual + ".";

        }
        // evento load
        private void InicioSesion_Load(object sender, EventArgs e)
        {
            txtboxusuario.Focus();
        }
        // evento close
        private void InicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // boton cancelar
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //  nombre de mes segun numero de mes...
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

        // presiona enter en usuario
        private void txtboxusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Validainicio();
            }
        }
        // presiona enter en password
        private void txtboxpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Validainicio();
            }
        }
        // click en boto inicio de sesion
        private void btnenter_Click(object sender, EventArgs e)
        {
            Validainicio();
        }
        // evento de validación
        private void Validainicio()
        {
            if (txtboxusuario.Text.Trim() != null)
            {
                // valida usuario indicado
                if (ValidaUsuario.usuarioInicioSesion(txtboxusuario.Text.Trim()) == true)
                {
                    // cambio de contraseña bimestral
                    camPassword = ValidaUsuario.passfchcambio.AddMonths(2);

                    TimeSpan xcntDias = camPassword.Subtract(DateTime.Today);
                    xdias = xcntDias.Days;
                    // valida contraseña ingresada
                    var pTexto = Encoding.UTF8.GetBytes(txtboxpassword.Text.Trim());
                    outPassword = Convert.ToBase64String(pTexto);
                    if (outPassword != ValidaUsuario.password)
                    {
                        msgresultado = MyMessage.ShowBox("Contraseña indicada no es valida.", "USRNOPASSWORD");
                    }
                    else
                    {
                        this.Hide();
                        if (xdias <= 0)
                        {
                            CambioPassword oviewCambio = new CambioPassword();
                            oviewCambio.Show();
                        }
                        else
                        {
                            Begin oviewBegin = new Begin();
                            oviewBegin.Show();
                        }
                    }
                }
                else
                {
                    msgresultado = MyMessage.ShowBox("Usuario indicado en inicio de sesión no existe.", "USRNOEXISTE");
                }
            }
            else
            {
                msgresultado = MyMessage.ShowBox("Indique un usuario valido para inicio de sesión.", "USRNOEXISTE");
            }
        }
    }
}
