using System;

namespace trainingarc
{
    class Program
    {
        static void Main(string[] args)
        {
            // ex 1.V of rectangular parallelepiped.
            int L;//Big lenght
            int l;//small lenght
            int h;// height
            Console.WriteLine("Introduceti lungimea mare :");
            L = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti lungimea mica :");
            l = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti naltimea :");
            h = int.Parse(Console.ReadLine());         



             int Volume = L * l * h;
            Console.WriteLine("Volumul paralelipipedului este:  " + Volume);

        }
    }
}
