using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.OrientacaoObjetos
{
    public class Animal { 
        public string Nome { get; set; }
        public Animal(string nome) {
            Nome = nome;        
        }    
    }

    public class Cachorro : Animal { 
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro {nome} inicializando...");
        
        }

        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
            
        }

        //Convertendo o objeto em string para imprimir retorno no console.
        public override string ToString() {
            //condicionando mensagem de retorno.
            if (Altura >= 45.0) {
                return $"{Nome} tem {Altura}cm de altura! Que dogão gigante!";
            } else {
                return $"{Nome} tem {Altura}cm de altura! Que doguinho fofo!";
            }
            
        }
    }
    class ConstrutorThis
    {
        public static void Executar() {
            var spike = new Cachorro("Spike");//herda classe base e imprime altura mesmo não tendo sido declarada explicitamente.
            var max = new Cachorro("Max", 46.0);

            Console.WriteLine(spike);
            Console.WriteLine(max);
        }
    }
}
