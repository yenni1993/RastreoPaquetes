using AplicacionRastreoPaquetes.Business.Interface;
using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ColorMensajeAmarillo : IColorMensaje
    {
        public void ColorearMensaje(string _cMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(_cMensaje, Console.ForegroundColor);
        }
    }
}
