using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ManejadorRangoTiempoMinutos : ManejadorRangoTiempo
    {
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
