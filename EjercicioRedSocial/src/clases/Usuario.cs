namespace EjercicioRedSocial.src.clases;

using EjercicioRedSocial.src.interfaces;

public interface Usuario:IUsuario {

    private string nombres {get; set;}
    private string apellidos {get; set;}
    private string correo {get; set;}
    private List<IUsuario> amigos = new List<IUsuario>();
    private List<IUsuario> mnsj = new List<IUsuario>();

    public Usuario(string nombres, string apellidos, string correo){
        this.nombres = nombres;
        this.correo = correo;
        this.apellidos = apellidos;
    }

    public string nombreCompleto(){
        return this.nombres + " " + this.apellidos;
    }

    public void agregarAmigo(IUsuario amigo){
        this.amigos.Add(amigo);
    }

    public void enviarMensaje(IUsuario amigo, string mensaje){
        Console.WriteLine(this.nombreCompleto() + " se envia a " + amigo.nombreCompleto() + ": " + mensaje);
        amigo.mnsj.Add(mensaje);
    }

}