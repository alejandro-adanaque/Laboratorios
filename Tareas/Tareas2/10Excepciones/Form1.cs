using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10Excepciones
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

      
        private void btnCapturar_Click(object sender, EventArgs e)
        {
            int _nro = int.Parse(txtNumeroEmpleado.Text);
            string _nombre = txtNombreEmpleado.Text;
            int _edad = int.Parse(txtEdadEmpleado.Text);
            
                MessageBox.Show($"Bienvenido:  {_nombre} \nCon Numero:  {_nro} \nY edad:  {_edad}");
            
            
                txtNumeroEmpleado.Clear();
                txtNumeroEmpleado.Enabled = true;
                txtNombreEmpleado.Clear();
                txtNombreEmpleado.Enabled = true;
                txtEdadEmpleado.Clear();
                txtEdadEmpleado.Enabled = true;
                txtNumeroEmpleado.Focus();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void txtNombreEmpleado_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNumeroEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                try
                {
                    int nro = int.Parse(txtNumeroEmpleado.Text);
                    MessageBox.Show("Correcto");
                    txtNumeroEmpleado.Enabled = false;
                    txtNombreEmpleado.Enabled = true;
                    txtNombreEmpleado.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error");
                    txtNumeroEmpleado.Focus();
                    txtNumeroEmpleado.Clear();
                }
            }
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            txtNombreEmpleado.Enabled = false;
            txtEdadEmpleado.Enabled = false;
            btnCapturar.Enabled = false;
            MessageBox.Show("Para verificar Presione 'Enter' luego de haber digitado sus datos, en cada recuadro.", "Atención",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void txtNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (e.KeyChar == (Char)13)
            {
                try
                {
                    string nombre = txtNombreEmpleado.Text;
                    if (txtNombreEmpleado.Text == String.Empty)
                    {
                        MessageBox.Show("Rellene el cuadro por favor.", "Advertencia");
                        txtNombreEmpleado.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Correcto");
                        txtEdadEmpleado.Enabled = true;
                        txtNombreEmpleado.Enabled = false;
                    }
                }
                catch(Exception exS)
                {
                    MessageBox.Show($"{exS.Message}", "Error");
                    txtNombreEmpleado.Clear();
                    txtNombreEmpleado.Focus();
                }
               
            }
        }

        private void txtEdadEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                try
                {
                    int edad = int.Parse(txtEdadEmpleado.Text);
                    MessageBox.Show("Correcto");
                    txtEdadEmpleado.Enabled = false;
                   
                    btnCapturar.Enabled = true;
                    btnCapturar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error");
                    txtEdadEmpleado.Focus();
                    txtEdadEmpleado.Clear();
                    
                }
            }
        }
    }
}
