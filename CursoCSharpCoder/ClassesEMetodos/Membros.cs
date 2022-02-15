using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    class Membros
    {
        public static void Executar() {
            Pessoa fulano = new Pessoa();//instância de objeto
            fulano.Nome = "Maria";
            fulano.Idade = 60;

            Console.WriteLine($"{fulano.Nome} tem {fulano.Idade}");
            
            //Outra forma: Retorno de método do objeto
            fulano.ApresentarNoConsole();

            var sicrano = new Pessoa();
            sicrano.Nome = "João";
            sicrano.Idade = 35;

            var apresentandoSicrano = sicrano.Apresentar();
            Console.WriteLine(apresentandoSicrano);

        }

    }
}
