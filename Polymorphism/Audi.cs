using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Audi:car
    {
        private string Brand = "Audi";
        private string Model { set; get; }

        public Audi() { }
        public Audi(string model, int HP, string Color) : base(HP, Color)
        {
            this.Model = model;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Model: , Car HP: {0}, Car Color{1}", HP, Color, Model);
        }
        public override void Repair()//The override is important!!!!!!!
        {
            Console.WriteLine("{0} {1} was repaired!", Brand, Model);
        }
    }
}
