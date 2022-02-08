using System;
using System.Collections.Generic;

using CursoCSharpCoder.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}