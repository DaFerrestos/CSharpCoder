using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    public class Dependente {
        public string Nome;
        public int Idade;    
    }

    class ValorVsReferencia
    {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} e {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} e {copiaNumero}");


            Dependente filho = new Dependente {
                Nome = "Gael",
                Idade = 3
            };

            Dependente filho2 = filho;

            //A chamada por referência faz com que as duas variáveis apontem para o mesmo lugar da memória.

            Console.WriteLine($"{filho.Nome} {filho2.Nome}");
            Console.WriteLine($"{filho.Idade} {filho2.Idade}");

        }
    }
}
