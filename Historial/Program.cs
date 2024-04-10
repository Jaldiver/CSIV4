
/*
bool Ciclo = false;
bool Ciclo2 = false;
int Var1=0, Var2=0, Opc=0, Opc2=0;
int HstVar1=0, HstVar2=0, HstVar3=0;
string HstOp="";

do{
    Console.WriteLine("Porfavor digite el numero de la opcion que desea ejecutar");
    Console.WriteLine("1. Operacion");
    Console.WriteLine("2. Historial");
    Console.WriteLine("3. Salir");  


    int.TryParse(Console.ReadLine(),out Opc);
    switch (Opc){
        case 1:
            Console.WriteLine("Desea que el sistema haga una resta o suma?");
            do{
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Volver");
            int.TryParse(Console.ReadLine(),out Opc2);
            switch (Opc2){
                case 1:
                    Ciclo2=true;
                    HstOp="+";
                    Console.WriteLine("Digite el primer valor");
                    Var1= int.Parse(Console.ReadLine());
                    Console.WriteLine("Ahora el segundo valor");
                    Var2= int.Parse(Console.ReadLine());
                    Console.WriteLine("El resultado de la suma es: " + (Var1+Var2));
                    HstVar1=Var1;
                    HstVar2=Var2;
                    HstVar3=(Var1+Var2);
                break;
                case 2:
                    Ciclo2=true;
                    HstOp="-";
                    Console.WriteLine("Digite el primer valor");
                    Var1= int.Parse(Console.ReadLine());
                    Console.WriteLine("Ahora el segundo valor");
                    Var2= int.Parse(Console.ReadLine());
                    Console.WriteLine("El resultado de la resta es: " + (Var1-Var2));
                    HstVar1=Var1;
                    HstVar2=Var2;
                    HstVar3=(Var1-Var2);
                break;
                case 3:
                    Ciclo2=true;
                break;
                default:
                Console.WriteLine("Opcion fuera de rango");
                break;
            }
            }while (Ciclo2==false);
        break;
        case 2:
            Console.WriteLine("La ultima operacion realizada fue: " + HstVar1 + HstOp + HstVar2 + "=" + HstVar3);
        break;
        case 3:
        Ciclo=true;
        break;
        default:
        Console.WriteLine("Opcion fuera de rango");
        break;
        }
}while (Ciclo==false);
*/

Console.WriteLine("Digite el precio del producto");
float Prec = float.Parse(Console.ReadLine());
Console.WriteLine("Digite la categoria del producto");
bool Ciclo=false;
int Opc=0;
float Dsc;
do{
    Console.WriteLine("Digite la categoria del producto");
    Console.WriteLine("1. Lacteos (10%)");
    Console.WriteLine("2. Equipo deportivo (20%)");
    Console.WriteLine("3. Agricultura (25%)");
    Console.WriteLine("4. Materiales escolares (15%)");
    Console.WriteLine("5. Utencilios de cocina (20%)");
    int.TryParse(Console.ReadLine(),out Opc);
    switch(Opc){
        case 1:
        Ciclo=true;
        Dsc=(0.9);
        break;
        case 2:
        Dsc=(0.8);
        Ciclo=true;
        break;
        case 3:
        Dsc=(0.75);
        Ciclo=true;
        break;
        case 4:
        Dsc=(0.85);
        Ciclo=true;
        break;
        case 5:
        Dsc=(0.8);
        Ciclo=true;
        break;
        default:
        Console.WriteLine("Opcion fuera de rango");
        break;
    }
}while(Ciclo==false);

Console.WriteLine("El valor total del producto al aplicar el descuento es de:  " + (Prec*Dsc));