using System;
using System.IO;
using System.Xml.Serialization;
using _00_Blibioteca;

namespace _02_DeserealizarXML
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader stream = new StreamReader(@"C:\Users\03715856602\Documents\GitHub\C-Sharp-Avancado\01-Serealizar-Deserealizar\01_SerealizarXML.xml");
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            Usuario usuario = (Usuario)serializador.Deserialize(stream);

            Console.WriteLine("Usuario - Nome: {0}, Cpf: {1} e e-mail: {2}", usuario.Nome, usuario.Cpf, usuario.Email);
            Console.ReadKey();

        }
    }
}
