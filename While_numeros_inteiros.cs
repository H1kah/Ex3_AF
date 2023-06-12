using System;
using System.Globalization;

username Course;

class Program
{
     public static void Main(string[] args)
    {
        int num, i = 1;

        Console.Write("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());

        while (i <= num)
        {
            Console.Write(i + " ");
            i++;
        }

        Console.WriteLine();
    }
}