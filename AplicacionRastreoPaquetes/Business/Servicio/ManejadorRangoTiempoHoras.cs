using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ManejadorRangoTiempoHoras : ManejadorRangoTiempo
    {
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
