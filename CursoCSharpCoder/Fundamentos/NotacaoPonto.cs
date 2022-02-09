using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar() {

            /*
             A notação ponto permite acesso às funcionalidades de biblioteca disponíveis para o tipo de 
            valor que se deseja manipular (desde que estes valores não sejam vazios*).
             */

            var saudacao = "olá ".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); //*o sinal de interrogação permite que o valor inicie como vazio ou nulo

            Console.WriteLine("teste".Length); //é possível acessar a funcionalidades de tipos de valores mesmo que
                                               //estes não estejam relacionados a uma variável

        }
    }
}
