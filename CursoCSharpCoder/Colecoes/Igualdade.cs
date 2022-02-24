using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Colecoes
{
    /*
     Combinado a implementação de GetHashCode nos objetos, realiza buscas e comparações eficazes que evitam duplicidades
     */
    class Igualdade
    {
        public static void Executar() {
            var produto1 = new Produto("Livro", 10.0);
            var produto2 = new Produto("Livro", 10.0);
            var produto3 = produto2;

            //nos exemplos de comparação abaixo o compilador compara espaços de memória e não valores
            Console.WriteLine(produto1 == produto2);
            Console.WriteLine(produto1.Equals(produto2));

            //no exemplo de comparação abaixo o compilador compara referência de valor
            Console.WriteLine(produto3 == produto2);


            
        }
    }
}
