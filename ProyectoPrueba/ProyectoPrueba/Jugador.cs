using System;

namespace ProyectoPrueba
{
    public class Jugador : Persona
    {
        private string posicion;
        private int numeroDorsal;

        public Jugador(string nombre,int edad, string posicion,int numeroDorsal) : base(edad,nombre)
        {
            this.posicion = posicion;
            this.numeroDorsal = numeroDorsal;
        }

        public string Posicion
        {
            get => posicion;
            set => posicion = value;
        }

        public int NumeroDorsal
        {
            get => numeroDorsal;
            set => numeroDorsal = value;
        }

        public override void Greet()
        {
            base.Greet();
            Console.WriteLine("Soy un jugador de futbol y juego de " + posicion);
        }
    }
}
