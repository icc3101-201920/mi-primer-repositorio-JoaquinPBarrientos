using System;
namespace ProyectoPrueba
{
    public class Persona
    {
        private int edad;
        protected string nombre;
        

        public Persona(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

       public int Edad
        {
            get => edad;
            set => edad = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public virtual void Greet()
        {
            Console.WriteLine("Hola soy " + nombre);
        }

    }

}
