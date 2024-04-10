using EjercicioRedSocial.src.interfaces;
using EjercicioRedSocial.src.clases;

Usuario = usuario_uno = new Usuario("Juan", "Carlos", "juan.bodoque@correo.com");

Usuario = usuario_dos = new Usuario("Tulio", "Cesar", "tulio.cesar@correo.com");

usuario_uno.agregarAmigo(usuario_dos);

usuario_uno.enviarMensaje(usuario_dos, "Hola que tal");