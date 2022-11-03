using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    // The BMW is a Car
    class BMW : Car
    {
        public BMW() { }
        public BMW(int hP, string color, string model) : base(hP, color)
        {
            Model = model;

        }

        public string Model { get; set; }
        private string Brand = "BMW";


        public new void ShowDetails()
        {
            Console.WriteLine("Brand " + Brand + " HP: " + HP + " color: " + Color);
        }
        public sealed override void Repair()
        {
            Console.WriteLine( "The BMW {0} was repaired", Model);
        }
    }
}
