using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite manejar el rango del tiempo en minutos y que implementa de la interface ManejadorRangoTiempo.
    /// </summary>
    public class ManejadorRangoTiempoMinutos : ManejadorRangoTiempo
    {
        /// <summary>
        /// Método sobreescrito que permite obtener el rango del tiempo en minutos.
        /// </summary>
        /// <param name="_tsDiferenciaFecha">Diferencia que existe entre una fecha u otra.</param>
        /// <returns>Duración y nombre del formato de fechas del rango del tiempo. Ejemplo: 1 minuto.</returns>
        public override string ObtenerRangoTiempo(TimeSpan _tsDiferenciaFecha)
        {
            int iTotalMinutos = 0;
            string cNombreFormatoHora = string.Empty;
            string cRangoTiempo = string.Empty;

            iTotalMinutos = Math.Abs(_tsDiferenciaFecha.Minutes);
            cNombreFormatoHora = iTotalMinutos == 1 ? "minuto" : "minutos";
            cRangoTiempo = $"{iTotalMinutos} {cNombreFormatoHora}";

            return cRangoTiempo;
        }
    }
}
