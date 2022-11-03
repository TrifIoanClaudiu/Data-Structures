using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{

    // The Audi is a Car
    class Audi : Car
    {
        public Audi(int hP, string color, string model) : base(hP, color)
        {
            Model = model;

        }

        public string Model { get; set; }
        private string Brand = "Audi";


        public void ShowDetails()
        {
            Console.WriteLine("Brand " + Brand + " HP: " + HP + "color: " + Color);
        }
        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired", Model);
        }
    }
}
