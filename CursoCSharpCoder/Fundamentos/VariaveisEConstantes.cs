using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar() {
            // calculando área de circunferência

            //c# é uma linguagem fortemente tipada, ou seja, é necessário definir o tipo antes da criação da variável

            double raio = 4.5;
            
            // variáveis de valor imutável são constantes
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;

            Console.WriteLine(area);

            Console.WriteLine("Área é igual a " + area);


            //tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            //tamanhos de dados comportados por variáveis

            byte idade = 45;
            Console.WriteLine("Idade:" + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("salário: " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int: " + menorValorInt);

            uint populacaoBrasileira = 212_600_000;
            Console.WriteLine("A população brasileira em Fev de 2022 é de: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long" + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial aproximada: " + populacaoMundial);

            float precoComputador = 5999.99F; //para floats literais (previamente definidos) é necessário incluir um "F ou f" no final do valor indicando
            Console.WriteLine("Preço computador apx: " + precoComputador);

            double valorMercado = 1_000_000_000_000.00;
            Console.WriteLine("Valor de mercado de alguma empresa: " + valorMercado);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Valores astronômicos: " + distanciaEntreEstrelas);

            char letra = 'a'; //armazena unica letra
            Console.WriteLine("único caractere: " + letra);

            string texto = "cadeia de caracteres";
            Console.WriteLine("muitos caracteres: " + texto);
        }
    }
}
