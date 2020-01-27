using AplicacionRastreoPaquetes.Business.Interface;
using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ColorMensajeVerde : IColorMensaje
    {
        public void ColorearMensaje(string _cMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_cMensaje, Console.ForegroundColor);
        }
    }
}
