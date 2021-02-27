using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Text.Json;
//using System.Text.Json.Serialization;
using System.Globalization;


namespace Ursu.Andrii._4J.ListaSemplice.Models
{
    class ListaSimple
    {
        const int MAX = 1000;
        Nodo[] array = new Nodo[MAX];
        List<string> listofdata = new List<string>();

        public ListaSimple()
        {
            using (var str = new StreamReader("listaCaratteri.json"))
            {
                
                while (!str.EndOfStream)
                {
                    listofdata.Add(str.ReadLine());
                }
                
            }
            //array= JsonConvert.D
            listofdata.ForEach(Console.WriteLine);
            Console.ReadLine();
                   

        }
        public void InserisciNodoInTesta()
        {
            listofdata.Insert(0,"k");
            listofdata.ForEach(Console.WriteLine);
            Console.ReadLine();

        }
        

        public void InserisciNodoInCoda()
        {
            listofdata.Insert(5, "k");
            listofdata.ForEach(Console.WriteLine);
            Console.ReadLine();
        }

        public void InserisciNodoNellaPosizione()
        {
            listofdata.Insert(3, "k");
            listofdata.ForEach(Console.WriteLine);
            Console.ReadLine();

        }
    }
}
