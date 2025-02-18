using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexe_herhaling_classes
{
    internal class Car
    {
        // properties / eigenschappen van een auto
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsElectric { get; set; }
        public decimal Price { get; set; }
        public int AmountOfDoors { get; set; }
        public Color Color { get; set; }

        // een constructor maken om te zorgen
        // dat bepaalde eigenschappen MOETEN ingevuld
        // worden bij het aanmaken van een auto
        // parameters met KLEINE letter starten
        public Car(string brand, string model, 
            int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        // constructor zonder parameters
        // dit laat dan toch nog toe 
        // om een auto aan te maken zonder ingevulde properties
        public Car()
        {
            
        }

        // override voor ToString zorgt dat bij
        // het oproepen van de 'volledige' car in string formaat
        // deze informatie getoond wordt
        public override string ToString()
        {
            return Brand + " " + Model;
        }
    }
}
