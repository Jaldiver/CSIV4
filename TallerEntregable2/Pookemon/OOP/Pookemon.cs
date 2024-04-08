using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Pookemon.OOP{

    public class Pookemon{
        public string Nombre { get; set;}
        public string Tipo { get; set;}
        public int HP { get; set;}
        public int Atk1 { get; set;}
        public int Atk2 { get; set;}
        public int Atk3 { get; set;}
        public int Def1 { get; set;}
        public int Def2 { get; set;}

        public pookemon (string Nombre, int Tipo){
            this.Nombre = Nombre;
            this.Tipo = Tipo;
            this.HP = 150;
            this.Atk1 = new Random().Next(0-40);
            this.Atk2 = new Random().Next(0-40);
            this.Atk3 = new Random().Next(0-40);
            this.Def1 = new Random().Next(10-35);
            this.Def2 = new Random().Next(10-35);
        }
        
        public void pDatos(){
            Console.WriteLine("Nombre: " + this.Nombre);
            Console.WriteLine("Tipo: " + this.Tipo);
            Console.WriteLine("-------------Ataques-------------");
            Console.WriteLine("Poder Atk1: " + this.Atk1);
            Console.WriteLine("Poder Atk2: " + this.Atk2);
            Console.WriteLine("Poder Atk3: " + this.Atk3);
            Console.WriteLine("-------------Defensas------------");
            Console.WriteLine("Poder Def1: " + this.Def1);
            Console.WriteLine("Poder Def2: " + this.Def2);
        }

    }

}