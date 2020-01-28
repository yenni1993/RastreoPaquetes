using AplicacionRastreoPaquetes.Business.Servicio;
using System;
using System.Collections.Generic;
using System.IO;

namespace AplicacionRastreoPaquetes
{
    /// <summary>
    /// Clase Program del sistema.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente oCliente = new Cliente();
            string cRuta = string.Empty;
            List<string> lstContenidoArchivo = new List<string>();
            cRuta = Path.GetFullPath("RastreoPaquete.csv");
            lstContenidoArchivo = oCliente.LeerArchivo(cRuta);
            oCliente.AplicarRastreoPaquete(lstContenidoArchivo);
            Console.ReadLine();
        }
    }
}
