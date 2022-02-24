using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharpCoder.Colecoes
{
    /*
     O conceito de fila é FIFO (First in First out) 
     */
    class ColecoesQueue
    {
        public static void Executar() {
            var fila = new Queue<string>();//Agrupa elementos de um mesmo tipo predefinido em uma fila

            fila.Enqueue("Ana");//Enqueue = Enfileirar
            fila.Enqueue("Bia");
            fila.Enqueue("Caio");
            fila.Enqueue("Diana");

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            Console.WriteLine(fila.Peek());//Pegar um elemento da lista sem remover
            Console.WriteLine(fila.Count);//Contar elementos da lista 
            Console.WriteLine(fila.Dequeue());//Remover elemento da lista //Dequeue = Desenfileirar
            Console.WriteLine(fila.Count);

            var misturaTipos = new Queue();//Permite elementos de diferentes tipos na mesma fila
            misturaTipos.Enqueue(true);
            misturaTipos.Enqueue("string");
            misturaTipos.Enqueue(3);
            misturaTipos.Enqueue(3.14);

            Console.WriteLine(fila.Peek());//Pegar um elemento da lista sem remover
            Console.WriteLine(fila.Count);//Contar elementos da lista 
            Console.WriteLine(fila.Dequeue());//Remover elemento da lista 
            Console.WriteLine(fila.Count);

        }
    }
}
