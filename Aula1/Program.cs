using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            byte idade;

            Console.WriteLine("Qual é o seu nome por favor: ");

            nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade");

            idade = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Seu nome é " + nome + " e sua idade atual é " + idade);
        }
    }
}
