using System;
using System.IO;


namespace CursoCSharpCoder.Api
{
    class LendoArquivos
    {
        public static void Executar() {
            var path = @"~/lendo_arquivos.txt".ParseHome();




            if (!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto; Preco; Qtde");
                    sw.WriteLine("Produto 1; 2.99; 5");
                    sw.WriteLine("Produto 2; 10.00; 2");
                    sw.WriteLine("Produto 3; 1.00; 50");
                }

            }

            try {
                using (StreamReader sr = new StreamReader(path)) {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
        }
    }
