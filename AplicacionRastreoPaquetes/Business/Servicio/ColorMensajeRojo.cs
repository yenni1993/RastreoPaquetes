using AplicacionRastreoPaquetes.Business.Interface;
using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ColorMensajeRojo : IColorMensaje
    {
        public void ColorearMensaje(string _cMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_cMensaje, Console.ForegroundColor);
        }
    }
}
