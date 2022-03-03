using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCSharpCoder.Api
{
    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
            //Execução terá êxito se sua solução estiver sendo executada na pasta padrão
        }
    }
    class PrimeiroArquivo
    {
        public static void Executar() {
            var path = @"~/primeiro_arquivo.txt";

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                   
                }
            }
        
        }
    }
}
