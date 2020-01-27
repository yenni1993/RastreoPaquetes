using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ManejadorRangoTiempoMeses : ManejadorRangoTiempo
    {
        public override string ObtenerRangoTiempo(TimeSpan _tsDiferenciaFecha)
        {
            int iTotalMeses = 0;
            int iTotalDias = 0;
            string cNombreFormatoHora = string.Empty;
            string cRangoTiempo = string.Empty;

            iTotalDias = Math.Abs(_tsDiferenciaFecha.Days);

            if (iTotalDias > 30)
            {
                iTotalMeses = iTotalDias / 31;
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
