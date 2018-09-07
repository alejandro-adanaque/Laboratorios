using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Entrenador
    {
        private string nombres;
        private string apellidos;
        private string dni;

        public Entrenador(string nombres, string apellidos, string dni)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.dni = dni;
        }

        public void elegirPokemon()
        {

        }

        public void elegirAtaque()
        {

        }

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
    }
}
