using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićObijektiIKlase
{
    class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov();

            x380.setDosegLeta(6000);
            x380.setNaziv("Airbus");
            x380.setSnagaMotora(2000);

            Console.WriteLine("Naziv:" + x380.getNaziv() + "\nSnaga:" + x380.getSnagaMotora() + "\nDoseg leta:" + x380.getDosegLeta() + "km");

            Zrakoplov PU123RO = new Zrakoplov("Cessna", 350, 125);

            Console.WriteLine(PU123RO.ToString());

            Zrakoplov x328 = new Zrakoplov();
            Console.WriteLine("Unesite doseg leta");
           
            x328.setDosegLeta(Convert.ToInt32(Console.ReadLine()));
            x328.setNaziv("MeanMachine");
            x328.setSnagaMotora(5000);

            Console.WriteLine("Naziv:" + x328.getNaziv() + "\nSnaga:" + x328.getSnagaMotora() + "\nDoseg leta:" + x328.getDosegLeta() + "km");

            Console.ReadKey();
        } 
    }
}
