using System;

namespace Uppgift5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Skriv in ett namn");
                namn[i] = Console.ReadLine();
            }
            for (int i = 0;i < 5;i++)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}