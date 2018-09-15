using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09HerenciaMultiple
{
    public class Trabajador :Persona
    {
        public void trabajar()
        {

        }
        
        public double obtenerSalario(double horaXsemanal)
        {
            return (horaXsemanal*50)*4;
        }

        
    }
}
