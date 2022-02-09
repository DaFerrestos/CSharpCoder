using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar() {

            /*
             Operadores lógicos são os que trabalham baseados na tabela verdade, ou seja, precisam de uma combinação de fatores para 
            confirmação de determinada operação. 
            Tabela verdade ou tabela de verdade é uma ferramenta de natureza matemática muito utilizada no campo do raciocínio lógico. 
            Seu objetivo é verificar a validade lógica de uma proposição composta (argumento formado por duas ou mais proposições simples).

            ***Verificar tabela verdade do "e" && , do "ou" || e do "ou exclusivo/Xor" ^ !
             */

            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTV50 = executouTrabalho1 && executouTrabalho2; //por ter usado a inferência na declaração de variáveis acima
                                                                       //não há problemas em deixar o resultado tipado. O compilador irá entender.
            Console.WriteLine("Conseguiu comprar a TV 50' ? {0}", comprouTV50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete );

            var comprouTV32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a TV 32'? {0}", comprouTV32);


            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);

        }
    }
}
