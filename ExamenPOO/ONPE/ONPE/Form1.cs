using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONPE
{
    public partial class fmrSorteoDeMiembrosDeMesa : Form
    {
        public fmrSorteoDeMiembrosDeMesa()
        {
            InitializeComponent();
        }

        private void fmrSorteoDeMiembrosDeMesa_Load(object sender, EventArgs e)
        {
            cboProvincia.Enabled = true;
            cboDistrito.Enabled = true;
            cboDepartamento.Enabled = true;

            cboDocumento.Items.Add("DNI");
            cboDocumento.Items.Add("Carnet Ext.");
            cboDepartamento.Items.Add("Lima");
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cboProvincia.Items.Add("Lima");
            cboProvincia.Items.Add("Huaral");
            cboProvincia.Items.Add("Huarochiri");
            cboProvincia.Enabled = true;
        }
        
        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedItem.ToString() == "Lima")
            {
                cboDistrito.Items.Add("Lima");
                cboDistrito.Items.Add("Ancon");
                cboDistrito.Items.Add("Ate");
                cboDistrito.Items.Add("Breña");
                cboDistrito.Items.Add("Carabayllo");
                cboDistrito.Items.Add("Comas");
                cboDistrito.Items.Add("Chaclacayo");
                cboDistrito.Items.Add("Chorrillos");
                cboDistrito.Items.Add("La Victoria");
                
            }
           

            else if (cboProvincia.SelectedItem.ToString() == "Huaral")
            {
                cboDistrito.Items.Add("Huaral");
                cboDistrito.Items.Add("Atavillos Altos");
                cboDistrito.Items.Add("Atavillos Bajos");
            }
            
            else
            {
                cboDistrito.Items.Add("Matucana");
                cboDistrito.Items.Add("Antioquia");
                cboDistrito.Items.Add("Callahuanca");
                
            }
            
        }

        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = string.Empty;

            if (cboProvincia.SelectedIndex == 0)
            {

                switch (cboDistrito.SelectedIndex)
                {
                    case 0:
                        n = "140101";
                        break;
                    case 1:
                        n = "140102";
                        break;
                    case 2:
                        n = "140103";
                        break;
                    case 3:
                        n = "140104";
                        break;
                    case 4:
                        n = "140105";
                        break;
                    case 5:
                        n = "140106";
                        break;
                    case 6:
                        n = "140107";
                        break;
                    case 7:
                        n = "140108";
                        break;
                    case 8:
                        n = "140109";
                        break;

                }
            }
            else if (cboProvincia.SelectedIndex == 1)
            {
                switch (cboDistrito.SelectedIndex)
                {
                    case 0:
                        n = "140801";
                        break;
                    case 1:
                        n = "140802";
                        break;
                    case 2:
                        n = "140803";
                        break;
                }
            }
            else
            {
                switch (cboDistrito.SelectedIndex)
                {
                    case 0:
                        n = "140601";
                        break;
                    case 1:
                        n = "140602";
                        break;
                    case 2:
                        n = "140603";
                        break;
                }
            }
            txtUbigeo.Text = n;
            cboDepartamento.Items.Remove(cboProvincia.SelectedIndex);
            cboProvincia.Items.Remove(cboProvincia.SelectedIndex);
            cboDistrito.Items.Remove(cboDistrito.SelectedIndex);
            lstUbigeosSorteados.Items.Add($"{n} - {cboProvincia.SelectedItem}");
        }
    }
}
