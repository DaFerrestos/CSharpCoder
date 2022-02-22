using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    class ParametroPadrao
    {

        public static int Somar(int a = 1, int b = 1) {
            return a + b;
        } 
        public static void Executar() {

            //Durante a execução a função partirá dos valores definidos, então caso sejam passados valores
            //ela utilizará na chamada, caso não sejam, ela substituirá pelos valores padrão.


            Console.WriteLine(Somar(10,25));
            Console.WriteLine(Somar(10));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b:5));
        
        }
    }
}
