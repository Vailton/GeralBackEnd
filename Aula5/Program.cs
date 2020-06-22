using System;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaCirculo = 3.14159;
            double RaioDoCirculo = 2.00;

            Console.WriteLine("Entrada ");
            Console.WriteLine("Informe o raio do Círculo ");

            RaioDoCirculo = Convert.ToDouble(Console.ReadLine());
            areaCirculo = Math.PI * Math.Pow(RaioDoCirculo, 2);

            Console.WriteLine("Saída ");
            Console.WriteLine("A área do Círculo de raio " + RaioDoCirculo.ToString() + " é: " + areaCirculo.ToString("f4"));

            Console.WriteLine();
        }
    }
}
