using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ursu.Andrii._4J.ListaSemplice.Models;

namespace Ursu.Andrii._4J.ListaSemplice
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaSimple lista = new ListaSimple();
            lista.InserisciNodoInTesta();
            lista.InserisciNodoInCoda();
            lista.InserisciNodoNellaPosizione();



        }
    }
}
