using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    [Serializable]
    class Persona
    {
        private string nombre;
        private string apellido;
        private string cargo;
        private int edad;

        public Persona(string nombre, string apellido, int edad, string cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.cargo = cargo;
        }
    }
}
