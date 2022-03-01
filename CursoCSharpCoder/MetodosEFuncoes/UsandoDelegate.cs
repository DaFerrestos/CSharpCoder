using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.MetodosEFuncoes
{
    class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimindoSoma(double a, double b);

        static double MinhaSoma(double x, double y) {
            return x + y;
        }

        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a + b);
        }
        public static void Executar() {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(5, 5.5));

            ImprimindoSoma op2 = MeuImprimirSoma;
            op2(1.1, 5);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5,3));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(5.5, 2);
            
        }
    }
}
