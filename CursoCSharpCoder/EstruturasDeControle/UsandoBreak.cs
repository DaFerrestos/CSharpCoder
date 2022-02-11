using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar() {

            //O comando "break" interrompe laços de repetição assim que a condição da expressão é atendida.

            Random random = new Random();
            int numeroAleatório = random.Next(1, 51); //lembrando que neste caso o intervalo é de 1 a 50,
                                                      //o último número é a interrupção e não é apresentado

            Console.WriteLine($"O número que queremos é: {numeroAleatório} !");

            for(int i = 1; i <= 50; i++) {
                Console.Write($"{i} É o número que queremos?");
                if (i == numeroAleatório) {
                    Console.WriteLine("Sim!");
                    break;//atendeu a condição, o laço é interrompido e a execução finaliza
                } else {
                    Console.WriteLine("Não!");                    
                }
            }

            Console.WriteLine("Fim...");

        }
    }
}
