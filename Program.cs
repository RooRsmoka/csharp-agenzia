using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Villa v = new Villa("V003", "Via Italia, 22", "00842", "Milano", 350, 6, 3, 200);
            Villa v1 = new Villa("A005", "Via Italia, 1", "00231", "Firenze", 400, 5, 2, 250);
            Appartamento app = new Appartamento("A008", "Via Roma, 44", "00231", "Torino", 110, 4, 2);
            Appartamento app1 = new Appartamento("V009", "Via Dante 13", "00892", "Genova", 136, 4, 2);

            Agenzia az = new Agenzia("Caveira Immobiliare srl");
            az.AggiungiImmobile(v);
            az.AggiungiImmobile(v1);
            az.AggiungiImmobile(app);
            az.AggiungiImmobile(app1);

            List<Immobile> results = az.CercaImmobili("");

            foreach (Immobile i in results)
            {
                Console.WriteLine(i.ToString());
                Console.WriteLine("-----------------------------");    
            }
            Console.WriteLine("OK, ho finito!");
        }
    }
}