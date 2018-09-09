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
        static List<Pokemons> lstPokesRivales = new List<Pokemons>();

        public Pokemons obtenerPokemonRival()
        {
            Random rnd = new Random();
            int indices = rnd.Next(0,4);
            return lstPokesRivales[indices];
        }

        public void crearPokemonesRivales()
        {
            Pokemons miPokemon1 = new Pokemons("Psyduck","Pato","Humedad",19,8,"Amarillo","Mar");
            Pokemons miPokemon2 = new Pokemons("Meowth", "Gato", "Experto", 4, 4, "Gris", "Bosque");
            Pokemons miPokemon3 = new Pokemons("Gastly", "Bola", "Gas", 1, 3, "Marron", "Fango");
            Pokemons miPokemon4 = new Pokemons("Onix", "Serpiente", "Terremoto", 35, 3, "Gris", "Cuevas");
            Pokemons miPokemon5 = new Pokemons("Snorlax", "Oso", "Dormir", 40, 2, "Plomo", "Bosque");
            lstPokesRivales.Add(miPokemon1);
            lstPokesRivales.Add(miPokemon2);
            lstPokesRivales.Add(miPokemon3);
            lstPokesRivales.Add(miPokemon4);
            lstPokesRivales.Add(miPokemon5);

        }

        public void mostrarDatosPokemonRival(Pokemons poke)
        {
            txtNombreSist.Text = poke.Nombre.ToString();
            txtEspecieSist.Text = poke.Especie.ToString();
            txtHabilidadSist.Text = poke.Habilidad.ToString();
            txtPesoSist.Text = poke.Peso.ToString();
            txtAlturaSist.Text = poke.Altura.ToString();
            txtColorSist.Text = poke.Color.ToString();
            txtHabitadSist.Text = poke.Habitad.ToString();
              
        }

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
            crearPokemonesRivales();
        
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
            cboEntrenador.Items.Add("Erico");
            cboEntrenador.Items.Add("Petra");
            cboEntrenador.Items.Add("Candela");
           // cboEntrenador.Items.Add("Lt.Surge");
            cboEntrenador.SelectedIndex = 0;

            imgPokemonSist.ImageLocation = img_Pokemon + "/pokeball.png";

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

                //Elegir pokemon rival
                Pokemons pokeRival = obtenerPokemonRival();

                //Imprimir
                mostrarDatosPokemonRival(pokeRival);

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
            
            if (cboEntrenador.SelectedItem.ToString() == "Erico")
            {
                imgEntrenador.ImageLocation = img_Entrenador + "/erico.png";
                cboNombre.Items.Add("Squirtle");
            }

            else if (cboEntrenador.SelectedItem.ToString() == "Petra")
            {
                imgEntrenador.ImageLocation = img_Entrenador + "/petra.png";
                cboNombre.Items.Add("Bulbasaur");
            }
            else if (cboEntrenador.SelectedItem.ToString() == "Candela")
            {
                imgEntrenador.ImageLocation = img_Entrenador + "/candela.png";
                
                cboNombre.Items.Add("Charmander");
            }
            else if (cboEntrenador.SelectedIndex == 0)
            {
                imgEntrenador.ImageLocation = img_Pokemon + "/pokeball.png";
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

        private void rbM_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
