using AplicacionRastreoPaquetes.Business.Interface;
using System;
using System.Collections.Generic;
using System.IO;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class LeerArchivo : ILectorArchivo
    {
        public List<string> LeerContenidoArchivo(string _cRuta)
        {
            List<string> lstLineaArchivo = new List<string>();

            try
            {
                StreamReader stArchivo = new StreamReader(File.OpenRead(_cRuta));

                while (!stArchivo.EndOfStream)
                {
                    string cLineaArchivo = stArchivo.ReadLine();
                    lstLineaArchivo.Add(cLineaArchivo);
                }
            }
            catch
            {
                Console.WriteLine("ERROR: La ruta del archivo es incorrecta.");
            }

            return lstLineaArchivo;
        }
    }
}
