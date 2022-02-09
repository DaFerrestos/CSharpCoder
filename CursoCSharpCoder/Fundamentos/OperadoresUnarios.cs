using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar() {

            /*
             Operadores unários são os que trabalham em apenas 1 operando, modificando ou manipulando valores, podem ser 
            lógicos ou aritméticos.
             */
            var valorNegativo = -5;
            var booleano = true;
            var numero1 = 1;
            var numero2 = 2;
            

            Console.WriteLine(-valorNegativo);// a negativa neste caso inverterá o valor da variável utilizando princípios matemáticos
            Console.WriteLine(!booleano); // a negação neste caso inverterá o retorno do boolean utilizando princípios da tabela verdade
            numero1++; //atribuição de valor
            --numero2; //decremento de valor, observe que neste caso veio à esquerda da variável,
                       //a ordem neste caso não interfere no retorno embora impacte na precedência da operação matemática.
            Console.WriteLine(numero1);
            Console.WriteLine(numero2);

        
        }
    }
}
