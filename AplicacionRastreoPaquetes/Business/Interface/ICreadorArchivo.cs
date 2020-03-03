using System.Collections.Generic;
using System.IO;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    public interface ICreadorArchivo
    {
        List<string> lstArchivo { get; set; }

        void CrearArchivo(DirectoryInfo _directorio);
    }
}
