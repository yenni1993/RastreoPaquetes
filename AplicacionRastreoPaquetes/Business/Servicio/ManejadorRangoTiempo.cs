using System;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase abstracta que permite manejar el rango del tiempo y que implementa de la interface IManejadorRangoTiempo.
    /// </summary>
    public abstract class ManejadorRangoTiempo : IManejadorRangoTiempo
    {
        public virtual string cArchivo { get; set; }

        private IManejadorRangoTiempo IManejadorSiguiente;

        /// <summary>
        /// Método que permite asignar el siguiente rango de tiempo.
        /// </summary>
        /// <param name="_IManejadorSiguienteRangoTiempo">Interface del manejador siguiente del rango del tiempo.</param>
        /// <returns>Interface del manejador del rango del tiempo siguiente.</returns>
        public IManejadorRangoTiempo AsignarSiguienteRangoTiempo(IManejadorRangoTiempo _IManejadorTiempo)
        {
            return this.IManejadorSiguiente = _IManejadorTiempo;
        }

        /// <summary>
        /// Método que permite obtener el rango del tiempo.
        /// </summary>
        /// <param name="_tsDiferenciaFecha">Diferencia que existe entre una fecha u otra.</param>
        /// <returns>Duración y nombre del formato de fechas del rango del tiempo. Ejemplo: 1 mes.</returns>
        public virtual string ObtenerRangoTiempo(TimeSpan _tsDiferenciaFecha)
        {
            string cRangoTiempo = string.Empty;

            if(this.IManejadorSiguiente != null)
            {
                cRangoTiempo = this.IManejadorSiguiente.ObtenerRangoTiempo(_tsDiferenciaFecha);
            }

            return cRangoTiempo;
        }
    }
}
