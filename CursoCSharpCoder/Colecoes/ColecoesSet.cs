using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Colecoes
{
    /*
     Diferente do List, o Set não aceita repetições(duplicação) ou consultas de índices
     */
    class ColecoesSet
    {
        public static void Executar() {
            var livro = new Produto("Mulheres que Correm com Lobos", 89.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>() {
                new Produto("Poster", 10.0),
                new Produto("Caneca", 49.9),
                new Produto("Camiseta", 29.9),
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
           

            foreach (var item in carrinho) {
                Console.WriteLine($"{item.Nome} - {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }
}
