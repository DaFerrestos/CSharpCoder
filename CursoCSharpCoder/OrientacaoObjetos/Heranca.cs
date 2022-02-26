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
        public virtual int Acelerar() { //a marcação "virtual" indica que o método pode ser sobrescrito
                                        //nas instâncias. 
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

    public class Ferrari : Carro {
        public Ferrari() : base(350) { 
        }

        public override int Acelerar() { // a marcação "override" indica que estamos sobrescrevendo um método
                                         // definido na classe pai. *Sobrescrever é o mesmo que Substituir.*
            return AlterarVelocidade(15);
        }

        public new int Frear() {//a marcação "new" oculta o método da classe pai.

            return AlterarVelocidade(-15);
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


            //Segundo Teste:

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();

            //testando métodos da classe:

            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            //Terceiro Teste:
            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari();

            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            //
            carro3 = new Uno();//Exemplo de uso do Polimorfismo é quando a mesma variável
                               //é chamada por tipos diferentes.

            Console.WriteLine("Uno com tipo Carro...");
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
