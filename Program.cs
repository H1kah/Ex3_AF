using System;
using System.Globalization;
//como todo código, todo o arquivo precisa de uma biblioteca para que cada code seja compreendido, já que, sem eles, será apenas palavras sem signigicado nenhum.
namespace Course
//é um recurso que ajuda a organizar e evitar conflitos de nomes em um código
{
    public class Program
//para começar é necessário criar uma classe, no caso, está criando uma no public para que possa ser mencionada em outras partes do code.
    {
        public static void Main(string[] args)
//Não é mais int main, e sim, void main. Nessa parte, está criando outro public, citando o peso do comando(string), etc.
        {

            int num;
//aqui está só criando a variante. A partir dela que o comando e as respostas geradas irão seguir.

            do
//o "do" acompanha o while que está à seguir. Desta forma, o programa consegue fazer um loop.
            {
                Console.Write("Digite um número entre 1 e 10: ");
//O console.write é o código que fará a mensagem aparecer na tela.
                num = int.Parse(Console.ReadLine());
//a variante é citada. Logo, o que fará com que qualquer reposta à seguir se associe à ela.
            } while (num < 1 || num > 10);
//o while é para casos onde o código dá certo. Ou seja, se o requisitado foi feito, o código segue em frente
            Console.WriteLine("Você digitou o número " + num + ".");
//o código da mensagem na tela. No caso, a resposta aparecerá na variável num, já que tudo que foi pedido antes foi completo.
        }
    }
}
