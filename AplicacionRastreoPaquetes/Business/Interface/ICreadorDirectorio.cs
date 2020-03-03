using System.IO;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    public interface ICreadorDirectorio
    {
        DirectoryInfo CrearDirectorio(string _cNombre);
    }
}
