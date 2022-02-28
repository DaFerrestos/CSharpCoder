using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.OrientacaoObjetos
{
    public class Comida {
        public double Peso;

        public Comida(double peso) {
            Peso = peso;
        }

        public Comida() { 
        
        }
    }
    public class Feijao : Comida {
        
    }

    public class Arroz : Comida {
        
    }

    public class Proteina: Comida {
        
    }

    public class Pessoa {
        public double Peso;

        public void Comer(Comida comida) {
            Peso += comida.Peso;
        }

        //public void Comer(Feijao feijao) {
        //    Peso += feijao.Peso;

        //}
        //public void Comer(Arroz arroz) {
        //    Peso += arroz.Peso;

        //}

        //public void Comer(Proteina proteina) {
        //    Peso += proteina.Peso;

        //}

    }
    class Polimorfismo
    {
        public static void Executar() {
            Feijao comida1 = new Feijao();
            comida1.Peso = 0.2;


            Arroz comida2 = new Arroz();
            comida2.Peso = 0.2;

            Proteina comida3 = new Proteina();
            comida3.Peso = 0.5;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 57.5;
            cliente.Comer(comida1);
            cliente.Comer(comida2);
            cliente.Comer(comida3);

            Console.WriteLine("Peso atual" + " " + cliente.Peso);
        }
    }
}
