using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading from a file


            //string text = System.IO.File.ReadAllText(@"C:\Users\SeanM\Source\Repos\C-Sharp\Sean-C-Sharp-Repo\Text_Files\text_prog_test.txt");

            //Console.WriteLine("Textfile Contain the following text: {0}", text);

            //string[] Lines = System.IO.File.ReadAllLines(@"C:\Users\SeanM\Source\Repos\C-Sharp\Sean-C-Sharp-Repo\Text_Files\text_prog_test.txt");
            //Console.WriteLine("Contents of Text file are: ");
            //foreach(string line in Lines)
            //{
            //    Console.WriteLine("\t" + line);
            //}

            ////Method 2: Writing to a file
            string[] Lines = { "First Line", "Second Line", "Third Line" };

            //File.WriteAllLines(@"C:\Users\SeanM\Source\Repos\C-Sharp\Sean-C-Sharp-Repo\Text_Files\text_prog_test.txt", Lines);

            //Console.WriteLine("What is the file name?");
            //string fileName = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("What file contents??");
            //string contents = Console.ReadLine();

            //Method 3:
            using (StreamWriter file = new StreamWriter(@"C:\Users\SeanM\Source\Repos\C-Sharp\Sean-C-Sharp-Repo\Text_Files\text_prog_test.txt"))
            {
                foreach (string line in Lines)
                {
                    if (line.Contains("First"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            using (StreamWriter file = new StreamWriter(@"C:\Users\SeanM\Source\Repos\C-Sharp\Sean-C-Sharp-Repo\Text_Files\text_prog_test.txt", true))
            {
                file.WriteLine("Additional Line");
            }

            Console.ReadKey();
        }
    }
}
