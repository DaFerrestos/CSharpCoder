using System;
using System.Collections;
using System.Text;

namespace CursoCSharpCoder.Colecoes
{   
    /*
     O conceito de pilha é LIFO (Last in First out)
     */
    class ColecaoStack
    {
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push("Palavra");// Push = acrescenta elemento na pilha
            pilha.Push(5);
            pilha.Push(5.2);
            pilha.Push(true);
            pilha.Push(3.14f);
        
            
            foreach(var item in pilha){
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");// Pop = remove elemento da pilha

            foreach (var item in pilha) {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nPeek: {pilha.Pop()}");// Peek = pega elemento da pilha sem remover
        }

    }
}
