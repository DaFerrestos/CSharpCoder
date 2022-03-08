using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.TopicosAvancados
{   
    /*
     Permite que os valores iniciem como nulos, isso evita erros ao setar booleans(false) ou mesmo sem inicializar.
     */
    class Nullables
    {
        public static void Executar() {
            Nullable<int> numero = null;
            int? numero2 = null;

            if (numero.HasValue) {
                Console.WriteLine("Valor de numero: {0}", numero);
            } else {
                Console.WriteLine("A variável não possui valor.");
            }

            int valor = numero ?? 10; //Valor padrão ou nulo
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);
        
        }
    }
}
