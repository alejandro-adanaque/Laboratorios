using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvocatoriaCirco
{
    public partial class frmConvocatoriaCirco : Form
    {
        static double sueldo = 0;
        
        public frmConvocatoriaCirco()
        {
            
            InitializeComponent();
            
        }

        private void frmConvocatoriaCirco_Load(object sender, EventArgs e)
        {
            cboSede.Items.Add("Plaza Norte");
            cboSede.Items.Add("Real Plaza");
            cboSede.Items.Add("Mall del Sur");
            grpDtosGenerales2.Enabled = false;
            grpSueldoAproximado.Enabled = false;
            btnEvaluarRegistro.Enabled = false;
            grpHabilidades.Enabled = false;
            txtUltimaActividadRealizada.Enabled = false;
        }

        private void rbCeroADos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCeroADos.Checked)
            {
                txtUltimaActividadRealizada.Enabled = true;
                grpHabilidades.Enabled = true;
            }
        }

        private void rbDosACuatro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDosACuatro.Checked)
            {
                txtUltimaActividadRealizada.Enabled = true;
                grpHabilidades.Enabled = true;
            }
        }

        private void rbMasDeCuatro_CheckedChanged(object sender, EventArgs e)
        {
            txtUltimaActividadRealizada.Enabled = true;
            grpHabilidades.Enabled = false;
        }

        private void rbSinExperiencia_CheckedChanged(object sender, EventArgs e)
        {
            txtUltimaActividadRealizada.Enabled = false;
            grpHabilidades.Enabled = true;
        }

        private void dtpFRM_ValueChanged(object sender, EventArgs e)
        {
            int yearPC = DateTime.Now.Year;
            int yearNac = dtpFRM.Value.Year;
            int edad = yearPC - yearNac;
            string fecNac = dtpFRM.Value.ToString("dd/MM/yyyy");

            txtFecNac.Text = fecNac;
            if (edad >= 18)
            {
                grpExperienciaLaboral.Enabled = true;
                btnEvaluarRegistro.Enabled = true;
            }
            else
            {
                MessageBox.Show("Usted no Cuenta con el Perfil requerido, intentelo en otra oportunidad.");
            }
        }

        private void cboSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSede.SelectedIndex == 0)
            {
                lstPuestosRequeridos.Items.Clear();
                lstPuestosRequeridos.Items.Add("Payasos");
                lstPuestosRequeridos.Items.Add("Malabaristas");
            }
            else if (cboSede.SelectedIndex == 1)
            {
                lstPuestosRequeridos.Items.Clear();
                lstPuestosRequeridos.Items.Add("Payasos");
                lstPuestosRequeridos.Items.Add("Malabaristas");
                lstPuestosRequeridos.Items.Add("Cantantes");
                lstPuestosRequeridos.Items.Add("Bailarines");
            }
            else
            {
                lstPuestosRequeridos.Items.Clear();
                lstPuestosRequeridos.Items.Add("Payasos");
                lstPuestosRequeridos.Items.Add("Malabaristas");
                lstPuestosRequeridos.Items.Add("Cantantes");
                lstPuestosRequeridos.Items.Add("Bailarines");
                lstPuestosRequeridos.Items.Add("Imitadores");
                lstPuestosRequeridos.Items.Add("Magos");
                lstPuestosRequeridos.Items.Add("Maestro de Ceremonias");
            }
        }

        private void btnEvaluarRegistro_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreYApellidos.Text;
            MessageBox.Show($"Usted {nombre} esta Aprovado.");
            grpDtosGenerales2.Enabled = true;
            grpSueldoAproximado.Enabled = true;
        }

        private void lstPuestosRequeridos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstPuestosRequeridos.SelectedItem)
            {
                case "Payasos":
                    txtSueldo.Text = "S/.1500";
                    break;
                case "Malabaristas":
                    txtSueldo.Text = "S/.3000";
                    break;
                case "Cantantes":
                    txtSueldo.Text = "S/.2000";
                    break;
                case "Bailarines":
                    txtSueldo.Text = "S/.2000";
                    break;
                case "Imitadores":
                    txtSueldo.Text = "S/.3500";
                    break;
                case "Maestro de Ceremonia":
                    txtSueldo.Text = "S/.4000";
                    break;
                case "Magos":
                    txtSueldo.Text = "S/.3000";
                    break;


            }
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            switch (lstPuestosRequeridos.SelectedItem)
            {
                case "Payasos":
                    sueldo = sueldo + 1500;
                    break;
                case "Malabaristas":
                    sueldo = sueldo + 3000;
                    break;
                case "Cantantes":
                    sueldo = sueldo + 2000;
                    break;
                case "Bailarines":
                    sueldo = sueldo + 2000;
                    break;
                case "Imitadores":
                    sueldo = sueldo + 3500;
                    break;
                case "Magos":
                    sueldo = sueldo + 3000;
                    break;
                case "Maestro de Ceremonia":
                    sueldo = sueldo + 4000;
                    break;
            }
            switch (lstPuestosRequeridos.SelectedItem)
            {
                case "Payasos":
                    lstPuestosAContratar.Items.Add("Payasos S/.1500");
                    break;
                case "Malabaristas":
                    lstPuestosAContratar.Items.Add("Malabaristas S/.3000");
                    break;
                case "Cantantes":
                    lstPuestosAContratar.Items.Add("Cantantes S/.2000");
                    break;
                case "Bailarines":
                    lstPuestosAContratar.Items.Add("Bailarines S/.2000");
                    break;
                case "Imitadores":
                    lstPuestosAContratar.Items.Add("Imitadores S/.3500");
                    break;
                case "Magos":
                    lstPuestosAContratar.Items.Add("Magos S/.3000");
                    break;
                case "Maestro de Ceremonia":
                    lstPuestosAContratar.Items.Add("Maestro de Ceremonia S/.4000");
                    break;
            }
        }

        private void btnCalcularMontoAPagar_Click(object sender, EventArgs e)
        {
            txtMonto.Text = sueldo.ToString();
            double AFP = sueldo * 12 / 100;
            double EsSalud = sueldo * 10 / 100;
            double VidaLey = sueldo * 5 / 100;
            double Escolaridad = sueldo * 8 / 100;
            double Utilidades = sueldo * 15 / 100;
            double TotalNeto = (sueldo - (AFP + EsSalud + VidaLey)) + (Escolaridad + Utilidades);
            
            //Colocamos los montos
            txtAFP.Text = AFP.ToString();
            txtESSALUD.Text = EsSalud.ToString();
            txtVidaLey.Text = VidaLey.ToString();
            txtEscolaridad.Text = Escolaridad.ToString();
            txtUtilidades.Text = Utilidades.ToString();
            lblTotalNeto.Text = ($"TOTAL NETO : S/.{TotalNeto}");
            
        }

        private void btnQuitarP_Click(object sender, EventArgs e)
        {
            double rSueldo = 0;
            switch (lstPuestosAContratar.SelectedItem)
            {
                case "Payasos S/.1500":
                    rSueldo = 1500;
                    break;
                case "Malabaristas S./3000":
                    rSueldo = 3000;
                    break;
                case "Cantantes S/.2000":
                    rSueldo = 2000;
                    break;
                case "Bailarines S/.2000":
                    rSueldo = 2000;
                    break;
                case "Imitadores S/.3500":
                    rSueldo = 3500;
                    break;
                case "Magos S/.3500":
                    rSueldo = 3000;
                    break;
                case "Maestro de Ceremonia S/.4000":
                    rSueldo = 4000;
                    break;
            }
            lstPuestosAContratar.Items.Remove(lstPuestosAContratar.SelectedItem);
            sueldo = sueldo - rSueldo;
            
        }
        

    }
}
