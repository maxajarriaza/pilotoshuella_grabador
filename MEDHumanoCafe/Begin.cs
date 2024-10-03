using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace MEDHumanoCafe
{
    delegate void Function();

    public partial class Begin : Form
    {
        public int AAActual = DateTime.Now.Year, MMActual = DateTime.Now.Month, DDActual = DateTime.Now.Day;
        public int xItem, xPos;
        public string NameMes, xSepara = "]00000", xCod, pLicencia, xerror, msgresultado;

        MySqlCommand oComm = new MySqlCommand("set net_write_timeout=99999; set net_read_timeout=99999");
        public Begin()
        {
            InitializeComponent();
            NameMes = obtenerNombreMesNumero(MMActual);         // se obtiene nombre de mes actual
            lblFch.Text = "GUATEMALA, " + NameMes.Trim().ToUpper() + " " + DDActual + " DEL " + AAActual + ".";

            btnnuevousr.Enabled = false;

            string UsrNiv = ValidaUsuario.nivel;
            if (UsrNiv == "1")
            {
                btnnuevousr.Enabled = true;
            }
            InfoEmpleados();
            txtBoxPilLicencia.Focus();
        }

        //  nombre de mes segun numero...
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

        private void btnFinalizar_Click(object sender, EventArgs e)
        { Application.Exit(); }

        private void Begin_FormClosed(object sender, FormClosedEventArgs e)
        { Application.Exit(); }

        private void InfoEmpleados()
        {
            using (MySqlConnection DBConn = DBConexion.EstableConexion())
            {
                DBConn.Close();
                oComm.Connection = DBConn;
                MySqlDataAdapter Data = new MySqlDataAdapter();
                //oComm.CommandText = "SELECT pilotoid as IDE_PILOTO, licencia as NUMERO_LICENCIA, nombre as NOMBRES_APELLIDOS FROM pilotos WHERE CHAR_LENGTH(licencia) = 13 ORDER BY licencia";
                oComm.CommandText = "SELECT p.pilotoid as IDE_PILOTO, licencia as NUMERO_LICENCIA, nombre as NOMBRES_APELLIDOS , IFNULL(huellas,0) as huellas FROM maqxsa.pilotos p LEFT OUTER JOIN (SELECT pilotoid, count(*) as huellas FROM maqxsa.pilotosfinger group by pilotoid) h on h.pilotoid = p.pilotoid WHERE CHAR_LENGTH(licencia) = 13 ORDER BY licencia";
                Data = new MySqlDataAdapter(oComm);
                DataTable dtView = new DataTable();
                Data.Fill(dtView);
                dtGridViewEmpl.DataSource = dtView;
                DBConn.Close();
            }

        }

        private void FiltroPilLicencia(string xCodigo)
        {
            using (MySqlConnection DBConn = DBConexion.EstableConexion())
            {
                DBConn.Close();
                oComm.Connection = DBConn;
                MySqlDataAdapter Data = new MySqlDataAdapter();
                oComm.Parameters.Clear();
                oComm.Parameters.Add(new MySqlParameter("@PilLicencia", MySqlDbType.VarChar, 40)).Value = xCodigo;
                //oComm.CommandText = "SELECT pilotoid as IDE_PILOTO, licencia as NUMERO_LICENCIA, nombre as NOMBRES_APELLIDOS FROM pilotos WHERE CHAR_LENGTH(licencia) = 13 AND licencia like @PilLicencia ORDER BY licencia";
                oComm.CommandText = "SELECT p.pilotoid as IDE_PILOTO, licencia as NUMERO_LICENCIA, nombre as NOMBRES_APELLIDOS , IFNULL(huellas,0) as huellas FROM maqxsa.pilotos p LEFT OUTER JOIN (SELECT pilotoid, count(*) as huellas FROM maqxsa.pilotosfinger group by pilotoid) h on h.pilotoid = p.pilotoid WHERE CHAR_LENGTH(licencia) = 13 AND licencia like @PilLicencia ORDER BY licencia";
                Data = new MySqlDataAdapter(oComm);
                DataTable dtView = new DataTable();
                Data.Fill(dtView);
                dtGridViewEmpl.DataSource = dtView;
                DBConn.Close();
            }
        }

        private void filtroPilNombre(string xApeNom)
        {
            using (MySqlConnection DBConn = DBConexion.EstableConexion())
            {
                DBConn.Close();
                oComm.Connection = DBConn;
                MySqlDataAdapter Data = new MySqlDataAdapter();
                oComm.Parameters.Clear();
                oComm.Parameters.Add(new MySqlParameter("@PilNombre", MySqlDbType.VarChar, 60)).Value = xApeNom;
                //oComm.CommandText = "SELECT pilotoid as IDE_PILOTO, licencia as NUMERO_LICENCIA, nombre as NOMBRES_APELLIDOS FROM pilotos WHERE CHAR_LENGTH(licencia) = 13 AND nombre like @PilNombre ORDER BY licencia";
                oComm.CommandText = "SELECT p.pilotoid as IDE_PILOTO, licencia as NUMERO_LICENCIA, nombre as NOMBRES_APELLIDOS , IFNULL(huellas,0) as huellas FROM maqxsa.pilotos p LEFT OUTER JOIN (SELECT pilotoid, count(*) as huellas FROM maqxsa.pilotosfinger group by pilotoid) h on h.pilotoid = p.pilotoid WHERE CHAR_LENGTH(licencia) = 13 AND nombre like @PilNombre ORDER BY licencia";
                Data = new MySqlDataAdapter(oComm);
                DataTable dtView = new DataTable();
                Data.Fill(dtView);
                dtGridViewEmpl.DataSource = dtView;
                DBConn.Close();
            }
        }

        private void xLimpiar()
        {
            txtBoxPilNombre.Text = "";
            txtBoxPilLicencia.Text = "";
        }

        private void btnnuevousr_Click(object sender, EventArgs e)
        {
            this.Hide();
            nuevousuario inicio = new nuevousuario();
            inicio.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            xLimpiar();
            InfoEmpleados();
            txtBoxPilLicencia.Focus();
        }

        private void txtBoxPilLicencia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                if (txtBoxPilLicencia.Text.Trim() == "") 
                {
                    xerror = "SI";
                    xLimpiar();
                    InfoEmpleados();
                    txtBoxPilLicencia.Focus();
                }
                else
                {
                    if (txtBoxPilLicencia.Text.Trim().Length <= 12)
                    {
                        xerror = "SI";
                        msgresultado = MyMessage.ShowBox("Licencia no es valida.", "NOLICENCIA");
                        txtBoxPilLicencia.Focus();
                    }
                    else
                    {
                        if (txtBoxPilLicencia.Text.Trim().Length == 13)
                        {
                            xerror = "NO";
                            pLicencia = txtBoxPilLicencia.Text.Trim();
                        }
                        else
                        {
                            if (txtBoxPilLicencia.Text.Trim().Length >= 22)
                            {
                                xerror = "NO";
                                pLicencia = txtBoxPilLicencia.Text.Trim();
                                xPos = pLicencia.IndexOf(xSepara) - 22;
                                pLicencia = pLicencia.Trim().Substring(xPos, 13);
                                txtBoxPilLicencia.Text = pLicencia.Trim();
                            }
                        }
                    }
                }

                if (Validador.ValidaLicencia(pLicencia) == true)
                {
                    if (Validador.xHuellas < 3)
                    {
                        CapturaHuella Enroller = new CapturaHuella();
                        Enroller.pilotoid = Convert.ToDecimal(Validador.xPiloto);
                        Enroller.licencia = Convert.ToString(Validador.xLicencia);
                        Enroller.nombre = Convert.ToString(Validador.xNombre);
                        Enroller.OnTemplate += this.OnTemplate;
                        Enroller.ShowDialog();
                    }
                    else
                    {
                        FiltroPilLicencia("%" + txtBoxPilLicencia.Text.Trim() + "%");
                    }
                }
                else
                {
                    if (txtBoxPilLicencia.Text.Trim() != "")
                    {
                        msgresultado = MyMessage.ShowBox("Licencia scaneada no es valida.", "NOLICENCIA");
                        txtBoxPilLicencia.Focus();
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBoxPilLicencia.Text.Trim() != "")
            { FiltroPilLicencia("%" + txtBoxPilLicencia.Text.Trim() + "%"); }
            else
            {
                if (txtBoxPilNombre.Text.Trim() != "")
                { filtroPilNombre("%" + txtBoxPilNombre.Text.Trim() + "%"); }
            }
        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtBoxPilLicencia.Text.Trim() != "")
                { FiltroPilLicencia("%" + txtBoxPilLicencia.Text.Trim() + "%"); }
                else
                {
                    if (txtBoxPilNombre.Text.Trim() != "")
                    { filtroPilNombre("%" + txtBoxPilNombre.Text.Trim() + "%"); }
                }
            }
        }

        private void dtGridViewEmpl_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = dtGridViewEmpl.CurrentCell.RowIndex;
            if (iRow > -1)
            {
                CapturaHuella Enroller = new CapturaHuella();
                Enroller.pilotoid = Convert.ToDecimal(dtGridViewEmpl.Rows[e.RowIndex].Cells["IDE_PILOTO"].Value.ToString());
                Enroller.licencia = Convert.ToString(dtGridViewEmpl.Rows[e.RowIndex].Cells["NUMERO_LICENCIA"].Value.ToString());
                Enroller.nombre = Convert.ToString(dtGridViewEmpl.Rows[e.RowIndex].Cells["NOMBRES_APELLIDOS"].Value.ToString());
                Enroller.OnTemplate += this.OnTemplate;
                Enroller.ShowDialog();
            }
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate()
            {
                Template = template;
                if (Template != null)
                    msgresultado = MyMessage.ShowBox("Huella digital capturada con exito.", "OKHUELLA");
                else
                    msgresultado = MyMessage.ShowBox("La huella digital no es valida, repita proceso.", "NOHUELLA");
            }));
        }

        public DPFP.Template Template;
    }
}
