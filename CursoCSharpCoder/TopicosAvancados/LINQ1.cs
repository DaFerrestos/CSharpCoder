using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharpCoder.TopicosAvancados
{
    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    
    }
    class LINQ1
    {
        /*
         Realiza consultas e filtros como "sql" diretamente nas funções
         */
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

            //Filtro
            Console.WriteLine("== Aprovados ===========");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);

            foreach (var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }

            //Ordenação
            Console.WriteLine("\n== Chamada ==========");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada) {
                Console.WriteLine(aluno);
            }
        }
    }
}
