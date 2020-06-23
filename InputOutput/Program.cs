using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = "What is your name";
            string name;
            string greeting = "Hiya";

            Console.WriteLine(prompt);
            name = Console.ReadLine();
            Console.WriteLine(greeting + " " + name);

        }
    }
}
