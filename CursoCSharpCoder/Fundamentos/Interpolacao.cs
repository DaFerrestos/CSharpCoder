using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Fundamentos
{
    class Interpolacao
    {
        public static void Executar() {
            string nome = "Notebook";
            string marca = "Dell";
            double preco = 6.800;

            //formas de concatenar textos com valores atribuidos a variáveis utilizando interpolação:

            Console.WriteLine("O" + nome + "da marca" + marca + "custa: " + preco);

            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            Console.WriteLine($"O {nome} da marca {marca} custa {preco}");
        }
    }
}
