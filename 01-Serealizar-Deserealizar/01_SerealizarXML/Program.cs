using System.IO;
using System.Xml.Serialization;
using _00_Blibioteca;

namespace _01_SerealizarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Jose Costa Silva", Cpf = "222.222,222-02", Email = "josecs@gmail.com" };
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            // XmlSerializer serializador = new XmlSerializer(usuario.GetType());

            StreamWriter stream = new StreamWriter(@"C:\Users\03715856602\Documents\GitHub\C-Sharp-Avancado\01-Serealizar-Deserealizar\01_SerealizarXML.xml");

            serializador.Serialize(stream, usuario);

        }
    }
}
