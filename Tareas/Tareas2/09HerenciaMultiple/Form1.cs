using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09HerenciaMultiple
{
    public partial class Form1 : Form
    {
        
        Trabajador secretaria1 = new Trabajador();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }   

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            double horaXsemanal = double.Parse(txtHorasTrabajo.Text);
            string _nombre = txtNombre.Text;
            string _apellidos = txtApellidos.Text;
            string _dni = txtDNI.Text;
            

            Trabajador secretaria1 = new Trabajador();
            double _salarioMensual = secretaria1.obtenerSalario(horaXsemanal);
            txtR.Text = $"==Registro Pago de Secretaria== \r\n==============================================================" +
                $" \r\nNombre:  { _nombre} \r\nApellidos: {_apellidos} \r\nDNI: {_dni} \r\nHoras Semanales: {horaXsemanal} \r\nSalario Mensual: {_salarioMensual} ";

            txtNombre.Clear();
            txtApellidos.Clear();
            txtDNI.Clear();
            txtHorasTrabajo.Clear();

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    
    }
}
