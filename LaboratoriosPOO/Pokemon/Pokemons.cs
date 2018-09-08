using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Pokemons
    {
        private string nombre;
        private string especie;
        private string habilidad;
        private double peso;
        private double altura;
        private string color;
        private string habitad;

        public Pokemons(string nombre, string especie, string habilidad, double peso, double altura, string color, string habitad)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.habilidad = habilidad;
            this.peso = peso;
            this.altura = altura;
            this.color = color;
            this.habitad = habitad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Habilidad { get => habilidad; set => habilidad = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
        public string Color { get => color; set => color = value; }
        public string Habitad { get => habitad; set => habitad = value; }

        public void saltar()
        {

        }

        public void atacar()
        {

        }

        public void evolucionar()
        {

        }

        
    }
}
