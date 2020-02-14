using System.IO;
using System.Web.Script.Serialization;

namespace _01_Generics
{
    public class Serealizador
    {
        public static void Serializar(object obj)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\fabio\OneDrive\Documentos\Cursos\Udemy\C-Sharp-Avancado-EliasRibeiro\C-Sharp-Avancado\02-Generics\01_" + obj.GetType().Name + ".txt");

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objetoSer = serializador.Serialize(obj);
            sw.Write(objetoSer);
            sw.Close();

        }
        public static T Deserializar<T>()
        {
            StreamReader sr = new StreamReader(@"C:\Users\fabio\OneDrive\Documentos\Cursos\Udemy\C-Sharp-Avancado-EliasRibeiro\C-Sharp-Avancado\02-Generics\01_" + typeof(T).Name + ".txt");
            string conteudo = sr.ReadToEnd();
            JavaScriptSerializer serializador = new JavaScriptSerializer();
            T obj = (T)serializador.Deserialize(conteudo, typeof(T));

            return obj;

        }


    }
}
