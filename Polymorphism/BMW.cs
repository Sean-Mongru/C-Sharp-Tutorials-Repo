using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class BMW : car
    {
        private string Brand = "M3";
        private string Model { set; get; }

        public BMW() { }
        public BMW(string model, int HP, string Color) : base(HP, Color)
        {
            this.Model = model;
        }
            public new void ShowDetails()//The "new" identifier makes it such that a method in the main class does not need to be 
                                         //overrided in order to be written over
        {
            Console.WriteLine("Model: {2}, Car HP: {0}, Car Color{1}", HP, Color, Model);
        }
        public override void Repair()
        {
            Console.WriteLine("{0} {1} was repaired!", Brand, Model);
        }
    }
}
