using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Fundamentos
{
    class LendoDados
    {
        public static void Executar() {
            Console.Write("Qual é o seu nome? "); //Permite ao usuário interagir com o console por meio de digitação
            string nome = Console.ReadLine(); //Armazena os dados digitados pelo usuário em uma variável tipada

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());//Converte o tipo inteiro para string permitindo a leitura e
                                                      //armazenamento do compilador, é permitido para outros tipos além de int


            Console.WriteLine($"{nome} tem {idade} anos!"); //Concatenando os dados utilizando interpolação

        }
    }
}
