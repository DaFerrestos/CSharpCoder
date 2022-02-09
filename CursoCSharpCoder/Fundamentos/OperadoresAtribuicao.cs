using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar() {
            /*
             Operadores de atribuição são a junção dos operadores aritméticos (+, -, * e /) ao símbolo de 
            atribuição (=) das variáveis e sua função aqui é de fato atribuir valores aos da descrita variável 
            utilizando menos linhas de código, dispensando a necessidade da criação de uma nova variável apenas 
            para somar ou subtrair o valor da primeira. Exemplos abaixo:             
             */
            var numero = 10; //valor inicial da variável
            numero = 5; //substituição do valor inicial da variável já iniciada
            numero += 10; //adição de valor ao inicial da variável iniciada
            numero -= 2; //subtração de valor ao inicial da variável iniciada
            numero *= 2; //multiplicação do valor inicial da variável iniciada
            numero /= 2; //divisão do valor inicial da variável iniciada

            Console.WriteLine(numero);

            //Também é possível realizar incremento ou decremento da seguinte forma digitando ainda menos:

            int numero1 = 1;
            int numero2 = 2;

            numero1++; //implicitamente o compilador entende a atribuição de adição de 1 valor ao inicial, transformando-o em 3! 
            numero2--; //implicitamente o compilador entende a subtração de 1 valor ao inicial, transformando-o em 1!

            Console.WriteLine($"{numero1} {numero2}");

            /*
             Pode soar redundante, mas quando digo "valor inicial" me refiro ao primeiro valor atribuído a uma variável
            e quando digo "variável iniciada" me refiro ao contexto onde essa variável está inserida. No CSharp, como 
            em outras linguagens que utilizam o padrão de OO (orientação a objetos), existem variáveis de contexto local e contexto global,
            isso quer dizer que ela pode ser acessada apenas dentro de um escopo ou por toda a aplicação, respectivamente, mas em ambas
            as situações ela precisa ser iniciada/declarada antes de ser consumida ou manipulada... 
             */
        }
    }
}
