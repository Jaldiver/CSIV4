int[] numeros_aleatorios = new int[50];
List<int> numeros_unicos = new List<int>();
bool es_repetido = false;
bool flag = false;
Dictionary<int, int> frecuencia = new Dictionary<int, int>();

numeros_aleatorios = cargarVector(numeros_aleatorios);

numeros_unicos.Add(numeros_aleatorios[0]);
frecuencia.Add(numeros_aleatorios[0], 1);

for (int i = 1; i < numeros_aleatorios.Length; i++){
    foreach(int numb in numeros_unicos){
        if (numeros_aleatorios[i] == numb){
            es_repetido = true;
            if(frecuencia.ContainsKey(numb)){
            frecuencia[numb] += 1;
                }else{
                    frecuencia.Add(numb, 1);
                }
            }
    }
    if (es_repetido == false){
        numeros_unicos.Add(numeros_aleatorios[i]);
        }
        es_repetido=false;
}

Console.WriteLine("Numeros repetidos:");

numeros_unicos = LeerLista(numeros_unicos);

Console.WriteLine("Los numeros se repitieron esta cantidad de veces:");

foreach(KeyValuePair<int, int> pair in frecuencia){
    Console.WriteLine("{0} se repite {1} veces.", pair.Key, pair.Value);
}


int[] cargarVector(int[] vector){
    Random random = new Random();
    for (int i = 0; i < vector.Length; i++){
    vector[i] = random.Next(1, 20);
    Console.WriteLine("Numero " + (i+1) + ": " + vector[i]);
    }
    return vector;
}

List<int> LeerLista(List<int> lista){
    foreach(int numb in lista){
    Console.WriteLine(numb);
    }
    return lista;
}

List<int> detectarRepetido(List<int> lista, int[] vector, Dictionary<int, int> diccionario){

    return lista;
}