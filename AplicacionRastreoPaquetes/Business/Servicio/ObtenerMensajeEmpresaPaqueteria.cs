using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ObtenerMensajeEmpresaPaqueteria : IObtenerMensaje
    {
        private PaqueteriaDTO dtoPaquete;
        private bool lExisteEmpresaPaqueteria;

        public ObtenerMensajeEmpresaPaqueteria(PaqueteriaDTO _dtoPaquete, bool _lExisteEmpresaPaqueteria)
        {
            this.dtoPaquete = _dtoPaquete;
            this.lExisteEmpresaPaqueteria = _lExisteEmpresaPaqueteria;
        }

        public string ObtenerMensaje()
        {
            string cMensaje = string.Empty;

            if (!this.lExisteEmpresaPaqueteria)
            {
                cMensaje = $"La paquetería: {this.dtoPaquete.cNombreEmpresa} no se encuentra registrada en nuestra red de distribución.";
            }

            return cMensaje;
        }
    }
}
