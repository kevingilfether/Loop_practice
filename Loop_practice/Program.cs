using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's do some loop practice

            //while loops perform actions as long as the loop is true

            //makes a loop that prints 1-10 on new lines
            //int x = 1;
            //while (x <= 10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            //makes a while loop where each digit from 1-10 is printed on each line
            //with an indent corresponding to position

            //int x = 1;
            //string numTabs = "\t";
            //while(x <= 10)
            //{
            //    if (x == 1)
            //    {
            //        Console.WriteLine("\t" + x);
            //    }

            //    else if (x == 2)
            //    {
            //        Console.WriteLine("\t\t" + x);
            //    }

            //    else if (x == 3)
            //    {
            //        Console.WriteLine("\t\t\t" + x);
            //    }

            //    else if (x == 4)
            //    {
            //        Console.WriteLine("\t\t\t\t" + x);
            //    }

            //    else if (x == 5)
            //    {
            //        Console.WriteLine("\t\t\t\t\t" + x);
            //    }

            //    else if (x == 6)
            //    {
            //        Console.WriteLine("\t\t\t\t\t\t" + x);
            //    }

            //    else if (x == 7)
            //    {
            //        Console.WriteLine("\t\t\t\t\t\t\t" + x);
            //    }

            //    else if (x == 8)
            //    {
            //        Console.WriteLine("\t\t\t\t\t\t\t\t" + x);
            //    }

            //    else if (x == 9)
            //    {
            //        Console.WriteLine("\t\t\t\t\t\t\t\t\t" + x);
            //    }

            //    else if (x == 10)
            //    {
            //        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t" + x);
            //    }
            //    x++;
            //}

            //Writes out 1 - 10 with a for loop
            //for (int x =1; x <= 10; x ++)
            //{
            //    Console.WriteLine(x);
            //}


            // Writes out five lines of 10 *

            //for (int row = 0; row < 5; row ++)
            //{
            //    for (int column = 0; column < 10; column ++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            // Writes out one *, then two, then three, etc.
            // Each on own lines.

            //for (int row = 0; row < 10; row++)
            //{
            //    for (int column = 0; column < row + 1; column ++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            // Makes pyramid of *

            for (int row = 0; row < 5; row++) 
            {
                for (int space = 0; space < 5 - row - 1; space++)
                {
                    Console.Write(" ");
                }

                for (int star = 0; star < (row * 2) + 1; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}
