using System;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            float ht, vh, pd, sb, td, sl;

            Console.WriteLine("Horas trabalhadas");
            ht = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Valor da hora");
            vh = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Percentagem de desconto");
            pd = float.Parse(Console.ReadLine());

            sb = ht * vh;
            td = (pd / 100) * sb;
            sl = sb - td;


            Console.WriteLine();
            Console.WriteLine("Salário líquido");
            Console.WriteLine(sl.ToString("f2"));

            Console.ReadKey();
        }
    }
}
