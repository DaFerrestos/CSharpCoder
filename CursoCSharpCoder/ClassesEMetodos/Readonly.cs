using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    /*
     Readonly é utilizado para setar valores imutáveis no construtor ou instanciados.
    Mesmo públicos, esse tipo de atributo não pode ser alterado após declarados.
     */

    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento;


        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        
        }
    
    }
    class Readonly
    {
        public static void Executar() {
            var novoCliente = new Cliente("Ana Maria", new DateTime(1966, 10, 25));

            Console.WriteLine(novoCliente.Nome + " " + novoCliente.GetDataDeNascimento());


            var segundoCliente = new Cliente("Maria", new DateTime(1957, 12, 27));
            Console.WriteLine(segundoCliente.Nome + " " + segundoCliente.GetDataDeNascimento());
        }
    }
}
