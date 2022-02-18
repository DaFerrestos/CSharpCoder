using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    class CalculadoraEstatica { 

        //Métodos estáticos não precisam ser instanciados antes de serem somados pois
        //não pertencem ao objeto e sim a classe.

        

        public static int Somar(int a, int b) {
            return a + b;
        }

        //Métodos de instância só são acessíveis através da instância!!!
        public int Multiplicar(int a, int b) {
            return a * b;
        }
            
    }


    class MetodosEstaticos
    {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Somar(2, 5);
            Console.WriteLine(resultado);//retorno armazenado em variável

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Multiplicar(5,5));

        }
    }
}
