using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ManejadorRangoTiempoDias : ManejadorRangoTiempo
    {
        public override string ObtenerRangoTiempo(TimeSpan _tsDiferenciaFecha)
        {
            int iTotalDias = 0;
            string cNombreFormatoHora = string.Empty;
            string cRangoTiempo = string.Empty;

            iTotalDias = Math.Abs(_tsDiferenciaFecha.Days);

            if (iTotalDias > 0)
            {
                cNombreFormatoHora = iTotalDias == 1 ? "día" : "días";
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
