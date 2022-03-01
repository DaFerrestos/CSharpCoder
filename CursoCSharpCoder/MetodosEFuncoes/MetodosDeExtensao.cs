using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.MetodosEFuncoes
{
    //Utilização de extensões de tipo
    public static class ExtensoesInteiro {
        public static int Soma(this int num, int outroNumero) {
            return num + outroNumero;
        }

        public static int Subtracao(this int num, int outroNumero) {
            return num - outroNumero;
        }
    }
    class MetodosDeExtensao
    {
        public static void Executar() {
            int numero = 5;

            //Chamada a partir de instância
            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numero.Subtracao(5));

            //Possível chamar a função utilizando números literais
            Console.WriteLine(2.Soma(5));
            Console.WriteLine(10.Subtracao(5));
            
        }
    }
}
