using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class car
    {
        public int HP { set; get; }
        public string Color { set; get; }
        public car() { }

        //Has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();
        public void SetCarIdInfo(int iDNum, string owner)
        {
            carIDInfo.IDNum = iDNum;
            carIDInfo.Owner = owner;
        }
        public void GetCarIdInfo()
        {
            Console.WriteLine("Car ID: {0}, Car Owner: {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }


        public car(int HP, string Color)
        {
            this.HP = HP;
            this.Color = Color;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Car HP: {0}, Car Color{1}", HP, Color);
        }
        public virtual void Repair()//In order to override a method in a sub-class, the method must first be virtual.
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
