using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Basket.OOP{

    public class Jugador{
        public string Nombre { get; set;}
        public int Rendimiento { get; set;}

        public Jugador (string Nombre, int Rendimiento){
            this.Nombre = Nombre;
            this.Rendimiento= Rendimiento;
        }

    }

}