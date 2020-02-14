using System;

namespace _03_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "olá mundo";
            Console.WriteLine(valor.FistToUpper());
            Console.ReadKey();
        }
    }
}
