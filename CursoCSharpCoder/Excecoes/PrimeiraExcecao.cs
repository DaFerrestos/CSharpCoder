using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Excecoes
{
    public class Conta {
        double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if (valor > Saldo) {
                throw new ArgumentException("Saldo insuficiente.");
            }

            Saldo -= valor;
        }
    }
    class PrimeiraExcecao
    {
        public static void Executar() {
            var conta = new Conta(150.0);

            try { //utilizado em casos que podem ocorrer exceções no retorno da função
                conta.Sacar(160.0);
                Console.WriteLine("Retirada com sucesso!");
            } catch(Exception ex) { //trata exceções
                Console.WriteLine(ex.Message);
            } finally { //sempre executado, encerra as tentativas.
                Console.WriteLine("Obrigada!");
            }
        }
    }
}
