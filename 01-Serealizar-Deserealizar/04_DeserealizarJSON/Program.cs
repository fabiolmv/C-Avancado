using System;
using System.IO;
using System.Web.Script.Serialization;
using _00_Blibioteca;

namespace _04_DeserealizarJSON
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader strem = new StreamReader(@"C:\Users\03715856602\Documents\GitHub\C-Sharp-Avancado\01-Serealizar-Deserealizar\02_SerealizarJSON.json");

            string linhaDoArquivo = strem.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            Usuario usuario = (Usuario)serializador.Deserialize(linhaDoArquivo, typeof(Usuario));

            Console.WriteLine("Usuario - Nome: {0}, Cpf: {1} e e-mail: {2}", usuario.Nome, usuario.Cpf, usuario.Email);
            Console.ReadKey();
        }
    }
}
