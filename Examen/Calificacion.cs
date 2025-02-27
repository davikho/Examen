using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Calificacion : IInterfaceEQ 
    {
        public string Equival(double a) {


            if (a < 0 || a > 10)
            {
                return "Error: las notas deben estar entre 0 y 10";
            }
            else if (a < 5)
            {
                return "SS"; // Suspenso
            }
            else if (a >= 5 && a < 7) // Se cambia `||` por `&&`
            {
                return "AP"; // Aprobado
            }
            else if (a >= 7 && a < 9) // Se cambia `||` por `&&`
            {
                return "NT"; // Notable
            }
            else // Si `a` está entre 9 y 10
            {
                return "SB"; // Sobresaliente
            }


        }
    }
}
