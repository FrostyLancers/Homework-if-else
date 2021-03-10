using System;

namespace Homework__if_else_06._03._21
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            double mousex = double.Parse(Console.ReadLine());
            double mousey = double.Parse(Console.ReadLine());

            if (mode == "time" && mousex >= 0)
            {
                mousey = Math.Pow((mousex - 1), 2);
                Console.WriteLine("{0}, {1}", mousex, mousey);
            }

            else if (mode == "price" && mousex >= 0)
            {
                mousex = Math.Sqrt(mousey) + 1;
                Console.WriteLine("{0}, {1}", mousex, mousey);
            }

            else
            {
                if (mousex < 0)
                {
                    Console.WriteLine("Invalid Mouse Position.");
                }
                else
                {
                    Console.WriteLine("Invalid Mode.");
                }
            }
        }
    }
}
