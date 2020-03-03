using System;
using System.IO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class EscrituraArchivo : IEscrituraArchivo
    {
        public void EscribirAchivo(DirectoryInfo _directorio, string _cTexto)
        {
            //string cRutaDirectorio = _directorio.FullName;
            //StreamWriter stWriter = new StreamWriter(cRutaDirectorio);
            //stWriter.WriteLine(_cTexto);
        }
    }
}
