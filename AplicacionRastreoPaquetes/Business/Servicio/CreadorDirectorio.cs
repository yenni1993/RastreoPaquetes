using AplicacionRastreoPaquetes.Business.Interface;
using System.IO;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class CreadorDirectorio : ICreadorDirectorio
    {
        public DirectoryInfo CrearDirectorio(string _cNombre)
        {
            string cRutaPrincipal = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string cRutaDirectorio = Path.Combine(cRutaPrincipal, "bin", "Debug", _cNombre);

            DirectoryInfo directorio = new DirectoryInfo(cRutaDirectorio);

            if (!directorio.Exists)
            {
                directorio.Create();
            }

            return directorio;
        }
    }
}
