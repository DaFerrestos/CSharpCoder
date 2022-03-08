using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Api
{
    class ExemploTimeSpan
    {
        public static void Executar() {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 45);
            Console.WriteLine(intervalo);

            Console.WriteLine("Intervalo em minutos: " + intervalo.TotalMinutes);

            // Mensurando intervalo de tempo:

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);

            var tempoDeCorrida = chegada - largada;

            Console.WriteLine("Duração da corrida: " + tempoDeCorrida);
        
        }
    }
}
