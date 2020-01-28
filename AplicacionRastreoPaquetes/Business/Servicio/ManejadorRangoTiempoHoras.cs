using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite manejar el rango del tiempo en horas y que implementa de la interface ManejadorRangoTiempo.
    /// </summary>
    public class ManejadorRangoTiempoHoras : ManejadorRangoTiempo
    {
        /// <summary>
        /// Método sobreescrito que permite obtener el rango del tiempo en horas.
        /// </summary>
        /// <param name="_tsDiferenciaFecha">Diferencia que existe entre una fecha u otra.</param>
        /// <returns>Duración y nombre del formato de fechas del rango del tiempo. Ejemplo: 1 hora.</returns>
        public override string ObtenerRangoTiempo(TimeSpan _tsDiferenciaFecha)
        {
            int iTotalHoras = 0;
            string cNombreFormatoHora = string.Empty;
            string cRangoTiempo = string.Empty;

            iTotalHoras = Math.Abs(_tsDiferenciaFecha.Hours);

            if (iTotalHoras > 0)
            {
                cNombreFormatoHora = iTotalHoras == 1 ? "hora" : "horas";
                cRangoTiempo = $"{iTotalHoras} {cNombreFormatoHora}";
            }
            else
            {
                cRangoTiempo = base.ObtenerRangoTiempo(_tsDiferenciaFecha);
            }

            return cRangoTiempo;
        }
    }
}
