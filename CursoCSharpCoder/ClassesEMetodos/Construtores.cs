using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    class Construtores
    {
        class Carro { 
            public string Modelo;
            public string Fabricante;
            public int Ano;

            //Construtor vazio (construtor padrão que inicializa vazio e aguarda atribuição de valores)
            public Carro() {

            }
            
            //Construtor parametrizado
            public Carro(string modelo, string fabricante, int ano) {
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            }
        }

      

        public static void Executar() {
            var carro1 = new Carro();//utilizando construtor vazio/padrão:
            carro1.Modelo = "Gol";
            carro1.Fabricante = "Volksvagen";
            carro1.Ano = 1994;

            Console.WriteLine($"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2010);//utilizando construtor com parâmetros definidos:
            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");

            //Outra forma de uso do construtor padrão:
            var carro3 = new Carro() {
                Modelo = "Uno",
                Fabricante = "Fiat",
                Ano = 2019
            };
            Console.WriteLine($"{carro3.Modelo} {carro3.Fabricante} {carro3.Ano}");
        }
    }
}
