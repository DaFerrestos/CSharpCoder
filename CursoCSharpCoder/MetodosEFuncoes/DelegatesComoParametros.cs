using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.MetodosEFuncoes
{
    class DelegatesComoParametros
    {
        public delegate int Operacoes(double x, double y);

        public static double Soma(double x, double y) {
            return x + y;
        }

        public static string Calculadora(Operacao op, double x, double y) {
            var resultado = op(x, y);
            return "resultado" + resultado; 
        }
        public static void Executar() {
            Operacao subtracao = (double x, double y) => x - y;
            Console.WriteLine(Calculadora(subtracao, 5, 2));

            Console.WriteLine(Calculadora(Soma, 5, 2));

            
        }
    }
}
