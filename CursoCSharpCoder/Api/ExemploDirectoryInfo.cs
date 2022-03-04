using System;
using System.IO;


namespace CursoCSharpCoder.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar() {
            var dirProjeto = @"~/source/repos".ParseHome();
            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists) {
                dirInfo.Create();
            }
            Console.WriteLine();
        }
    }
}
