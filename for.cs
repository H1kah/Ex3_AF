using System;
using System.Globalization;

namespace Course;

class Program {
    static void Main(string[] args) {
        int num;

        Console.Write("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());

        Console.Write("Os primeiros " + num + " números pares são: ");
        for (int i = 2; i <= num * 2; i += 2) {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}