using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharpCoder.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//única casa decimal
            Console.WriteLine(valor.ToString("C"));//Moeda (currency)
            Console.WriteLine(valor.ToString("P"));//Percentual
            Console.WriteLine(valor.ToString("#.##"));//Outra forma de definir casas decimais

            CultureInfo cultura = new CultureInfo("en-US"); //Define padrão de cultura (símbolo de moeda) seguir
            Console.WriteLine(valor.ToString("C3", cultura)); //Solicitando impressão de dados com o padrão de
                                                              //cultura e número de casas decimais predefinidos

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));//Completa a quantidade de caracteres solicitado com zeros à esquerda

        }
    }
}
