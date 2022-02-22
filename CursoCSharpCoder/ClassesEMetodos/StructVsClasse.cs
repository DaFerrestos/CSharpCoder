using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    public struct SPonto {
       public int X;
       public int Y;
    }

    public class CPonto {
       public int X;
       public int Y;    
    }

    class StructVsClasse
    {
        public static void Executar() {

            SPonto ponto1 = new SPonto { X = 1, Y = 5 };
            SPonto copiaPonto1 = ponto1; //atribuição por valor (padrão de struct)
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 x:{0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 x:{0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; //atribuição por referência (padrão de classe)
            ponto2.X = 5;

            Console.WriteLine("Ponto 1 x:{0}", ponto2.X);
            Console.WriteLine("Copia Ponto 1 x:{0}", copiaPonto2.X);
        }
    }
}
