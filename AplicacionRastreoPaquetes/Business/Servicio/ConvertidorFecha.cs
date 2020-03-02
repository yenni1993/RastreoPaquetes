using System;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que convierte la fecha y que implementa de la interface IConvertidorFecha.
    /// </summary>
    public class ConvertidorFecha : IConvertidorFecha
    {
        /// <summary>
        /// Método que permite convertir la fecha de string a DateTime.
        /// </summary>
        /// <param name="_cFecha">Fecha como cadena de texto.</param>
        /// <returns>Fecha convertida.</returns>
        DateTime IConvertidorFecha.ConvertirFecha(string _cFecha)
        {
            DateTime dtFecha = new DateTime();
            dtFecha = Convert.ToDateTime(_cFecha);
            return dtFecha;
        }
    }
}
