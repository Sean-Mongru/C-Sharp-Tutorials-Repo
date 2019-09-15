using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {

        static void Main(string[] args)
        {

            void displayTTT(string[,] array2Dz)
            {
                Console.WriteLine("  |_C1_|__C2_|__C3_");
                Console.WriteLine("R1|_{0}__|__{1}__|__{2}__", array2Dz[0, 0], array2Dz[0, 1], array2Dz[0, 2]);
                Console.WriteLine("R2|_{0}__|__{1}__|__{2}__", array2Dz[1, 0], array2Dz[1, 1], array2Dz[1, 2]);
                Console.WriteLine("R3|_{0}__|__{1}__|__{2}__", array2Dz[2, 0], array2Dz[2, 1], array2Dz[2, 2]);
            }
            void queryAndChange(string[,] array2Dz, string str)
            {
                int row;
                int col;
                querystart:  Console.WriteLine("What row will you choose? Player {0}", str);
                bool success1 = int.TryParse(Console.ReadLine(), out int row1);
                if (success1 && row1 > 0 && row1 < 4)
                {
                    row = row1;
                }
                else
                {
                    Console.WriteLine("Input if out of the Row/Cols --> Re-input!");
                    goto querystart;
                }

                Console.WriteLine("What column will you choose? Player {0}", str);
                bool success2 = int.TryParse(Console.ReadLine(), out int col1);
                if (success1 && col1 > 0 && col1 < 4)
                {
                    col = col1;
                }
                else
                {
                    Console.WriteLine("Input if out of the Row/Cols --> Re-input!");
                    goto querystart;
                }


                if (array2Dz[row - 1, col - 1] != "X" && array2Dz[row - 1, col - 1] != "0")
                {
                    array2Dz[row - 1, col - 1] = str;
                }
                else
                {
                    Console.WriteLine("Slot taken, pick again!");
                    goto querystart;

                }
                Console.Clear();
                displayTTT(array2Dz);
            }

            string winner(string[,] array2Dz)
            {
                string str = "Default";
                if((array2Dz[0,0]).Equals(array2Dz[0, 1]))
                    {
                    if ((array2Dz[0, 1]).Equals(array2Dz[0, 2]))
                        {
                        str = (array2Dz[0, 0]);
                        }
                    }
                else if ((array2Dz[1, 0]).Equals(array2Dz[1, 1]))
                {
                    if ((array2Dz[1, 1]).Equals(array2Dz[1, 2]))
                    {
                        str = (array2Dz[1, 0]);
                    }
                }
                else if ((array2Dz[2, 0]).Equals(array2Dz[2, 1]))
                {
                    if ((array2Dz[2, 1]).Equals(array2Dz[2, 2]))
                    {
                        str = (array2Dz[2, 0]);
                    }
                }
                else if ((array2Dz[0, 0]).Equals(array2Dz[1, 0]))
                {
                    if ((array2Dz[1, 0]).Equals(array2Dz[2, 0]))
                    {
                        str = (array2Dz[0, 0]);
                    }
                }
                else if ((array2Dz[0, 1]).Equals(array2Dz[1, 1]))
                {
                    if ((array2Dz[1, 1]).Equals(array2Dz[1, 2]))
                    {
                        str = (array2Dz[0, 1]);
                    }
                }
                else if ((array2Dz[0, 2]).Equals(array2Dz[2, 1]))
                {
                    if ((array2Dz[2, 1]).Equals(array2Dz[2, 2]))
                    {
                        str = (array2Dz[0, 2]);
                    }
                }
                else if ((array2Dz[0, 0]).Equals(array2Dz[1, 1]))
                {
                    if ((array2Dz[1, 1]).Equals(array2Dz[2, 2]))
                    {
                        str = (array2Dz[0, 0]);
                    }
                }
                else if ((array2Dz[2, 0]).Equals(array2Dz[1, 1]))
                {
                    if ((array2Dz[1, 1]).Equals(array2Dz[0, 2]))
                    {
                        str = (array2Dz[2, 0]);
                    }
                }

                string win = str;
                return win;
            }

            void runGame(string[,] array2Dz)
            {
                string test;
                queryAndChange(array2Dz, "X");
                test = winner(array2Dz);
                if (!test.Equals("Default")) goto winner;
                queryAndChange(array2Dz, "0");
                test = winner(array2Dz);
                if (!test.Equals("Default")) goto winner;
                queryAndChange(array2Dz, "X");
                test = winner(array2Dz);
                if (!test.Equals("Default")) goto winner;
                queryAndChange(array2Dz, "0");
                test = winner(array2Dz);
                if (!test.Equals("Default")) goto winner;
                queryAndChange(array2Dz, "X");
                test = winner(array2Dz);
                if (!test.Equals("Default")) goto winner;
                queryAndChange(array2Dz, "0");
                test = winner(array2Dz);
                if (!test.Equals("Default")) goto winner;
                queryAndChange(array2Dz, "X");
                test = winner(array2Dz);
                if (!test.Equals("Default")) goto winner;
                queryAndChange(array2Dz, "0");
                test = winner(array2Dz);
                if (!test.Equals("Default")) goto winner;
                queryAndChange(array2Dz, "X");
                test = winner(array2Dz);
                if (!test.Equals("Default")) goto winner;


                winner:  Console.WriteLine("The winner is: Player {0} !", test);
                
                Console.WriteLine(test);
            }
            string[,] newArray()
            {
                string[,] array2Dz = new string[,]
                {
                    {"1", "2", "3" },
                    {"4", "5", "6" },
                    {"7", "8", "9" }
                    //__X__|__X__|__X__
                };
                return array2Dz;
            }
            start:  string[,] array2D = newArray();
            displayTTT(array2D);
            runGame(array2D);
            prompt:  Console.WriteLine("Another Game? Type 'Y' for yes or 'N' for no~");
            string response = Console.ReadLine();
            if (response == "Y")
            {
                Console.Clear();
                goto start;
            }
            else if (response == "N")
            {
                Console.WriteLine("Thank you for playing!"); 
                goto end;
            }
            else
            {
                Console.WriteLine("Unrecognised input");
                goto prompt;
            }
            end: Console.WriteLine("ending now~");




            Console.Read();
        }


    }
}
