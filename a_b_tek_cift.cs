using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Başlangıç Değeri: ");
            a = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Bitiş Değeri: ");
            b = int.Parse(Console.ReadLine());

            for(int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i + " ÇİFTTİR");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i + " TEKTİR");

                }
            }
        }
    }
}
