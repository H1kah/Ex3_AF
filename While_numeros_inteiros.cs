using System;
using System.Globalization;
//como todo código, todo o arquivo precisa de uma biblioteca para que cada code seja compreendido, já que, sem eles, será apenas palavras sem signigicado nenhum.
username Course
//é um recurso que ajuda a organizar e evitar conflitos de nomes em um código
class Program
//para começar é necessário criar uma classe, no caso, está criando uma no public para que possa ser mencionada em outras partes do code.
{
     public static void Main(string[] args)
//Não é mais int main, e sim, void main. Nessa parte, está criando outro public, citando o peso do comando(string), etc.
    {
        int num, i = 1;
//aqui está criando a variável num para que possa ser substituída, enquanto i já recebe um valor.

        Console.Write("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());
//O console.write é o mesmo que o cout. Servem para mandar mensagens para a tela. No caso da  linha logo abaixo, seria o cin, feito para associar a variável com o que for digitado.
        while (i <= num)
//aqui o loop acontecerá, será adicionado o número 1 do 0 até o número positivo digitado.
        {
            Console.Write(i + " ");
//a resposta que aparecerá na tela, sendo justamente números do 0 até o que foi digitado.
            i++;
        }
    }
}
