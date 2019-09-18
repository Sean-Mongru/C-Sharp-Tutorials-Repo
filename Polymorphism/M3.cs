using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class M3:BMW//This class inherits from a sub-class
    {
        //M3() { }
        public M3(string model, int HP, string Color) : base (model, HP, Color)
        {
            //this.Model = model;
        }

        public void Repair()
        {
            base.Repair();
        }
    }
}
