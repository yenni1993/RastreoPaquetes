using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ObtenerMensajeMedioTransporte : IObtenerMensaje
    {
        private PaqueteriaDTO dtoPaquete;
        private bool lExisteMedioTransporte;

        public ObtenerMensajeMedioTransporte(PaqueteriaDTO _dtoPaquete, bool _lExisteMedioTransporte)
        {
            this.dtoPaquete = _dtoPaquete;
            this.lExisteMedioTransporte = _lExisteMedioTransporte;
        }

        public string ObtenerMensaje()
        {
            string cMensaje = string.Empty;

            if (!this.lExisteMedioTransporte)
            {
                cMensaje = $"{this.dtoPaquete.cNombreEmpresa} no ofrece el servicio de transporte {this.dtoPaquete.cNombreMedioTransporte}, " +
                    $"te recomendamos cotizar en otra empresa.";
            }

            return cMensaje;
        }
    }
}
