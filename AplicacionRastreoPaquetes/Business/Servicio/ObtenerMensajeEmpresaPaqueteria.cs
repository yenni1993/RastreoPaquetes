using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite obtener un mensaje de una empresa de paquetería y que implementa de la interface IObtenerMensaje.
    /// </summary>
    public class ObtenerMensajeEmpresaPaqueteria : IObtenerMensaje
    {
        private PaqueteriaDTO dtoPaquete;
        private bool lExisteEmpresaPaqueteria;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        /// <param name="_lExisteEmpresaPaqueteria">Valor boleano que indica si existe (true) o no (false) la empresa de paquetería.</param>
        public ObtenerMensajeEmpresaPaqueteria(PaqueteriaDTO _dtoPaquete, bool _lExisteEmpresaPaqueteria)
        {
            this.dtoPaquete = _dtoPaquete;
            this.lExisteEmpresaPaqueteria = _lExisteEmpresaPaqueteria;
        }

        /// <summary>
        /// Método que permite obtener un mensaje.
        /// </summary>
        /// <returns>Mensaje obtenido.</returns>
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
