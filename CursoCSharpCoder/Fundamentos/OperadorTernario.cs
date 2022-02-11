using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar() {

            /*
            Resultando em bifurcação de retornos, os operadores ternários são uma alternativa mais enxuta às expressões If e If else.
            Realizam comparações de expressões verdadeiras ou falsas, utilizando de operadores relacionais.

            ***Atribuição condicional***
            Expressão - Operando1 - Operando2
             */

            var nota = 7.0; //variável inicializada, valor inicial atribuído.
            string resultado = nota >= 7.0 ? "Aprovado!" : "Reprovado"; //operação ternária onde uma variável recebe
                                                                        //uma expressão e a partir do retorno bool dela (true ou false)
                                                                        //reterna um dos dois operandos descritos.
            Console.WriteLine(resultado);


            //Realizando a operação ternária através de interação com o usuário:

            Console.Write("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double notaUsuario);
            string retorno = notaUsuario >= 7.0 ? "Aprovado!" : "Reprovado"; 
            Console.WriteLine(retorno);

        }
    }
}
