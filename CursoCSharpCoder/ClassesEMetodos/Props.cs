using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    public class CarroOpcional {
        double desconto = 0.1; //atributos que não tenham nada descrito antes do tipo são privados por padrão(private)
        string nome;

        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        //Propriedade autoimplementada:
        public double Preco { get; set; }
        
        //Propriedade somente leitura:
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco);
        }

        public CarroOpcional() {

        }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    class Props
    {
        public static void Executar() {
            var opcao1 = new CarroOpcional("Ar Condicionado", 3599.9);
            Console.WriteLine(opcao1.PrecoComDesconto);

            var opcao2 = new CarroOpcional();
            opcao2.Nome = "Direção";
            opcao2.Preco = 2349.9;

            Console.WriteLine(opcao2.Nome);
            Console.WriteLine(opcao2.Preco);
            Console.WriteLine(opcao2.PrecoComDesconto);
        }
    }
}
