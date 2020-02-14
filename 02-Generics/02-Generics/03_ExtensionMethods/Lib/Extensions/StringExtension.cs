namespace System
{
    public static class StringExtension
    {
        public static string FistToUpper(this string str)
        {
            string Primeira = str.Substring(0, 1);


            string Restante = str.Substring(1);

            return Primeira.ToUpper() + Restante;
        }
    }
}
