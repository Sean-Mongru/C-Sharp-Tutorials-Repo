using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.Width = 4;
            box.Length = 5;
            box.Height = 3;
            Console.WriteLine(box.Volume);
            box.displayInfo();

            Console.Read();
        }
    }
}
