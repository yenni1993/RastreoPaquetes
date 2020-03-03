using System;
using System.IO;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    public interface IEscrituraArchivo
    {
        void EscribirAchivo(DirectoryInfo _directorio, string _cTexto);
    }
}
