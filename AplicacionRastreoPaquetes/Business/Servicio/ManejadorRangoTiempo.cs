using System;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public abstract class ManejadorRangoTiempo : IManejadorRangoTiempo
    {
        private IManejadorRangoTiempo IManejadorSiguiente;

        public IManejadorRangoTiempo AsignarSiguienteRangoTiempo(IManejadorRangoTiempo _IManejadorTiempo)
        {
            return this.IManejadorSiguiente = _IManejadorTiempo;
        }

        public virtual string ObtenerRangoTiempo(TimeSpan _tsDiferenciaFecha)
        {
            string cRangoTiempo = string.Empty;

            if(this.IManejadorSiguiente != null)
            {
                cRangoTiempo = this.IManejadorSiguiente.ObtenerRangoTiempo(_tsDiferenciaFecha);
            }

            return cRangoTiempo;
        }
    }
}
