using Newtonsoft.Json;
using Proyecto_Marketplace.clases;

public class RepositorioPublicaciones
{
    private string rutaArchivo = Path.Combine(Application.StartupPath, "publicaciones.json");

    public List<Publicacion> Publicaciones { get; private set; } = new List<Publicacion>();

    public void AgregarPublicacion(Publicacion pub)
    {
        Publicaciones.Add(pub);
        GuardarPublicaciones();
    }

    public void GuardarPublicaciones()
    {
        var json = JsonConvert.SerializeObject(Publicaciones, Formatting.Indented);
        File.WriteAllText(rutaArchivo, json);
    }

    public void CargarPublicaciones()
    {
        if (File.Exists(rutaArchivo))
        {
            var json = File.ReadAllText(rutaArchivo);
            Publicaciones = JsonConvert.DeserializeObject<List<Publicacion>>(json) ?? new List<Publicacion>();
        }
    }


 public void EliminarPublicacion(Publicacion pub)
 {
     // Usamos Titulo y Creador como ID único temporal
     var publicacion = Publicaciones.FirstOrDefault(p =>
     p.Titulo == pub.Titulo && p.UsuarioCreador == pub.UsuarioCreador);
     if (publicacion != null)
     {
         Publicaciones.Remove(publicacion);
         GuardarPublicaciones();
     }
 }

 public void AprobarPublicacion(Publicacion pub)
 {
     var publicacion = Publicaciones.FirstOrDefault(p =>
     p.Titulo == pub.Titulo && p.UsuarioCreador == pub.UsuarioCreador);
     if (publicacion != null)
         {
            publicacion.EstadoModeracion = "Aprobado";
            GuardarPublicaciones();
         }
     }
 
}