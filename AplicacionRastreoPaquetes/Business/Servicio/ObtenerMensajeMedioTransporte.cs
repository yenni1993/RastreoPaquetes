using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite obtener un mensaje de un medio de transporte y que implementa de la interface IObtenerMensaje.
    /// </summary>
    public class ObtenerMensajeMedioTransporte : IObtenerMensaje
    {
        private PaqueteriaDTO dtoPaquete;
        private bool lExisteMedioTransporte;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        /// <param name="_lExisteMedioTransporte">Valor boleano que indica si existe (true) o no (false) el medio de transporte.</param>
        public ObtenerMensajeMedioTransporte(PaqueteriaDTO _dtoPaquete, bool _lExisteMedioTransporte)
        {
            this.dtoPaquete = _dtoPaquete;
            this.lExisteMedioTransporte = _lExisteMedioTransporte;
        }

        /// <summary>
        /// Método que permite obtener un mensaje.
        /// </summary>
        /// <returns>Mensaje obtenido.</returns>
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
