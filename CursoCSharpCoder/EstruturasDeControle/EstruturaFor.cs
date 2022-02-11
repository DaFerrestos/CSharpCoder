using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar() {
            //Estrutura de repetição apropriada para utilizar em casos de quantidade
            //de repetições pré determinado.

            int i = 1;

            //utilizando While para uma quantidade pré determinada de repetições:
            while (i <= 10) {
                Console.WriteLine($"O valor de i é {i}!");
                i++;
            }

            //utilizando For:

            for(int iFor = 1; iFor <= 10; iFor ++) {
                Console.WriteLine($"O valor de iFor é {iFor}!");
            }

            //A utilização do laço de repetição for tem uma declaração mais enxuta.


            //Mais um exemplo:

            double somatorio = 0;
            string entrada;

            Console.Write("Informe a quantidade de alunos: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int qtidadeAlunos);

            for(int a = 1; a < qtidadeAlunos; a++) {
                Console.WriteLine("Digite a primeira nota {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double mediaTurma = qtidadeAlunos > 0 ? somatorio / qtidadeAlunos : 0;
            Console.WriteLine("A média da turma é: {0}", mediaTurma);

        }
    }
}
