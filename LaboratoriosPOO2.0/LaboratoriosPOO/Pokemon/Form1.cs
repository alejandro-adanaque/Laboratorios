using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class frmPokemons : Form
    {
        static int nuFilas = 1;
        public frmPokemons()
        {
            InitializeComponent();
        }

        public void limpiarControles()
        {
            txtNombrePokemon.Clear();
            txtEspeciePokemon.Clear();
            txtHabilidadPokemon.Clear();
            txtAlturaPokemon.Clear();
            txtPesoPokemon.Clear();
            txtHabitadPokemon.Clear();
            txtNombrePokemon.Focus();
        }

        private void frmPokemons_Load(object sender, EventArgs e)
        {
            //Inicializando Colores
            cboColorPokemon.Items.Add("Amarillo");
            cboColorPokemon.Items.Add("Verde");
            cboColorPokemon.Items.Add("Anaranjado");
            cboColorPokemon.Items.Add("Morado");
            cboColorPokemon.Items.Add("Marron");
            cboColorPokemon.Items.Add("Rojo");


            //MessageBox.Show("Bienvenido al entorno Pokemon... \n Deberá crear sus pokemones y agregarlos a la lista", "Mensaje");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string _nombre = txtNombrePokemon.Text;
            string _especie = txtEspeciePokemon.Text;
            string _habilidad = txtHabilidadPokemon.Text;
            double _peso = Double.Parse(txtPesoPokemon.Text);
            double _altura = Double.Parse(txtAlturaPokemon.Text);
            string _color = cboColorPokemon.SelectedItem.ToString();
            string _habitad = txtHabitadPokemon.Text;

            //Crear pokemon (instanciar)
            Pokemons pokemon1 = new Pokemons(_nombre, _especie, _habilidad, _peso, _altura, _color, _habitad);
            MessageBox.Show($"nombre: {pokemon1.Nombre}", "titulo");
            limpiarControles();

            
            //Agregar el pokemon a la Grilla/Grid/Tabla/GridView
            dgbPokemons.Rows.Add(nuFilas++,pokemon1.Nombre, pokemon1.Especie, pokemon1.Habilidad, pokemon1.Peso, pokemon1.Altura, pokemon1.Color, pokemon1.Habitad);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }
    }
}
