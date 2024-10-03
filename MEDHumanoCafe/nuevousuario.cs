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
    public partial class nuevousuario : Form
    {
        public string msgresultado, xnivel, outPassword, UsrAltUsr;
        public int index;

        MySqlCommand oComm = new MySqlCommand("set net_write_timeout=99999; set net_read_timeout=99999");
        public nuevousuario()
        {
            InitializeComponent();
            UsrAltUsr = ValidaUsuario.usuario;
            msgresultado = "Operador";
            index = cmbboxnivel.FindString(msgresultado);
            cmbboxnivel.SelectedIndex = index;
            txtBoxUsuario.Focus();
        }

        private void nuevousuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Begin inicio = new Begin();
            inicio.Show();
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            ValidaInformacion();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Begin inicio = new Begin();
            inicio.Show();
        }

        private void ValidaInformacion()
        {
            if (txtBoxUsuario.Text.Trim() == null)
            {
                msgresultado = MyMessage.ShowBox("Identificador de usuario no es valido.", "USRNOEXISTE");
                txtBoxUsuario.Focus();
            }
            else
            {
                if (txtBoxNombres.Text.Trim() == null || txtBoxApellidos.Text.Trim() == null)
                {
                    msgresultado = MyMessage.ShowBox("Nombres o apellidos de usuario no son validos.", "USRNOEXISTE");
                    txtBoxNombres.Focus();
                }
                else
                {
                    if (txtboxpassword.Text.Trim() != txtboxconfirmapas.Text.Trim())
                    {
                        msgresultado = MyMessage.ShowBox("Contraseñas no coinciden, verificar.", "USRNOPASSWORD");
                        txtboxpassword.Focus();
                    }
                    else
                    {
                        if (ValidaNuevoUsr.nuevoUsuario(txtBoxUsuario.Text.Trim()) == true)
                        {
                            // Actualiza registro
                            var txtpassword = Encoding.UTF8.GetBytes(txtboxpassword.Text.Trim());
                            outPassword = Convert.ToBase64String(txtpassword);

                            object xitem = cmbboxnivel.SelectedItem;
                            xnivel = xitem.ToString();
                            if (xnivel == "Administrador")
                                msgresultado = "1";
                            else
                                msgresultado = "0";

                            using (MySqlConnection DBConn = DBConexion.EstableConexion())
                            {
                                oComm.Connection = DBConn;
                                oComm.Parameters.Clear();
                                oComm.Parameters.Add(new MySqlParameter("@UsrIde", MySqlDbType.VarChar, 15)).Value = txtBoxUsuario.Text.Trim().ToUpper();
                                oComm.Parameters.Add(new MySqlParameter("@UsrNom", MySqlDbType.VarChar, 40)).Value = txtBoxNombres.Text.Trim();
                                oComm.Parameters.Add(new MySqlParameter("@UsrApe", MySqlDbType.VarChar, 40)).Value = txtBoxApellidos.Text.Trim();
                                oComm.Parameters.Add(new MySqlParameter("@UsrNiv", MySqlDbType.VarChar, 5)).Value = msgresultado;
                                oComm.Parameters.Add(new MySqlParameter("@UsrPas", MySqlDbType.VarChar, 32)).Value = outPassword;
                                oComm.Parameters.Add(new MySqlParameter("@UsrAltUsr", MySqlDbType.VarChar, 15)).Value = UsrAltUsr;
                                oComm.CommandText = "UPDATE usuarios_finger SET UsrNom = @UsrNom, UsrApe = @UsrApe, UsrNiv = @UsrNiv, UsrPas = @UsrPas, UsrAltFch = CurDate(), UsrAltUsr = @UsrAltUsr, UsrPasFchCam = date_sub(curdate(), interval 3 month) WHERE UsrIde = @UsrIde";
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
                            Begin inicio = new Begin();
                            inicio.Show();
                        }
                        else
                        {
                            // graba registro
                            var txtpassword = Encoding.UTF8.GetBytes(txtboxpassword.Text.Trim());
                            outPassword = Convert.ToBase64String(txtpassword);

                            object xitem = cmbboxnivel.SelectedItem;
                            xnivel = xitem.ToString();
                            if (xnivel == "Administrador")
                                msgresultado = "1";
                            else
                                msgresultado = "0";

                            using (MySqlConnection DBConn = DBConexion.EstableConexion())
                            {
                                oComm.Connection = DBConn;
                                oComm.Parameters.Clear();
                                oComm.Parameters.Add(new MySqlParameter("@UsrIde", MySqlDbType.VarChar, 15)).Value = txtBoxUsuario.Text.Trim().ToUpper();
                                oComm.Parameters.Add(new MySqlParameter("@UsrNom", MySqlDbType.VarChar, 40)).Value = txtBoxNombres.Text.Trim();
                                oComm.Parameters.Add(new MySqlParameter("@UsrApe", MySqlDbType.VarChar, 40)).Value = txtBoxApellidos.Text.Trim();
                                oComm.Parameters.Add(new MySqlParameter("@UsrNiv", MySqlDbType.VarChar, 5)).Value = msgresultado;
                                oComm.Parameters.Add(new MySqlParameter("@UsrPas", MySqlDbType.VarChar, 32)).Value = outPassword;
                                oComm.Parameters.Add(new MySqlParameter("@UsrAltUsr", MySqlDbType.VarChar, 15)).Value = UsrAltUsr;
                                oComm.CommandText = "INSERT INTO usuarios_finger(UsrIde, UsrNom, UsrApe, UsrNiv, UsrPas, UsrKey, UsrAltFch, UsrAltUsr, UsrPasAnt, UsrPasFchCam, UsrEst) VALUES(@UsrIde, @UsrNom, @UsrApe, @UsrNiv, @UsrPas, '', CURDATE(), @UsrAltUsr, '', date_sub(curdate(), interval 3 month), 'A')";
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
                            Begin inicio = new Begin();
                            inicio.Show();
                        }
                    }
                }
            }
        }
        private void txtBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtBoxUsuario.Text.Trim() == null)
                {
                    ValidaInformacion();
                }
                else
                {
                    if (ValidaNuevoUsr.nuevoUsuario(txtBoxUsuario.Text.Trim()) == true)
                    {
                        txtBoxUsuario.Enabled = false;
                        outPassword = Encoding.UTF8.GetString(Convert.FromBase64String(ValidaNuevoUsr.password));

                        txtBoxNombres.Text = ValidaNuevoUsr.nombres.Trim();
                        txtBoxApellidos.Text = ValidaNuevoUsr.apellidos.Trim();
                        xnivel = ValidaNuevoUsr.nivel.Trim();
                        if (xnivel == "1")
                            msgresultado = "Administrador";
                        else
                            msgresultado = "Operador";

                        index = cmbboxnivel.FindString(msgresultado);
                        cmbboxnivel.SelectedIndex = index;

                        txtboxpassword.Text = outPassword;
                        txtboxconfirmapas.Text = outPassword;
                    }
                }
            }
        }

        private void txtBoxNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ValidaInformacion();
            }
        }

        private void txtBoxApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ValidaInformacion();
            }
        }

        private void txtboxpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ValidaInformacion();
            }
        }
    }
}
