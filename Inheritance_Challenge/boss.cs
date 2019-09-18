using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheritance_Challenge
{
    class Boss:Employee
    {
        private string companyCar { set; get; }

        public Boss(string companyCar, string firstName, string lastName, int salary): base(firstName, lastName, salary)
        {
            this.companyCar = companyCar;
        }


        public void Lead()
        {
            Console.WriteLine("Boss is currently leading!");
        }

    }
}
