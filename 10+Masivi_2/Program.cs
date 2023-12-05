using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_Masivi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndchar = rnd.Next();
            char [] mas = new char[20];

            for (int i = 0; i < mas.Length; i++) 
            {
                mas[i] = (char)rnd.Next(65, 150);
                Console.WriteLine($"mas[{i + 1}] = {mas[i]} ");

            }
            Console.WriteLine("Ievadiet simbolu: ");
            char searchChar = Convert.ToChar(Console.ReadLine());  
            int count = 0;


            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == searchChar)
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Simbols '{searchChar}' atrodas masīvā {count} reizes.");
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] != searchChar)
                {
                    Console.WriteLine($"mas[{i + 1}] = {mas[i]} ");
                }
            }
        }
    }
}
