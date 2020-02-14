using System;
using _01_Generics.Modelo;

namespace _01_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro() { Marca = "FIAT", Modelo = "UNO" };
            Casa casa = new Casa() { Cidade = "Brasilia", Endereco = "QSQ-400" };
            Usuario usuario = new Usuario() { Nome = "Maria Clara", Email = "Maria", Senha = "123" };


            Serealizador.Serializar(carro);
            Serealizador.Serializar(casa);
            Serealizador.Serializar(usuario);

            Carro carro2 = Serealizador.Deserializar<Carro>();
            Casa casa2 = Serealizador.Deserializar<Casa>();
            Usuario usuario2 = Serealizador.Deserializar<Usuario>();

            Console.WriteLine("Carro2: {0} - {1}", carro2.Marca, carro2.Modelo);
            Console.WriteLine("Casa2: {0} - {1}", casa2.Cidade, casa2.Endereco);
            Console.WriteLine("Usuario2: {0} - {1}", usuario2.Nome, usuario2.Email);

            Console.ReadKey();
        }
    }
}
