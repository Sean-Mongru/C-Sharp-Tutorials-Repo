using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheritance_Challenge
{
    class Employee
    {
        private string lastName { get; set; }
        private string firstName { get; set; }
        private int salary { get; set; }
        Timer timer;

        protected int currentWorkTime;
        protected bool isWorking = false;

        Employee() { }//Empty constructor

        public Employee(string lastName, string firstName, int salary)//Public constructor for setting values
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.salary = salary;
        }

        public void work()
        {
            if (!isWorking)
            {
                isWorking = true;
                Console.WriteLine("{0} {1} is working", firstName, lastName);
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)//Always remember a timer needs a timercallback
        {
            {
                if (isWorking)
                {
                    currentWorkTime++;
                    Console.WriteLine("{0} {1} is working for {2} seconds..", firstName, lastName, currentWorkTime);
                    GC.Collect();
                }
            }
        }


        public void pause()
        {
            if (isWorking && currentWorkTime >= 8)
            {
                Console.WriteLine("{0} {1} has worked for {2} hours!", firstName, lastName, currentWorkTime);
                currentWorkTime = 0;
                timer.Dispose();
            }
        }
    }
}
