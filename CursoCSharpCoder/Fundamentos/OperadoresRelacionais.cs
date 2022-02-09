using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar() {
            /*
             Operadores relacionais são os de comparação entre valores e seu retorno
            sempre será um boolean, ou seja, verdadeiro ou falso de acordo com o que está sendo comparado.
            Sempre levando em consideração a referência de dado para que possa haver comparação:
            "Maior que, Menor que, Igual a, Diferente de"
             */

            //double nota = 6.0;
            Console.Write("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);// forma de interação captando digitação do usuário
                                                                 // no console e atribuindo como valor da variável a ser analizada.
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            Console.WriteLine("Nota inválida? {0}", nota < 0.0);

            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);

        }
    }
}
