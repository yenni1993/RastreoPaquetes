using AplicacionRastreoPaquetes.Business.Interface;
using System;
using System.Collections.Generic;
using System.IO;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class CreadorArchivo : ICreadorArchivo
    {
        public List<string> lstArchivo { get; set; }

        public void CrearArchivo(DirectoryInfo _directorio)
        {
            string cExtension = string.Empty;
            string cRutaDirectorio = string.Empty;
            string cRutaArchivo = string.Empty;

            foreach (string cNombre in lstArchivo)
            {
                cExtension = Path.GetExtension(cNombre);

                if (!string.IsNullOrWhiteSpace(cExtension))
                {
                    cRutaDirectorio = _directorio.FullName;
                    cRutaArchivo = Path.Combine(cRutaDirectorio, cNombre);

                    if (!File.Exists(cRutaArchivo))
                    {
                        File.Create(cRutaArchivo);
                    }
                }
                else
                {
                    Console.WriteLine($"La extensión del archivo {cNombre} es incorrecta");
                }
            }
        }
    }
}
