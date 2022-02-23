using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Colecoes
{   
    
    /*
     Estrutura homogênea (com elementos do mesmo tipo), estática(quantidade fixa predefinida) e indexada (posições dos elementos é respeitada)
    para agrupar valores.

     */
    class Array
    {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Ana";
            alunos[1] = "Bia";
            alunos[2] = "Caio";
            alunos[3] = "Daniel";
            alunos[4] = "Erica";

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 2.3, 4.8, 9.7, 5.6, 10.0 };

            foreach (var nota in notas) {
                somatorio += nota;
            }

            double mediaTurma = somatorio / notas.Length;
            Console.WriteLine($"A média de notas desta turma é {mediaTurma}");
        }
    }
}
