using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.OrientacaoObjetos
{
    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        //public Carro() {}  ===> Exemplo de construtor padrão que encurta o caminho para herança.

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if(novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }
        public int Acelerar() {
            return AlterarVelocidade(5);
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }

    }

    public class Uno : Carro {
        public Uno() : base(200) { //construtor base, usado na ausência do construtor padrão definido na classe.
        
        }


    
    }
    class Heranca
    {
        public static void Executar() {

            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();

            //testando métodos da classe:

            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

        }
    }
}
