using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDosOlhos); //transmitido apenas por herança
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.QualquerCoisa);
            //Console.WriteLine(amiga.Segredo); //transmitido apenas por herança
            //Console.WriteLine(amiga.SejaDiscreto); //disponível apenas na classe

        }
            
    }
}
