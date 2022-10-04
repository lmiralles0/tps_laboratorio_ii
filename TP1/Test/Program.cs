using Persona;
using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin(37882165,"Luciano", "Miralles");
            Console.WriteLine(admin.Apellido + " " + admin.Dni + " " + admin.Nombre);
            Console.ReadKey();
        }
    }
}
