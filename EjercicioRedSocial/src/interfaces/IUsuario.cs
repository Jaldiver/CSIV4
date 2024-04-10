namespace EjercicioRedSocial.src.interfaces;

public interface IUsuario {

    public string nombreCompleto();
    public void agregarAmigo(IUsuario amigo);
    public void enviarMensaje(IUsuario amigo, string mensaje);

}