using System;

namespace homework1
{
    internal class Program
    {
        static void Main()




        {
            #region Task1

            Console.WriteLine("chawere ricxvi");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 5 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


            #endregion
            Console.Write("\n");
            #region Task2

            int number2 = 16;
            int number3 = 0;

            Console.WriteLine($"{number2} + {number3} = {number2 + number3}");

            if (number2 > number3)
            {
                Console.WriteLine($"{number2} - {number3} = {number2 - number3}");
            }
            else
            {
                Console.WriteLine($" {number3} - {number2} - {number3 - number2}");
            }

            Console.WriteLine($"{number2} * {number3} = {number2 * number3}");

            if (number2 == 0 || number3 == 0)
            {
                Console.WriteLine("Not Allowed To Divide By Zero");

            }
            else if (number2 > number3)
            {
                Console.WriteLine($"{number2} / {number3} = {number2 / number3}");

            }
            else
            {
                Console.WriteLine($"{number3} / {number2} = {number3 / number2}");
            }
                #endregion 
            Console.Write("\n");

            #region Task3

            int x = 12;
            int y = 19;
            Console.WriteLine($"x = {x}, y = {y}");

            int z = x;
            x = y;
            y = z;

            Console.WriteLine($"x = {x}, y = {y}");

















            #endregion








        }
    }
}


