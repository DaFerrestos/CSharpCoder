using System;
using System.Collections;//Array list não utiliza biblioteca "generics"
using System.Text;

namespace CursoCSharpCoder.Colecoes
{

    class ColecoesArrayList
    {
        public static void Executar() {
            var arrayList = new ArrayList{
                "Palavra",
                3.99,
                true,
                7,
            };

            arrayList.Add(false);

            foreach(var item in arrayList) {
                Console.WriteLine("{0} => {1}", item, item.GetType()); //lista com descrição de tipo
            }
        
        }
    }
}
