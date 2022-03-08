using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.TopicosAvancados
{
    /*
     Tipos dinâmicos permitem alternância de tipo de dado.   
     */
    class Dynamics
    {
        public static void Executar() {

            //No caso abaixo a variável foi inicializada como string
            //e depois alterada para um int que pôde ser incrementado:

            dynamic meuObjeto = "teste";
            meuObjeto = 12;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            //uso de atribuições dinamicas:

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Ana";
            aluno.idade = 12;
            aluno.nota = 7.5;

            Console.WriteLine($"{aluno.nome}, tem {aluno.idade} e tirou {aluno.nota} de média neste semestre");
        
        }
    }
}
