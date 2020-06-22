using System;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interview Time");
            Console.WriteLine();
            
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            Console.Write("What is your Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("What is your favorite color: ");
            string color = Console.ReadLine();

            ConsoleColor bgColor = (ConsoleColor) Enum.Parse(typeof(ConsoleColor), color);
            Console.BackgroundColor = bgColor;
            Console.Clear();

            Console.WriteLine("Hello, " + name);

            if(age >= 21)
            {
                Console.WriteLine("You can have a beer tonight if you want");
            } else
            {
                Console.WriteLine("Have a rootbeer, kiddo!");
            }

        }
    }
}
