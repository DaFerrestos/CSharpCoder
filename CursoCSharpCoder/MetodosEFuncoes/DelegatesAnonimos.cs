using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.MetodosEFuncoes
{
    class DelegatesAnonimos
    {
        delegate string StringOperacao(string s);
        public static void Executar() {
            StringOperacao inverter = delegate (string s) {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter("CSharp é show!!!"));

        
        }
    }
}
