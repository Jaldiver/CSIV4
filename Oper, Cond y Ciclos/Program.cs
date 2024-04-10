/*
float Val1 = 10;
float Val2 = 20;
float Res = (Val1+Val2)/2;
Console.WriteLine(Res);
*/

/*
int Val = int.Parse(Console.ReadLine());

int Und = (Val % 10);

int Dec = (Val % 100) - Und;

int Cent = Val - (Und+Dec);

Console.WriteLine("Centena: " + Cent);
Console.WriteLine("Decena: " + Dec);
Console.WriteLine("Unidad: " + Und);

int Total = ((Cent/100)+(Dec/10)+Und);

Console.WriteLine("La suma de los valores es de: " + Total);
*/

/*
int Num = int.Parse(Console.ReadLine());

bool Prim = true;

for (int Div = 2; Div < (Num/2); Div++)
{
     if((Num % Div) == 0){
        Prim=false;
     }
}

if(Prim==true && Num > 1 ) {
    Console.WriteLine("Primo");
}else{
    Console.WriteLine("No primo");
}
*/

/*
int Lad1 = int.Parse(Console.ReadLine());
int Lad2 = int.Parse(Console.ReadLine());

if (Lad1==90 && Lad2 == 90){
    Console.WriteLine("Es equilatero");
} else if (Lad1 == Lad2 && Lad1 != 90){
    Console.WriteLine("Es isosceles");
} else {
    Console.WriteLine("Es escaleno");
}
*/