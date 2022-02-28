using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharpCoder.OrientacaoObjetos
{
    public class Afilhado : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Afilhado");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(NumeroCelular); //Acessível somente dentro do mesmo projeto
            Console.WriteLine(QualquerCoisa);
            //Console.WriteLine(Segredo); //Acessível somente dentro do mesmo projeto
            //Console.WriteLine(SejaDiscreto); //Acessível somente na mesma classe

        }

    }

    public class AmigoDistante {
        public readonly SubCelebridade amigoDistante = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Acesso somente a dados públicos...");

            Console.WriteLine(amigoDistante.InfoPublica);
            //Console.WriteLine(amigoDistante.CorDosOlhos);
            //Console.WriteLine(amigoDistante.NumeroCelular);
            //Console.WriteLine(amigoDistante.QualquerCoisa);
            //Console.WriteLine(amigoDistante.Segredo);
            //Console.WriteLine(amigoDistante.SejaDiscreto);


        }
    
    }
    class Encapsulamento
    {
        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoEncapsulamento().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new Afilhado().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
