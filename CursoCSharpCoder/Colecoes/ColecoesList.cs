using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Colecoes
{
    class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Nome, Preco);
        }
    }
    class ColecoesList
    {
        public static void Executar() {
            var livro = new Produto("Mulheres que Correm com Lobos", 89.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>() {
                new Produto("Poster", 10.0),
                new Produto("Caneca", 49.9),
                new Produto("Camiseta", 29.9),
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} - {item.Preco}");
            }
        }
    }
}
