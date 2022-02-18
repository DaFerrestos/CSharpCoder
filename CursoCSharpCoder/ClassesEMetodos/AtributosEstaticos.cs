using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    class AtributosEstaticos
    {
        public class Produto {
            public string Nome;
            public double Preço;
            public double Desconto = 0.1;

            public Produto(string nome, double preço, double desconto) {
                Nome = nome;
                Preço = preço;
                Desconto = desconto;
            }
        
            public Produto() {

            }

            public double CalcularDesconto() {
                return Preço - Preço * Desconto;
            }
        }
        public static void Executar() {

            var produto1 = new Produto("Caneca", 50.00, 0.1);
            var produto2 = new Produto() {
                Nome = "Lenço",
                Preço = 20.00,
                Desconto = 0.1
            };

            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());
        
        }
    }
}
