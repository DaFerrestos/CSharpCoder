using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade {
        //Acessada por todos
        public string InfoPublica = "Redes Sociais";

        //Transmitido por herança
        protected string CorDosOlhos = "Castanhos";

        //Dentro do mesmo projeto
        internal ulong NumeroCelular = 551199999999;

        //herança ou mesmo projeto
        protected internal string QualquerCoisa = "Qualquer coisa";

        //Mesma classe ou herança no mesmo projeto
        private protected string Segredo = "blablabla";

        //Valor padrão (dentro da própria classe)
        bool SejaDiscreto = true;

        public void MeusAcessos(){
            Console.WriteLine("SubCelebridade");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(QualquerCoisa);
            Console.WriteLine(Segredo);
            Console.WriteLine(SejaDiscreto);
        }
    }
}
