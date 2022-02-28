using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.OrientacaoObjetos
{   

    //Interfaces são estruturas cujos métodos são todos publicos e abstratos.
    //Interfaces podem ser implementadas mais de 1x desde que seus métodos a acompanhem.
    //Uma classe pode implementar várias interfaces, mas só pode herdar de 1 outra  classe.

    interface OperacaoBinaria {
        int Operacao(int numero1, int numero2);
    }

    public class Soma : OperacaoBinaria {
        public int Operacao(int numero1, int numero2) {
            return numero1 + numero2;
        }
    }

    public class Subtracao : OperacaoBinaria
    {
        public int Operacao(int numero1, int numero2) {
            return numero1 - numero2;
        }
    }

    public class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int numero1, int numero2) {
            return numero1 * numero2;
        }
    }

    public class Divisao : OperacaoBinaria
    {
        public int Operacao(int numero1, int numero2) {
            return numero1 / numero2;
        }
    }

    class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),
            new Divisao()
        };
        public string ExecutarOperacoes(int numero1, int numero2) {
            string resultado = "";

            foreach (var operacao in operacoes) {
                resultado += $"Usando {operacao.GetType().Name} = {operacao.Operacao(numero1, numero2)}\n"; // "\n" pula linha.
            }

            return resultado;
        }
    }

    class Interface
    {
        public static void Executar() {
            var calculadora = new Calculadora();
            var resultado = calculadora.ExecutarOperacoes(5, 10);

            Console.WriteLine(resultado);
        
        }
    }
}
