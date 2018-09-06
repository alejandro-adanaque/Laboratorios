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
            btnRegistrarSorteo.Enabled = false;
            

            cboDocumento.Items.Add("DNI");
            cboDocumento.Items.Add("Carnet Ext.");
            cboDepartamento.Items.Add("Lima");
            this.cboDocumento.SelectedItem = null;
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.SelectedItem.ToString()=="Lima")
            {
                cboProvincia.Items.Add("Lima");
                cboProvincia.Items.Add("Huaral");
                cboProvincia.Items.Add("Huarochiri");
            }
        }
        
        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedItem.ToString()=="Lima")
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


            else if (cboProvincia.SelectedItem.ToString()=="Huaral")
            {
                cboDistrito.Items.Add("Huaral");
                cboDistrito.Items.Add("Atavillos Alto");
                cboDistrito.Items.Add("Atavillos Bajo");
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
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;

            if (cboDepartamento.SelectedIndex == 0)
            {
                n1 = 140;
                switch(cboProvincia.SelectedItem)
                {
                    case "Lima":
                        n2 = 1;
                        break;
                    case "Huaral":
                        n2 = 8;
                        break;
                    case "Huarochiri":
                        n2 = 6;
                        break;
                }
                switch (cboDistrito.SelectedItem)
                {
                    case "Lima":
                        n3 = 001;
                        break;
                    case "Ancon":
                        n3 = 02;
                        break;
                    case "Ate":
                        n3 = 03;
                        break;
                    case "Breña":
                        n3 = 04;
                        break;
                    case "Carabayllo":
                        n3 = 05;
                        break;
                    case "Comas":
                        n3 = 06;
                        break;
                    case "Chaclacayo":
                        n3 = 07;
                        break;
                    case "Chorrillos":
                        n3 = 08;
                        break;
                    case "La victoria":
                        n3 = 09;
                        break;
                    case "Huaral":
                        n3 = 01;
                        break;
                    case "Atavillos Alto":
                        n3 = 02;
                        break;
                    case "Atavillos Bajo":
                        n3 = 03;
                        break;
                    case "Matucana":
                        n3 = 01;
                        break;
                    case "Atioquia":
                        n3 = 02;
                        break;
                    case "Callahuanca":
                        n3 = 03;
                        break;
                }
            }
            txtUbigeo.Text = $"{n1}{n2}0{n3}";
        }

        private void cboDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            cboProvincia.Items.Clear();
        }

        private void cboProvincia_MouseClick(object sender, MouseEventArgs e)
        {
            cboDistrito.Items.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string numeroID = txtNumero.Text;
            string id = cboDocumento.SelectedItem.ToString();
            
            int numeroPersonas = lstPersonas.Items.Count;
            int numeroPersonas2 = numeroPersonas + 1;
            
            if (numeroPersonas2 >= 8)
            {
                btnRegistrarSorteo.Enabled = true;
            }
            else
            {
                btnRegistrarSorteo.Enabled = false;
            }
            
            //Imprimir en la lista 
            lstPersonas.Items.Add($"{apellidos} {nombres} - {id} {numeroID}");

            //Imprimir el label
            lblNumeroPersonas.Text = ($"Nro.Personas: {numeroPersonas2}");

            //Borramos los datos para poner otros
            txtApellidos.Clear();
            txtNombres.Clear();
            txtNumero.Clear();
            txtApellidos.Focus();
        }

        private void rbDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDescripcion.Checked)
            {
                cboDepartamento.Enabled = true;
                cboDistrito.Enabled = true;
                cboProvincia.Enabled = true;
                txtUbigeo.Enabled = false;
            }
        }

        private void rbUbigeo_CheckedChanged(object sender, EventArgs e)
        {
            txtUbigeo.Enabled = true;
            cboDepartamento.Enabled = false;
            cboDistrito.Enabled = false;
            cboProvincia.Enabled = false;
          
            
        }



        private void btnRegistrarSorteo_Click(object sender, EventArgs e)
        {
            string ubigeo = txtUbigeo.Text;

            if (ubigeo == String.Empty || txtMesaDeVotacion.Text == string.Empty)
            {
                MessageBox.Show("Faltan Datos", "Alerta");
            }
            else
            {
                if (rbUbigeo.Checked)
                {


                    switch (ubigeo)
                    {
                        case "140101":
                            lstUbigeosSorteados.Items.Add($"140101-Lima");
                            break;
                        case "140102":
                            lstUbigeosSorteados.Items.Add($"140102-Lima");
                            break;
                        case "140103":
                            lstUbigeosSorteados.Items.Add($"140103-Lima");
                            break;
                        case "140104":
                            lstUbigeosSorteados.Items.Add($"140104-Lima");
                            break;
                        case "140105":
                            lstUbigeosSorteados.Items.Add($"140105-Lima");
                            break;
                        case "140106":
                            lstUbigeosSorteados.Items.Add($"140106-Lima");
                            break;
                        case "140107":
                            lstUbigeosSorteados.Items.Add($"140107-Lima");
                            break;
                        case "140108":
                            lstUbigeosSorteados.Items.Add($"140108-Lima");
                            break;
                        case "140109":
                            lstUbigeosSorteados.Items.Add($"140109-Lima");
                            break;
                        case "140801":
                            lstUbigeosSorteados.Items.Add($"140801-Huaral");
                            break;
                        case "140802":
                            lstUbigeosSorteados.Items.Add($"140802-Huaral");
                            break;
                        case "140803":
                            lstUbigeosSorteados.Items.Add($"140803-Huaral");
                            break;
                        case "140601":
                            lstUbigeosSorteados.Items.Add($"140601-Huarochiri");
                            break;
                        case "140602":
                            lstUbigeosSorteados.Items.Add($"140602-Huarochiri");
                            break;
                        case "140603":
                            lstUbigeosSorteados.Items.Add($"140603-Huarochiri");
                            break;
                        default:
                            MessageBox.Show("No se encontro este UBIGEO");
                            break;
                    }
                    MessageBox.Show("Correcto");
                    txtUbigeo.Clear();
                    txtMesaDeVotacion.Clear();
                }
                else
                {
                    txtUbigeo.Clear();
                    txtMesaDeVotacion.Clear();
                    lstUbigeosSorteados.Items.Add($"{ubigeo} - {cboProvincia.SelectedItem}");
                }
            }
        }
        }
    }

