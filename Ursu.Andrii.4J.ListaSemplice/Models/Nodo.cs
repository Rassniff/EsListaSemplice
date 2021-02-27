using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ursu.Andrii._4J.ListaSemplice.Models
{
    class Nodo
    {
        public char _dato;
        public int _indirizzo;

        public Nodo(char Dato, int Indirizzo)
        {
            _dato = Dato;
            _indirizzo = Indirizzo;
        }
    }
}
