using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.TopicosAvancados
{
    /*
     Classe genérica, em seu uso ela terá um tipo especificado no momento da sua instância ou quando herdada por outra classe.
     */
    public class Caixa<T> {
        T valorPrivado;
        public T Coisa { get; set; }

        public Caixa(T coisa) {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor) {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor() {
            return valorPrivado;
        }
    }

    class CaixaInt : Caixa<int> {
        public CaixaInt() : base(0) { 
        
        }
    }
    class Genericos
    {
        public static void Executar() {
            var caixa1 = new Caixa<int>(1000);

            Console.WriteLine(caixa1.metodoGenerico(33)); //a atribuição desta função terá chances iguais de retornar
                                                          //qualquer um dos valores possíveis para atribuição randomica
                                                          //e aleatoriamente.
        }
    }
}
