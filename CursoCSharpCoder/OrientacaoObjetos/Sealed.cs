using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.OrientacaoObjetos
{
    //Classes seladas (sealed) não permitem herança. Implementação em métodos virtuais.
    sealed class SemFilho {
        public double ValorFortuna() {
            return 1_500_000.00;
        }    
    }


    //Exemplo de implementação demonstrando herança: 
    class Avo {
        public virtual bool HonraDaFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public sealed override bool HonraDaFamilia() {
            return true;
        }
    }

    // A partir da implementação do sealed no método não é possível alterar seu valor.
    class FilhoRebelde : Pai
    {
        //public sealed override bool HonraDaFamilia() {
        //    return false;
        //}
    }


    class Sealed
    {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorFortuna());


            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonraDaFamilia());
        
        }
    }
}
