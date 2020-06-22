using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaCirculo = 0;
            double RaioDoCirculo = 0;

            Console.WriteLine(" Informe o raio do Círculo : ");

            RaioDoCirculo = Convert.ToDouble(Console.ReadLine());
            areaCirculo = Math.PI * Math.Pow(RaioDoCirculo, 2);

            Console.WriteLine(" A área do círculo de raio " + RaioDoCirculo.ToString() + " é : " + areaCirculo.ToString("F2"));
            Console.ReadKey();
            
        }
    }
}
