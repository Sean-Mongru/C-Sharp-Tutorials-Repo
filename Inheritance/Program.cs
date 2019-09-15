using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the Birthday Wishes", true, "Sean Mongru");
            Console.WriteLine(post1.ToString());
            ImagePost post2 = new ImagePost("Check out my new shoes", "Sean Rajeev Mongru",
                "http://newshoes.com/shoes", true);
            Console.WriteLine(post2.ToString());

            VideoPost post3 = new VideoPost("New shoes, very kool, 10/10", "rDarky7",
                "http://newshoes.com/shoes/bestshoesvid", 180, true);
            Console.WriteLine(post3.ToString());

            post3.Play();
            Console.WriteLine("Press any key to stop video");
            Console.Read();
            post3.Stop();

            Console.ReadLine();
}
    }
}
