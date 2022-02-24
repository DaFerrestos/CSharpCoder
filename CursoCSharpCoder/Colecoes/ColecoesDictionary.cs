using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Colecoes
{   
    /*
     Estrutura composta por chave e valor onde o valor pode ser duplicado, porém a chave precisa ser única.
     */
    class ColecoesDictionary
    {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2002, "Homem Aranha");// Add = Adiciona valores
            filmes.Add(2021, "Don't Look Up!");
            filmes.Add(2022, "Maes Paralelas");

            if (filmes.ContainsKey(2021)) {
                Console.WriteLine("2021: " + filmes[2021]);//Localiza e imprime valor associado a chave chamada.
                Console.WriteLine("2021: " + filmes.GetValueOrDefault(2021));//Localiza e imprime valor associado a chave chamada.
            }

            Console.WriteLine(filmes.ContainsValue("Doutor Estranho"));//Consulta por valor
        }
    }
}
