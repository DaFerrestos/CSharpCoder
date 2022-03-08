using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.Api
{
    class ExemploDateTime
    {
        public static void Executar() {
            var dateTime = new DateTime(year: 2035, month: 3, day: 24);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Sem horas

            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // Com horas

            var agora = DateTime.Now;
            Console.WriteLine(agora);

            // Manipulação de datas

            var amanha = hoje.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = hoje.AddDays(-1);
            Console.WriteLine(ontem);

            // Formatações

            //detalhes de dia
            Console.WriteLine(hoje.ToString("dd"));
            Console.WriteLine(hoje.ToString("d"));
            Console.WriteLine(hoje.ToString("D"));

            //formato descritivo
            Console.WriteLine(hoje.ToString("dd-MM-yyyy  HH:mm"));
        }
    }
}
