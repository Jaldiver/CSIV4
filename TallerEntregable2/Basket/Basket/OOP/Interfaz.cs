using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Basket.OOP{
    public interface IEquipo
    {
    string NombreE { get; }
        void AgregarJugador(Jugador jugador);
        int CalcularR();
    }
}