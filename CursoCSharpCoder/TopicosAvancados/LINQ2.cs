using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharpCoder.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno(){Nome = "Ana", Idade = 8, Nota = 10 },
                new Aluno(){Nome = "Ana", Idade = 12, Nota = 6.5 },
                new Aluno(){Nome = "Bia", Idade = 7, Nota = 5 },
                new Aluno(){Nome = "Pedro", Idade = 8, Nota = 10 },
                new Aluno(){Nome = "Carlos", Idade = 8, Nota = 9.9 },
                new Aluno(){Nome = "Diana", Idade = 13, Nota = 7.3 },
                new Aluno(){Nome = "Dudu", Idade = 12, Nota = 10 },

            };

            //Filtrando valores:
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            //Verificando se dado existe:
            var generico = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (generico == null) {
                Console.WriteLine("Aluno inexistente!");
            }

            //Filtra primeiro resultado verdadeiro encontrado
            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            /*
             Outros tipos de filtragens são possíveis como FirstOrDefault ou LastOrDefault, por exemplo.
            Essa abordagem de busca é muito eficaz para listas grandes que podem possuir mais de um retorno com os mesmos dados.
            -Lembrando que o valor padrão de objetos é "null"

            -Também é possível realizar cálculos, médias, etc
             */

            var exemploSkip = alunos.Skip(1).Take(3); //Skip pula e Take pega, o parâmetro é a quantidade.
            foreach (var item in exemploSkip) {
                Console.WriteLine(item.Nome);
            }
            
        }
    }
}
