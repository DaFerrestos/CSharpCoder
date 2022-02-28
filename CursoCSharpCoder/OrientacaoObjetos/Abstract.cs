using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.OrientacaoObjetos
{
    //Classes abstratas não podem ser instanciadas.
    //

    public abstract class Celular {
        public abstract string Assistente();

        public string Tocar() {
            return "Trim trim trim ...";
        }
    }

    public class Samsumg : Celular {
        public override string Assistente() {
            return "Olá, meu nome é Bixby!";
        }
    }

    public class Iphone : Celular
    {
        public override string Assistente() {
            return "Olá, meu nome é Siri!";
        }
    }
    class Abstract
    {
        public static void Executar() {
            var celulares = new List<Celular> {
                new Samsumg(),
                new Iphone()
            };

            foreach (var assistente in celulares) {
                Console.WriteLine(assistente.Assistente());
            }
        
        }
    }
}
