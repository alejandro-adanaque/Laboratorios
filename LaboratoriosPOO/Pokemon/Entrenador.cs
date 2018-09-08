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
        private string genero;
        private string edad;

        public string Nombres { get => nombres; set => nombres = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Edad { get => edad; set => edad = value; }

        public Entrenador(string nombres, string genero, string edad)
        {
            this.nombres = nombres;
            this.genero = genero;
            this.edad = edad;
        }

        public void elegirPokemon()
        {

        }

        public void elegirAtaque()
        {

        }

        
    }
}
