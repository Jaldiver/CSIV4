Calculadora c1 = new Calculadora(10, 20);
Calculadora c2 = new Calculadora(20, 15);
Console.WriteLine(c1.suma());
c2.resta();

List<Calculadora> lista_calculadora = new List<Calculadora>();

lista_calculadora.Add(c1);

foreach (Calculadora c in lista_calculadora){
    Console.WriteLine(c1.suma);
}

class Calculadora : iCalculadora{
    private int a {get; set;}
    private int b {get; set;}

    public Calculadora(int n1, int n2){
        this.a = n1;
        this.b = n2;
    }

    public int suma(){
        return this.a + this.b;
    }

    public static void resta(){
        Console.WriteLine(this.a - this.b);
    }
}

public interface iCalculadora {
    public int suma();
}

public class Estudiante{

}

public class Curso{
    private List<Estudiante> estudiante = new List<Estudiante>

    public void addEstudiante(Estudiante estudiante){
        this.estudiante.Add(estudiante);
    }

    public void imprimirEstudiante(){
        foreach()
    }
}
