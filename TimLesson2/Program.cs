using System;

namespace TimLesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Nice to meet you, " + name);

            Console.WriteLine("My name is Jane. I'm here to help you choose the most beautiful flowers");

            string f1 = "roses";
            string f2 = "tulips";
            string f3 = "gladiolus";
            string f4 = "chrysanthemums";
            string f5 = "asters";

            Console.WriteLine("What flowers do you prefer? We have " + $"{f1}, {f2}, {f3}, {f4} and {f5}");

            string choice = Console.ReadLine();

            Console.WriteLine("Good choice!");

            string c1 = "red";
            string c2 = "yellow";
            string c3 = "pink";

            Console.WriteLine("What color do you like?" + $" You can choose {c1}, {c2} or {c3}");

            string color = Console.ReadLine();

            Console.WriteLine("Nice color! How many flowers do you want?");

            string quantity = Console.ReadLine();

            int q = Convert.ToInt32(quantity);

            if (q <= 7)
            {
                Console.WriteLine("It will cost you 25 UAH per piece");
            }

             else if (q > 7)
            {
                Console.WriteLine("It will cost you 23 UAH per piece");
            }

            Console.ReadLine();

            Console.WriteLine("Thanks for buying, have a nice day!");
        }
    }
}
