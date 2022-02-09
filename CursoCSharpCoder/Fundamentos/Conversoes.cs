using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Fundamentos
{
    class Conversoes
    {
        public static void Executar() {
            /*
             * Conversões de valores sempre precisam ser explícitas no C#, independente do tipo de dado convertido ou para qual
             * está sendo convertido para que o compilador consiga identificar e manipular corretamente os dados e não hajam perdas.
             */

            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);//neste exemplo houve conversão implícita sem perda de dados
                                        //especialmente pelo motivo de que o tipo double comporta
                                        //uma quantidade de caracteres grande o suficiente para receber um tipo int
                                        //sempre que uma conversão corra o risco de finalizar em perda de dados ela não será feita implicitamente.

            double nota = 9.7;
            int notaTruncada = (int) nota; //forma de realizar conversão explícita de tipo de dado para assumir o risco pela perda!
                                           //(0.7, neste caso). Este conceito de conversão explícita é conhecido como Cast no C#
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

        }
    }
}
