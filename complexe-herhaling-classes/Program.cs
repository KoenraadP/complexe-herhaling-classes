using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexe_herhaling_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // auto aanmaken op basis van class
            Car car1 = new Car
            {
                Model = "M3",
            };

            // eigenschap Brand invullen
            car1.Brand = "BMW";

            // tweede auto zonder ingevulde properties
            Car car2 = new Car();

            // derde auto maken met constructor
            Car car3 = new Car("Audi", "A4", 2019);

            // waarde van Brand tonen
            Console.WriteLine(car1.Brand);
            // waarde van Model tonen
            Console.WriteLine(car1.Model);
            // merk en model van auto tonen door gewoon het car object op te vragen
            Console.WriteLine(car1);
        }
    }
}
