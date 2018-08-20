using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_de_Bienvenida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombre = textBox1.Text;
            if(nombre.Equals("") || nombre.Length <= 2)
            {
                MessageBox.Show($"Debéra ingresar un nombre para proceder.", "ERROR");
            }
            MessageBox.Show($"Bienvenido {nombre}");
        }
    }
}
