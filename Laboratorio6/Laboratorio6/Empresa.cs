using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    [Serializable]
    class Empresa
    {
        private string nombre;
        private string rutEmpresa;

        List<Division> divisiones = new List<Division>();

        public Empresa(string nombre, string rutEmpresa, List<Division> divisiones)
        {
            this.nombre = nombre;
            this.rutEmpresa = rutEmpresa;
            this.divisiones = divisiones;
        }

      
    }
}
