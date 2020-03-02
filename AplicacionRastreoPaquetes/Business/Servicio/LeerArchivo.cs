using AplicacionRastreoPaquetes.Business.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite leer un archivo y que implementa de la interface ILectorArchivo.
    /// </summary>
    public class LeerArchivo : ILectorArchivo
    {
        /// <summary>
        /// Método que permite leer el contenido de un archivo dada la ruta especificada.
        /// </summary>
        /// <param name="_cRuta">Ruta donde se encuentra el archivo.</param>
        /// <returns>Lista con el contenido del archivo.</returns>
        public List<string> LeerContenidoArchivo(string _cRuta)
        {
            List<string> lstLineaArchivo = new List<string>();

            try
            {
                StreamReader stArchivo = new StreamReader(File.OpenRead(_cRuta), Encoding.Default);

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
