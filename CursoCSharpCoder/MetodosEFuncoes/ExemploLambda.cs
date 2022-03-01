using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.MetodosEFuncoes
{   
    /*
     Funções Lambda são funções anônimas com sintaxe simplificada.
     */

    class ExemploLambda
    {
        public static void Executar() {

            Action algoNoConsole = () => { //Action é uma função void (vazia)
                Console.WriteLine("Lambda no CSharp!");
            };

            algoNoConsole();

            Func<int> jogandoDados = () => {
                Random random = new Random();
                return random.Next(1, 5);
            };

            Console.WriteLine(jogandoDados());

            Func<int, string> convertendoHex = numero => numero.ToString("X"); //sentença única, abre mão da sintaxe padrão.
            Console.WriteLine(convertendoHex(16));


            Func<int, int, int, string> formatandoData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatandoData(24, 3, 1991));

        }
    }
}
