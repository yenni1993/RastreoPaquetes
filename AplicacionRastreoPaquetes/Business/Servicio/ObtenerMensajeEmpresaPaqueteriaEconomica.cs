using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite obtener un mensaje de una empresa de paquetería económica y que implementa de la interface IObtenerMensaje.
    /// </summary>
    public class ObtenerMensajeEmpresaPaqueteriaEconomica : IObtenerMensaje
    {
        private PaqueteriaDTO dtoPaquete;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        public ObtenerMensajeEmpresaPaqueteriaEconomica(PaqueteriaDTO _dtoPaquete)
        {
            this.dtoPaquete = _dtoPaquete;
        }

        /// <summary>
        /// Método que permite obtener un mensaje.
        /// </summary>
        /// <returns>Mensaje obtenido.</returns>
        public string ObtenerMensaje()
        {
            string cMensaje = string.Empty;
            cMensaje = $"Si hubieras pedido en {this.dtoPaquete.cNombreEmpresa} te hubiera costado ${this.dtoPaquete.dCostoEnvio} más barato.";
            return cMensaje;
        }
    }
}
