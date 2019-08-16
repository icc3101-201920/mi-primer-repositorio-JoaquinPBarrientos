using System;

namespace ProyectoPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Persona1 = new Persona(23, "Juan");
            Persona1.Greet();
            Jugador Jugador1 = new Jugador("Pepe", 24, "Delantero", 10);
            Jugador1.Greet();
            Console.WriteLine(Persona1.Edad);
            Console.WriteLine(Jugador1.Nombre);



        }
    }
}
