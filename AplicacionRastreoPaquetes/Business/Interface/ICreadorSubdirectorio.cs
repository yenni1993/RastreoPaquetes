using System.IO;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    public interface ICreadorSubdirectorio
    {
        DirectoryInfo CrearSubdDirectorio(DirectoryInfo _directorio, string _cNombre);
    }
}
