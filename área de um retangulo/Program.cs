using System;

namespace área_de_um_retangulo {
    class Program {
        static void Main(string[] args) {

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Calcula a área de um retângulo");
            Console.Write("Informe a altura: ");
            retangulo.Altura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a base: ");
            retangulo.Base = Convert.ToInt32(Console.ReadLine());
            retangulo.ExibeDados();
            Console.ReadKey();
        }
    }
}
