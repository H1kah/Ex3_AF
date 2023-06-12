using System;
using System.Globalization;
//como todo código, todo o arquivo precisa de uma biblioteca para que cada code seja compreendido, já que, sem eles, será apenas palavras sem signigicado nenhum.
namespace Course;
//é um recurso que ajuda a organizar e evitar conflitos de nomes em um código
class Program {
//para começar é necessário criar uma clase, no caso, está criando uma no public para que possa ser mencionada em outras partes do code.
    static void Main(string[] args) {
//Não é mais int main, e sim, void main. Nessa parte, está criando outro public, citando o peso do comando(string), etc.
        char op;
        float a, b;
        //aqui está citando as variáveis. O char e float seriam para variáveis que são letras, diferente de outros que são números

        Console.Write("Entre com o operador +, -, *, /: ");
//para que resposda é necessário a pergunta. No caso, o Console.Write é o qeu aparecerá na tela
        op = char.Parse(Console.ReadLine());
//aqui o op é citado para que possa ser associado com qualquer resposta à seguir.
        Console.Write("Entre com dois valores: ");
//aqui é outra mensagem que aparecerá na tela, pedindo os valores desejados para fazer o cálculo
        string[] values = Console.ReadLine().Split(' ');                                                            
        a = float.Parse(values[0]);
        b = float.Parse(values[1]);

        switch (op) {
 //feito para mudar de acordo com o que for colocado. Neste caso, a variação é o sinal da conta.
            case '+':
//caso for +, a conta irá somar. Será assim com todos os cases.
                Console.WriteLine($"{a} + {b} = {a + b}");
//aqui cada variável entre as chaves irá ser substituída de acordo com os valores que foram colocados antes. Isso acontecerá com todas abaixo
                break;
//break finaliza. Não rodará mais nada associado com este code.

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
//caso dê algum problema, algo com valor ou coisa assim, o programa mostrará essa mensagem.
                Console.WriteLine("Operador errado, por favor insira o operador correto");
                break;
        }
    }
}
