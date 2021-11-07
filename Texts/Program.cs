using System;

namespace Texts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
            Console.WriteLine("enter firtst text");
            string a = Console.ReadLine();

            Console.WriteLine("second firtst text");
            string b = Console.ReadLine();

            int c = a.Length + b.Length;

            Console.WriteLine("LENGTH first text " + a.Length + "\n LENGTH Second text " + b.Length + "\n LENGTH text toegetor " + c);
            */

            Console.WriteLine("enter first name");

            string firstName = Console.ReadLine();
            string first = firstName.Substring(0, 2);

            Console.WriteLine("enter first name");
            string LastName = Console.ReadLine();
            string Last = LastName.Substring(0, 2);

            Console.WriteLine(first + Last);

        }
    }
}
