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
    public partial class CambioPassword : Form
    {
        public string msgresultado, nuevopassword, actualpassword;
        // contextor mysql
        MySqlCommand oComm = new MySqlCommand("set net_write_timeout=99999; set net_read_timeout=99999");
        public CambioPassword()
        {
            InitializeComponent();
            lblusuario.Text = ValidaUsuario.usuario.Trim();
            lblnom.Text = ValidaUsuario.nombres.Trim();
            lblape.Text = ValidaUsuario.apellidos.Trim();

            txtboxnueva.Focus();
        }

        private void CambioPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            InicioSesion inicio = new InicioSesion();
            inicio.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesion inicio = new InicioSesion();
            inicio.Show();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Aplicarcambio();
        }

        private void Aplicarcambio()
        {
            if (txtboxnueva.Text.Trim() == ValidaUsuario.passanterior.Trim())
            {
                msgresultado = MyMessage.ShowBox("Contraseña ya fue utilizada anteriormente.", "CAMBIAR CONTRASEÑA");
                txtboxnueva.Focus();
            }
            else
            {
                if (txtboxnueva.Text.Trim() != txtboxconfirma.Text.Trim())
                {
                    msgresultado = MyMessage.ShowBox("Confirmación de contraseña no es correcta.", "CAMBIAR CONTRASEÑA");
                    txtboxconfirma.Focus();
                }
                else
                {
                    var txtpassword = Encoding.UTF8.GetBytes(txtboxnueva.Text.Trim());
                    nuevopassword = Convert.ToBase64String(txtpassword);

                    txtpassword = Encoding.UTF8.GetBytes(ValidaUsuario.password);
                    actualpassword = Convert.ToBase64String(txtpassword);

                    using (MySqlConnection DBConn = DBConexion.EstableConexion())
                    {
                        oComm.Connection = DBConn;
                        oComm.Parameters.Clear();
                        oComm.Parameters.Add(new MySqlParameter("@UsrIde", MySqlDbType.VarChar, 15)).Value = ValidaUsuario.usuario;
                        oComm.Parameters.Add(new MySqlParameter("@UsrPas", MySqlDbType.VarChar, 32)).Value = nuevopassword;
                        oComm.Parameters.Add(new MySqlParameter("@UsrPasAnt", MySqlDbType.VarChar, 15)).Value = actualpassword;
                        oComm.CommandText = "UPDATE usuarios_finger SET UsrPas = @UsrPas, UsrPasAnt = @UsrPasAnt, UsrPasFchCam = CurDate() WHERE UsrEst = 'A' and UsrIde = @UsrIde";
                        try
                        {
                            oComm.ExecuteNonQuery();
                        }
                        catch (Exception err)
                        { 
                            MessageBox.Show(err.ToString()); 
                        }
                        DBConn.Close();
                    }
                    this.Hide();
                    InicioSesion inicio = new InicioSesion();
                    inicio.Show();
                }
            }
        }

        private void txtboxnueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Aplicarcambio();
            }
        }

        private void txtboxconfirma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Aplicarcambio();
            }
        }
    }
}
