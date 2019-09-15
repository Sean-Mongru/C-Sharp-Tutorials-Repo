using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    class Box
    {
        private int length;
        public int Length
        {
            get => length;
            set => length = value;
            
        }
        private int height;
        public int Height
        {
            set
            {
                height = value;
            }
            get
            {
                return height;
            }
        }
        private int width;
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        private int volume;

        public int Volume {
            get
            {
                return length * width * height;
            }
        }

        public void displayInfo()
        {
            Console.WriteLine("Length: {0}, Height: {1}, Width: {2}, Volume: {3}", length, height, width, volume = length * height * width);
        }
    }
}
