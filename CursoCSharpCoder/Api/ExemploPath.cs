using System;
using System.IO;


namespace CursoCSharpCoder.Api
{
    class ExemploPath
    {
        public static void Executar() {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo)) {
                using (StreamWriter sw = File.CreateText(arquivo)) {
                    sw.WriteLine("Novo arquivo criado!");
                }
            }

            if (!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }

            //consultando atributos do arquivo
            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.GetDirectoryName(arquivo));
            Console.WriteLine(Path.HasExtension(arquivo));

            //consultando atributos do diretório
            Console.WriteLine(Path.HasExtension(pasta));
            Console.WriteLine(Path.GetFullPath(pasta));
            Console.WriteLine(Path.GetPathRoot(pasta));


            //Os métodos do Path são estáticos, ou seja, não precisam ser instanciados.
            
        }
    }
}
