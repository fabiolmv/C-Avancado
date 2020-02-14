
using System;
using System.Linq;

namespace _01_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Linq e Lambida
            // Estrutura do Lambida - (entrada de dados) => (expressao)
            int[] lita = { 3, 9, 4, 6, 20, 10, 60, 80, 90 };

            //var listaFiltrada = lita.Where(a => a > 10).Select(a => a);

            var listaFiltrada = lita.Where(a => a > 10).OrderBy(a => a).Select(a => a);
            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();

        }
    }
}
