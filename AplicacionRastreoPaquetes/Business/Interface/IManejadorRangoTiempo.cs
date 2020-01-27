using System;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    public interface IManejadorRangoTiempo
    {
        IManejadorRangoTiempo AsignarSiguienteRangoTiempo(IManejadorRangoTiempo _IManejadorSiguienteRangoTiempo);
        string ObtenerRangoTiempo(TimeSpan _tsDiferenciaFecha);
    }
}
