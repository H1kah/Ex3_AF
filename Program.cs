using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int num;

            do
            {
                Console.Write("Digite um número entre 1 e 10: ");
                num = int.Parse(Console.ReadLine());
            } while (num < 1 || num > 10);
            Console.WriteLine("Você digitou o número " + num + ".");

        }
    }
}