using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero) {
            numero = numero + 10;
        }

        public static void AlterarOut(out int numero) {
            numero = 0; // out precisa ser inicializado para ter ponto de partida para alteração (unidirecional. saída. não somatiza nada)
            numero = numero + 15;
        }
        public static void Executar() {

            int primeiroTeste = 5;
            AlterarRef(ref primeiroTeste);//referencia o valor inicial parametrizado
            Console.WriteLine(primeiroTeste);

           
            AlterarOut(out int segundoTeste);
            Console.WriteLine(segundoTeste);
        }
    }
}
