using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    /// <summary>
    /// Interface que permite leer un archivo.
    /// </summary>
    public interface ILectorArchivo
    {
        /// <summary>
        /// Método que permite leer el contenido de un archivo dada la ruta especificada.
        /// </summary>
        /// <param name="_cRuta">Ruta donde se encuentra el archivo.</param>
        /// <returns>Lista con el contenido del archivo.</returns>
        List<string> LeerContenidoArchivo(string _cRuta);
    }
}
