using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        
        public static void Executar() {
            //acessar a variável 'a' dentro do método Executar():


            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);

        }
    }
}
