// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string Nombre="Jaldiver Posada";
int Edad=18;
float Estatura=1.72f;
bool Genero=false;
string Gen;
if(Genero==false){
    Gen="masculino";
}else{
    Gen="Femenino";
}

Console.WriteLine("Hola, soy " + Nombre + ", tengo " + Edad + " años, mido " + Estatura + "m y mi genero es " +  Gen);

Console.WriteLine("Dime el radio de un circulo y te dire su area");

float Pi=3.14f;
int Radio=int.Parse(Console.ReadLine());
double Area= Pi*(Radio*Radio);

Console.WriteLine("El area del circulo con un radio de " + Radio + " y su area es de :" + Area);


Console.WriteLine("Cual era mi apellido?");
string Apellido = Console.ReadLine();
if(Apellido=="Posada"){
Console.WriteLine("Correcto!");
}else{
Console.WriteLine("Incorrecto, mi apellido es Posada");
}
