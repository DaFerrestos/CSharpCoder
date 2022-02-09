using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar() {
            /*
             Operadores aritméticos são os utilizados para realização de cálculos matemáticos básicos como
            soma, subtração, multiplicação e divisão. Na programação eles são muito utilizados e respeita-se 
            a regra de precedência de cálculos como na matemática, seja utilizando separadores como parênteses e 
            colchetes ou não. 
             */

            var preco = 1000.00;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é: {0}", totalComDesconto);

            //Cálculo de IMC
            double peso = 102.9;
            double altura = 1.66;
            double imc = peso / Math.Pow(altura, 2); // Forma de elevar ao quadrado no CSharp
            Console.WriteLine($"IMC é {imc} !");


            //Número par e número ímpar:

            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
