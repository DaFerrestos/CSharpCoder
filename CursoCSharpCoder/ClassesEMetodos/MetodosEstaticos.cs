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
        
        public static int Multiplicar(int a, int b) {
            return a + b;
        }
            
    }


    class MetodosEstaticos
    {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Somar(2, 5);
            Console.WriteLine(resultado);//retorno armazenado em variável
            Console.WriteLine(CalculadoraEstatica.Multiplicar(5,5));//execução chamada diretamente no console
                                                                    //utilizando notação ponto.

        }
    }
}
