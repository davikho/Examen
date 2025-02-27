using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Informacion
    {
        public string nombre;
        public string apellidos;
        public int dni;
        public float nota;

        public Informacion(int dni, string apellidos, string nombre,   float nota)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nota = nota;
            this.dni = dni;
        }
    }
}
