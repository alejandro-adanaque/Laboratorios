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
        static string img_Pokemon = "D:/LaboratoriosPOO/Pokemon/ImgPokémon";
        static string img_Entrenador = "D:/LaboratoriosPOO/Pokemon/ImgEntrenador";
        public frmPokemons()
        {
            InitializeComponent();
        }

        public void limpiarControles()
        {
            
            txtEspeciePokemon.Clear();
            txtHabilidadPokemon.Clear();
            txtAlturaPokemon.Clear();
            txtPesoPokemon.Clear();
            txtHabitadPokemon.Clear();
            cboNombre.Focus();
        }

        private void frmPokemons_Load(object sender, EventArgs e)
        {

            //Inicializando Colores
            cboColorPokemon.Items.Add("-Seleccione Color-");
            cboColorPokemon.Items.Add("Amarillo");
            cboColorPokemon.Items.Add("Verde");
            cboColorPokemon.Items.Add("Anaranjado");
            cboColorPokemon.Items.Add("Morado");
            cboColorPokemon.Items.Add("Marron");
            cboColorPokemon.Items.Add("Rojo");

            //Inicializando Nombres
            cboNombre.Items.Add("-Seleccione Pokémon-");
            //cboNombre.Items.Add("Bulbasaur");
            //cboNombre.Items.Add("Charmander");
            // cboNombre.Items.Add("Squirtle");

            
            cboNombre.SelectedIndex = 0;
            
            cboColorPokemon.SelectedIndex = 0;

            //Entrenadores
            cboEntrenador.Items.Add("-Selecciona un Entrenador-");
            cboEntrenador.Items.Add("Brock");
            cboEntrenador.Items.Add("Misty");
            cboEntrenador.Items.Add("Azul");
           // cboEntrenador.Items.Add("Lt.Surge");
            cboEntrenador.SelectedIndex = 0;


            //MessageBox.Show("Bienvenido al entorno Pokemon... \n Deberá crear sus pokemones y agregarlos a la lista", "Mensaje");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string _nombre = cboNombre.SelectedItem.ToString();
                string _especie = txtEspeciePokemon.Text;
                string _habilidad = txtHabilidadPokemon.Text;
                double _peso = Double.Parse(txtPesoPokemon.Text);
                double _altura = Double.Parse(txtAlturaPokemon.Text);
                string _color = cboColorPokemon.SelectedItem.ToString();
                string _habitad = txtHabitadPokemon.Text;

                if (_nombre.Equals(string.Empty))
                {
                    MessageBox.Show("Debe elegir un pokemon");
                }
                else
                {


                    //Crear pokemon (instanciar)
                    Pokemons pokemon1 = new Pokemons(_nombre, _especie, _habilidad, _peso, _altura, _color, _habitad);
                    MessageBox.Show($"nombre: {pokemon1.Nombre}", "titulo");
                    limpiarControles();


                    //Agregar el pokemon a la Grilla/Grid/Tabla/GridView
                    dgbPokemons.Rows.Add(nuFilas++, pokemon1.Nombre, pokemon1.Especie, pokemon1.Habilidad, pokemon1.Peso, pokemon1.Altura, pokemon1.Color, pokemon1.Habitad);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void cboNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cboNombre.SelectedItem.ToString() == "Bulbasaur")
            {
                imgPokemon.ImageLocation = img_Pokemon+"/001.png";
                btnAgregar.Enabled = true;
            }
            else if (cboNombre.SelectedItem.ToString() == "Charmander") 
            {
                imgPokemon.ImageLocation = img_Pokemon+"/004.png";
                btnAgregar.Enabled = true;
            }
            else if (cboNombre.SelectedItem.ToString()== "Squirtle")
            {
                imgPokemon.ImageLocation = img_Pokemon+"/007.png";
                btnAgregar.Enabled = true;
            }
            else if (cboNombre.SelectedIndex == 0)
            {
                imgPokemon.ImageLocation = img_Pokemon + "/pokeball.png";
                btnAgregar.Enabled = false;
            }
            
        }

        private void txtHabitadPokemon_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboEntrenador_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cboEntrenador.SelectedItem.ToString() == "Brock")
            {
                imgEntrenador.ImageLocation = img_Entrenador + "/VS_Brock.png";
                cboNombre.Items.Add("Charmander");
            }

            else if (cboEntrenador.SelectedItem.ToString() == "Misty")
            {
                imgEntrenador.ImageLocation = img_Entrenador + "/VS_Misty.png";
                cboNombre.Items.Add("Squirtle");
            }
            else if (cboEntrenador.SelectedItem.ToString() == "Azul")
            {
                imgEntrenador.ImageLocation = img_Entrenador + "/VS_Azul.png";
                cboNombre.Items.Add("Bulbasaur");
            }
            else if (cboEntrenador.SelectedIndex == 0)
            {
                imgEntrenador.ImageLocation = img_Entrenador + "/xxx046-512.png";
            }
           
            //else if (cboEntrenador.SelectedItem.ToString() == "Lt.Surge")
            //{
                //imgEntrenador.ImageLocation = img_Entrenador+"/VS_Lt._Surge.png";
            //}
        }

        private void cboEntrenador_Click(object sender, EventArgs e)
        {
            //cboEntrenador.Items.Clear();
            cboNombre.Items.Clear();
        }
    }
}
