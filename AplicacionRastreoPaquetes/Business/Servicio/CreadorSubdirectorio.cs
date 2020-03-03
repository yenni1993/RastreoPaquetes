using AplicacionRastreoPaquetes.Business.Interface;
using System.IO;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class CreadorSubdirectorio : ICreadorSubdirectorio
    {
        public DirectoryInfo CrearSubdDirectorio(DirectoryInfo _directorio, string _cNombre)
        {
            string cRutaDirectorio = _directorio.FullName;
            string cRutaSubdirectorio = Path.Combine(cRutaDirectorio, _cNombre);

            DirectoryInfo subdirectorio = new DirectoryInfo(cRutaSubdirectorio);

            if (!subdirectorio.Exists)
            {
                subdirectorio.Create();
            }

            return subdirectorio;
        }
    }
}
