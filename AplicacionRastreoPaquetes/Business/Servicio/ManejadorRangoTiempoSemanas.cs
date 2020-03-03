using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite manejar el rango del tiempo en semanas y que implementa de la interface ManejadorRangoTiempo.
    /// </summary>
    public class ManejadorRangoTiempoSemanas : ManejadorRangoTiempo
    {
        private string _cArchivo = "Semanas.txt";

        public override string cArchivo { get { return _cArchivo; } set { base.cArchivo = value; } }

        /// <summary>
        /// Método sobreescrito que permite obtener el rango del tiempo en semanas.
        /// </summary>
        /// <param name="_tsDiferenciaFecha">Diferencia que existe entre una fecha u otra.</param>
        /// <returns>Duración y nombre del formato de fechas del rango del tiempo. Ejemplo: 1 semana.</returns>
        public override string ObtenerRangoTiempo(TimeSpan _tsDiferenciaFecha)
        {
            int iTotalDias = 0;
            string cNombreFormatoHora = string.Empty;
            string cRangoTiempo = string.Empty;

            iTotalDias = Math.Abs(_tsDiferenciaFecha.Days);

            if (iTotalDias > 6)
            {
                cNombreFormatoHora = iTotalDias == 7 ? "semana" : "semanas";
                cRangoTiempo = $"{iTotalDias} {cNombreFormatoHora}";
            }
            else
            {
                cRangoTiempo = base.ObtenerRangoTiempo(_tsDiferenciaFecha);
            }

            return cRangoTiempo;
        }
    }
}
