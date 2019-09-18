using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge
{
    class Trainee:Employee
    {
        private float workingHours;
        private float schoolHours;

        public Trainee(int workingHours, int schoolHours, string firstName, string lastName, int salary) : base(firstName, lastName, salary)
        {
            this.workingHours = workingHours;
            this.schoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I am learning for {0} hours!", schoolHours);
        }
        public void work()
        {
            Console.WriteLine("I am working for {0} hours!", workingHours);
        }
    }
}
