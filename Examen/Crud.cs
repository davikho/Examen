using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Crud
    {
        private List<Informacion> listaInformacion = new List<Informacion>();
        
        public void agregarObjeto(Informacion i)
        {
            listaInformacion.Add(i);
        }
        public List<Informacion> ObtenerLista()
        {
            return listaInformacion;
        }

    }
}
