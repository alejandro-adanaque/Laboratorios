using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09HerenciaMultiple
{
    public class Persona
    {
        private string nombres;
        private string apellidos;
        private string dni;

        public Persona(string nombres, string apellidos, string dni)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.dni = dni;
        }

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        
        public Persona()
        {

        }
    }

}
