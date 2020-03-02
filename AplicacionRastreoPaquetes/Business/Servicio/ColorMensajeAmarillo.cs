using AplicacionRastreoPaquetes.Business.Interface;
using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite colorear el mensaje en amarillo y que implementa de la interface IColorMensaje.
    /// </summary>
    public class ColorMensajeAmarillo : IColorMensaje
    {
        /// <summary>
        /// Método que permite colorear el mensaje que se muestra en el sistema.
        /// </summary>
        /// <param name="_cMensaje">Texto del mensaje que se va a colorear.</param>
        public void ColorearMensaje(string _cMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(_cMensaje, Console.ForegroundColor);
        }
    }
}
