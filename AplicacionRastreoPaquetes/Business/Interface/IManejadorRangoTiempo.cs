using System;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    /// <summary>
    /// Interface que permite manejar el rango del tiempo.
    /// </summary>
    public interface IManejadorRangoTiempo
    {
        /// <summary>
        /// Método que permite asignar el siguiente rango de tiempo.
        /// </summary>
        /// <param name="_IManejadorSiguienteRangoTiempo">Interface del manejador siguiente del rango del tiempo.</param>
        /// <returns>Interface del manejador del rango del tiempo siguiente.</returns>
        IManejadorRangoTiempo AsignarSiguienteRangoTiempo(IManejadorRangoTiempo _IManejadorSiguienteRangoTiempo);

        /// <summary>
        /// Método que permite obtener el rango del tiempo.
        /// </summary>
        /// <param name="_tsDiferenciaFecha">Diferencia que existe entre una fecha u otra.</param>
        /// <returns>Duración y nombre del formato de fechas del rango del tiempo. Ejemplo: 1 mes.</returns>
        string ObtenerRangoTiempo(TimeSpan _tsDiferenciaFecha);
    }
}
