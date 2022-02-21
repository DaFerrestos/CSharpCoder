using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCoder.ClassesEMetodos
{
    /*
     Os métodos Get e Set servem, respectivamente para consultar e atribuir valores a um objeto. 
    Possibilitam o 'encapsulamento' de atributos de um objeto sendo permitida sua consulta ou atribuição somente a partir de instância.
    Possibilitam atribuir lógicas e comparações de atribuição (regras de negócio) de forma mais estruturada.

    Uma vez que os atributos estejam privados, é possível realizar tratamento das informações que serão atribuidas posteriormente.
     */

    public class Moto {
        private string Marca;
        private string Modelo;
        private int Cilindrada;
        
        public Moto(string marca, string modelo, int cilindrada) {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        public Moto() {

        }

        public string GetMarca() {
            return Marca;
        }

        public void SetMarca(string marca) {
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public int GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada (int cilindrada) {
            Cilindrada = cilindrada;
            //Cilindrada = Math.Abs(cilindrada) ---> forma de validar apenas valores absolutos, positivos.
        }
    }
    class GetSet
    {
        public static void Executar() {
            var moto1 = new Moto("Grande", "Ninja", 650);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("Titan");
            moto2.SetCilindrada(-200);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada()); //caso seja incluída a condição
                                                                                                         //de somente valores positivos na definição
                                                                                                         //do escopo do 'getset' do objeto, este
                                                                                                         //passará a aceitar somente valores positivos.

        
        }
    }
}
