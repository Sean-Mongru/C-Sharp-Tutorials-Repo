using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to worker system #9000!");
            Employee Sean = new Employee("Mongru", "Sean", 25000);
            Sean.work();
            Sean.pause();

            Boss chuckNorris = new Boss("Lambo", "Chuck", "Norris", 999999);
            chuckNorris.Lead();

            Trainee emma = new Trainee(16, 40, "Emma", "Watson", 4000);
            emma.Learn();
            emma.work();


            Console.ReadLine();
            Console.Read();

        }
    }
}
