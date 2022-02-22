using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{   
    /**/
    interface Ponto {
        void MoverDiagonal(int delta);
    }

    struct Coordenada: Ponto {
        public int X;
        public int Y;
        
        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }

    class ExemploStruct
    {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada inicial: ");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverDiagonal(10);

            Console.WriteLine("Coordenada Final: ");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);
        }
    }
}
