using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class FilhoEncapsulamento : SubCelebridade
    {
        public new void MeusAcessos() {

            Console.WriteLine("Informações herdadas...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(QualquerCoisa);
            Console.WriteLine(Segredo);
           // Console.WriteLine(SejaDiscreto);  //não pode ser acessado nem por herança

        }
    }
}
