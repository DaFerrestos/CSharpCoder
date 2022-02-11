﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.EstruturasDeControle
{
    class EstruturaSwitch
    {
        public static void Executar() {
            /*
            Estrutura de sentenças condicionadas, a diferença desta opção para if else é que neste caso não se analisa retornos verdadeiros e 
            falsos, mas valores diversos.
            */

            Console.WriteLine("Avalie meu atendimento de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 0:
                    Console.WriteLine("Péssimo!");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim!");
                    break;
                case 3:
                    Console.WriteLine("Regular!");
                    break;
                case 4:
                    Console.WriteLine("Bom!");
                    break;
                case 5:
                    Console.WriteLine("Ótimo!");
                    Console.WriteLine("Parabéns!");
                    break;
            }

            Console.WriteLine("Obrigado por responder!");
        }
    }
}
