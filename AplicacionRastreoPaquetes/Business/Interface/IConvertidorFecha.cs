using System;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    /// <summary>
    /// Interface que permite convertir la fecha.
    /// </summary>
    public interface IConvertidorFecha
    {
        /// <summary>
        /// Método que permite convertir la fecha de string a DateTime.
        /// </summary>
        /// <param name="_cFecha">Fecha como cadena de texto.</param>
        /// <returns>Fecha convertida.</returns>
        DateTime ConvertirFecha(string _cFecha);
    }
}
