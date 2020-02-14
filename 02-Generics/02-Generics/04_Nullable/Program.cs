using System;

namespace _04_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // -2b + 2b - struct - Por Valor
            //int i = null;

            // Class - Por referencia
            object o = null;

            // MySQL, Oracle, PostGreeSQL, NoSQL ETC - -Pode ter informações opcionais
            Nullable<int> Idade = null;
            // pode ser representado por
            int? Idade2 = null;

            //ERRO int Idade3 = null
        }
    }
}
