using AplicacionRastreoPaquetes.Business.DTO;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    /// <summary>
    /// Interface que permite construir el paquete.
    /// </summary>
    public interface IConstructorPaquete
    {
        /// <summary>
        /// Método que permite inicializar el objeto.
        /// </summary>
        void Inicializar();

        /// <summary>
        /// Método que permite asignar el tiempo de traslado al enviar un paquete.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        void AsignarTiempoTraslado(PaqueteriaDTO _dtoPaquete);

        /// <summary>
        /// Método que permite asignar la fecha de entrega del paquete.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        void AsignarFechaEntrega(PaqueteriaDTO _dtoPaquete);

        /// <summary>
        /// Método que asigna el costo de envío del paquete.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        void AsignarCostoEnvio(PaqueteriaDTO _dtoPaquete);
    }
}
