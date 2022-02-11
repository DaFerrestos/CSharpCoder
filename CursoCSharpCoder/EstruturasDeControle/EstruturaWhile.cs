using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar() {

            /*
            Estrutura de repetição onde a sentença ocorrerá enquanto a expressão for verdadeira ou falsa.
            No momento em que a condição da expressão for atendida, o laço encerrará!
            */

            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativasFeitas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira aqui seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativasFeitas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Você acertou em {0} tentativas! Parabéns", tentativasFeitas);
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor...Tente novamente!");
                    Console.WriteLine("Você ainda pode tentar {0} vezes...", tentativasRestantes);
                } else {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("Você ainda pode tentar {0} vezes...", tentativasRestantes);
                }
            }

            Console.WriteLine("Acabaram as chances... Não foi desta vez!");
        }
    }
}
