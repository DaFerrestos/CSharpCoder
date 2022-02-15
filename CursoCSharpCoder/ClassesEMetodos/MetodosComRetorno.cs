using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    class MetodosComRetorno
    {
        class CalculadoraComum { 
            public int Somar (int a, int b) {
                return a + b;
            }

            public int Subtrair (int a, int b) {
                return a - b;
            }

            public int Multiplicar (int a, int b) {
                return a * b;
            }

            public int Dividir (int a, int b) {
                return a / b;
            }

        }
        
        class CalculadoraCadeia {
            int memoria;

            public CalculadoraCadeia Somar(int a) {
                memoria += a;
                return this;
            }
            public CalculadoraCadeia Multiplicar(int a) {
                memoria *= a;
                return this;
            }
            public CalculadoraCadeia Limpar() {
                memoria = 0;
                return this;
            }
            public CalculadoraCadeia Imprimir() {
                Console.WriteLine(memoria);
                return this;
            }
            public int Resultado() {
                return memoria;
            }
        }
        
        public static void Executar() {

            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2,7));
            Console.WriteLine(calculadoraComum.Multiplicar(2,7));
            Console.WriteLine(calculadoraComum.Dividir(2,7));


            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(5).Multiplicar(5).Limpar().Imprimir();

            
        }
    }
}
