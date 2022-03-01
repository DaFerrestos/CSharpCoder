using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.MetodosEFuncoes
{
    /*
     Tipos que armazenam como assinatura uma função.
     */

    delegate double Operacao(double x, double y);

    class LambdasDelegate
    {
        public static void Executar() {
            Operacao sum = (x, y) => x + y;    
            Operacao sub = (x, y) => x - y;    
            Operacao mult = (x, y) => x * y;    
            Operacao div = (x, y) => x / y;

            //Utilização da função dentro do mesmo escopo:

            Console.WriteLine(sum(5,5));
            Console.WriteLine(sub(10,5));
            Console.WriteLine(mult(10,5));
            Console.WriteLine(div(10,5));
        }


    }
}
