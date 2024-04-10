bool Ciclo = false;
int[] edades = new int[5];
string[] nombres = new string[3];
int[] numeros = new int[5];
int[] valores = new int[5];
while (Ciclo==false){
Console.WriteLine("Bienvenido, porfavor digite la opcion que desea ejecutar");
Console.WriteLine("1. Llenar edades con numeros random");
Console.WriteLine("2. Escribir y llamar nombres con funcion");
Console.WriteLine("3. Crear una lista de numeros, imprimirlos y mostrar el segundo valor mas alto");
Console.WriteLine("4. Crear un vector y eliminar los numeros repetidos");
    int Opt = int.Parse(Console.ReadLine());
    switch(Opt)
    {
        case 1:
        cargarVector(edades);
    break;
        case 2:
        for (int i = 0; i < nombres.Length ; i++){
            nombres[i]=Console.ReadLine();
        }
        names(nombres);
    break;
        case 3:
        numeros = cargarVector(numeros);
        int mayor = 0;
        int segundo_mayor = 0;
        for (int i = 0; i < numeros.Length ; i++){
            Console.WriteLine(numeros[i]);
            if(mayor < numeros[i]){
                segundo_mayor = mayor;
                mayor = numeros[i];
            }else if ( segundo_mayor < numeros[i] && numeros[i] != mayor){
                segundo_mayor = numeros[i];
            }
        }
        Console.WriteLine("El numero mayor es: " + mayor);
        Console.WriteLine("El segundo numero mayor es: " + segundo_mayor);
    break;
        case 4:
        numeros = cargarVector(numeros);
        int comparador = 0;
        for (int i = 0; i < numeros.Length ; i++){
            comparador = numeros[i];
            int pos = i;
            for (int x = 0; x < numeros.Length ; x++){
                if (comparador==numeros[x] && pos != x){
                    numeros[x] = -5;
                }
            }
        }
        for (int y = 0; y < numeros.Length ; y++){
            Console.WriteLine("N°" + (y+1) + ": " + numeros[y]);
        }
    break;
        default:
    Ciclo=true;
    break;
}
}

string[] names(string[] Lista){
    for (int i = 0; i < Lista.Length ; i++){
        Console.WriteLine("Nombre n°" + (i+1) + ": " + Lista[i]);
    }
    return Lista;
}

int[] cargarVector(int[] vector){
    Random random = new Random();
    for (int i = 0; i < vector.Length; i++){
    vector[i] = random.Next(1, 90);
    Console.WriteLine("Numero " + (i+1) + ": " + vector[i]);
    }
    return vector;
}
