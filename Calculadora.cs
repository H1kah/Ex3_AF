using System;
using System.Globalization;

namespace Course;

class Program {
    static void Main(string[] args) {
        char op;
        float a, b;

        Console.Write("Entre com o operador +, -, *, /: ");
        op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Entre com dois valores: ");
        string[] values = Console.ReadLine().Split(' ');
        a = float.Parse(values[0]);
        b = float.Parse(values[1]);

        switch (op) {
            case '+':
                Console.WriteLine($"{a} + {b} = {a + b}");
                break;
            case '-':
                Console.WriteLine($"{a} - {b} = {a - b}");
                break;
            case '*':
                Console.WriteLine($"{a} * {b} = {a * b}");
                break;
            case '/':
                Console.WriteLine($"{a} / {b} = {a / b}");
                break;
            default:
                Console.WriteLine("Operador errado, por favor insira o operador correto");
                break;
        }
    }
}