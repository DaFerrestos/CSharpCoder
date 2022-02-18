using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    class ParametrosNomeados
    {

        public static void FormatarData(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);        
        }
        public static void Executar() {

            FormatarData(mes: 3, dia: 24, ano: 1991);//independente da forma como forem atribuidos os valores,
                                                     //serão apresentados conforme foram descritos acima.
        
        }
    }
}
