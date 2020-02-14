using System;

namespace _02_VarDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object t1 = "";
            object t2 = 12345;
            t2 = "";

            var v1 = "";
            var v2 = 12345;
            // ERRO V2 = ""
            // ERRO var v3;

            dynamic d1 = new Usuario { Nome = "Maria" };

            Console.WriteLine(d1.Nome);
            Console.WriteLine(d1.Senha);
            //Erro RunTime no comando d1.Senha, pois objeto nome nao possui propridade senha

            d1 = "";

        }

        class Usuario
        {
            public string Nome { get; set; }
        }

    }
}
