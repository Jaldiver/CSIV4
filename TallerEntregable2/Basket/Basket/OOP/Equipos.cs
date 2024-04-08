using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Basket.OOP{
class Equipo : IEquipo
    {
        public string nombreEquipo;
        public List<Jugador> jugadores = new List<Jugador>();


        public Equipo(string nombre)
        {
            this.nombreEquipo = nombre;
        }
        public string NombreE { get { return nombreEquipo; } }
        public void AgregarJugador(Jugador jugador)
        {
            jugadores.Add(jugador);
        }

        public int CalcularR()
        {
            int total = 0;
            foreach (Jugador jugador in jugadores)
            {
                total += jugador.Rendimiento;
            }
            return total;
        }

        public void MostrarJugadores(){
            foreach (Jugador jugador in jugadores){
                Console.WriteLine("Nombre Jugador: " + jugador.Nombre, "Rendimiento: " + jugador.Rendimiento);
            }
        }
}

}