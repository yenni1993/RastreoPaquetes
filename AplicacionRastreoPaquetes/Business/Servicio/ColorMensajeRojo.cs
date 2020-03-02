using AplicacionRastreoPaquetes.Business.Interface;
using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite colorear el mensaje en rojo y que implementa de la interface IColorMensaje.
    /// </summary>
    public class ColorMensajeRojo : IColorMensaje
    {
        /// <summary>
        /// Método que permite colorear el mensaje que se muestra en el sistema.
        /// </summary>
        /// <param name="_cMensaje">Texto del mensaje que se va a colorear.</param>
        public void ColorearMensaje(string _cMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_cMensaje, Console.ForegroundColor);
        }
    }
}
