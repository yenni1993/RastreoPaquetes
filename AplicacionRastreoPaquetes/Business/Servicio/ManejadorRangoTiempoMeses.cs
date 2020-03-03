using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite manejar el rango del tiempo en meses y que implementa de la interface ManejadorRangoTiempo.
    /// </summary>
    public class ManejadorRangoTiempoMeses : ManejadorRangoTiempo
    {
        private string _cArchivo = "Meses.txt";

        public override string cArchivo { get { return _cArchivo; } set { base.cArchivo = value; } }

        /// <summary>
        /// Método sobreescrito que permite obtener el rango del tiempo en meses.
        /// </summary>
        /// <param name="_tsDiferenciaFecha">Diferencia que existe entre una fecha u otra.</param>
        /// <returns>Duración y nombre del formato de fechas del rango del tiempo. Ejemplo: 1 mes.</returns>
        public override string ObtenerRangoTiempo(TimeSpan _tsDiferenciaFecha)
        {
            int iTotalMeses = 0;
            int iTotalDias = 0;
            string cNombreFormatoHora = string.Empty;
            string cRangoTiempo = string.Empty;

            iTotalDias = Math.Abs(_tsDiferenciaFecha.Days);

            if (iTotalDias > 30)
            {
                iTotalMeses = iTotalDias / 30;
                cNombreFormatoHora = iTotalMeses == 1 ? "mes" : "meses";
                cRangoTiempo = $"{iTotalMeses} {cNombreFormatoHora}";
            }
            else
            {
                cRangoTiempo = base.ObtenerRangoTiempo(_tsDiferenciaFecha);
            }

            return cRangoTiempo;
        }
    }
}
