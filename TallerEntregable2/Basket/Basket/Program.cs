using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Microsoft.VisualBasic;


namespace Basket.OOP{

    public class Program{

        static void Main(string[] args){
            Equipo equipoazul = new Equipo("Equipo Azul");
            Equipo equiporojo = new Equipo("Equipo Rojo");


            List<Jugador> jugadores = new List<Jugador>();
            jugadores.Add(new Jugador("Jugador 1", new Random().Next(1, 10)));
            jugadores.Add(new Jugador("Jugador 2", new Random().Next(1, 10)));
            jugadores.Add(new Jugador("Jugador 3", new Random().Next(1, 10)));
            jugadores.Add(new Jugador("Jugador 4", new Random().Next(1, 10)));
            jugadores.Add(new Jugador("Jugador 5", new Random().Next(1, 10)));
            jugadores.Add(new Jugador("Jugador 6", new Random().Next(1, 10)));

                for (int i = 0; i<3; i++){
                int aleatorio = new Random().Next(jugadores.Count);

                equipoazul.AgregarJugador(jugadores[aleatorio]);
                jugadores.RemoveAt(aleatorio);

                aleatorio = new Random().Next(jugadores.Count);

                equiporojo.AgregarJugador(jugadores[aleatorio]);
                jugadores.RemoveAt(aleatorio);
                }

                equipoazul.MostrarJugadores();
                Console.WriteLine();
                equiporojo.MostrarJugadores();
                Console.WriteLine();

                 int REquipoRojo = equiporojo.CalcularR();
                 int REquipoAzul = equipoazul.CalcularR();

                if (REquipoRojo>REquipoAzul){
                    Console.WriteLine("El ganador del partido es el equipo rojo con un rendimiento de " + REquipoRojo);
                }
                else if (REquipoAzul>REquipoRojo){
                    Console.WriteLine("El ganador del partido es el equipo azul con un rendimiento de " + REquipoAzul);
                }
                else{
                        Console.WriteLine("Empate");
                }
        }
    }

}
