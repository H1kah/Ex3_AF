using System;
using System.Globalization;
//como todo código, todo o arquivo precisa de uma biblioteca para que cada code seja compreendido, já que, sem eles, será apenas palavras sem signigicado nenhum.
namespace Course;
//é um recurso que ajuda a organizar e evitar conflitos de nomes em um código
class Program {
//para começar é necessário criar uma clase, no caso, está criando uma no public para que possa ser mencionada em outras partes do code.
    static void Main(string[] args) {
//Não é mais int main, e sim, void main. Nessa parte, está criando outro public, citando o peso do comando(string), etc.
        int num;
//Aqui está criando uma variável para que possa ser substituída por outro valor.
        Console.Write("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());
//Console.Write é a mensagem que vai aparecer e o num=int.Parse é o que fará a variável ser associada com o qeu for digitar.
        Console.Write("Os primeiros " + num + " números pares são: ");
        for (int i = 2; i <= num * 2; i += 2) {
//O for é para mais um loop. Ele só irá parar quando o que for pedido for igual ou menor.
            Console.Write(i + " ");
//por fim, a resposta de tudo.
        }

        Console.WriteLine();
    }
}
