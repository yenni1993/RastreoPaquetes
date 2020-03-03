using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite manejar el rango del tiempo en bimestres y que implementa de la interface ManejadorRangoTiempo.
    /// </summary>
    public class ManejadorRangoTiempoBimestres : ManejadorRangoTiempo
    {
        private string _cArchivo = "Bimestre.txt";

        public override string cArchivo { get { return _cArchivo; } set { base.cArchivo = value; } }

        /// <summary>
        /// Clase que permite manejar el rango del tiempo en bimestres y que implementa de la interface ManejadorRangoTiempo.
        /// </summary>
        /// <param name="_tsDiferenciaFecha">Diferencia que existe entre una fecha u otra.</param>
        /// <returns>Duración y nombre del formato de fechas del rango del tiempo. Ejemplo: 1 bimestre.</returns>
        public override string ObtenerRangoTiempo(TimeSpan _tsDiferenciaFecha)
        {
            int iTotalMeses = 0;
            int iTotalDias = 0;
            string cNombreFormatoHora = string.Empty;
            string cRangoTiempo = string.Empty;

            iTotalDias = Math.Abs(_tsDiferenciaFecha.Days);
            iTotalMeses = iTotalDias / 30;

            if (iTotalMeses > 1)
            {
                cNombreFormatoHora = iTotalDias == 60 ? "bimestre" : "bimestres";
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
