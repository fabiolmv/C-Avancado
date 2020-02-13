using System.IO;
using System.Web.Script.Serialization;
using _00_Blibioteca;

namespace _03_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Maria Costa Silva", Cpf = "333.333,33-33", Email = "mariacs@gmail.com" };

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string stringObjSerializado = serializador.Serialize(usuario);

            StreamWriter strem = new StreamWriter(@"C:\Users\03715856602\Documents\GitHub\C-Sharp-Avancado\01-Serealizar-Deserealizar\02_SerealizarJSON.json");

            strem.WriteLine(stringObjSerializado);
            strem.Close();
        }
    }
}
