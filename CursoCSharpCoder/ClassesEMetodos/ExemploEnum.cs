using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    /*
     Enumera itens. Tipo de valor distinto (tipos de valor) que declara um conjunto de constantes nomeadas. 
     */

    public enum Genero {Acao, Aventura, Romance, Drama, Comedia};

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;    
    }

    class ExemploEnum
    {
        public static void Executar() {
            int id = (int)Genero.Acao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Hotel Transilvânia";
            filmeParaFamilia.GeneroDoFilme = Genero.Aventura;

            Console.WriteLine("{0} é {1}", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        
        }
    }
}
