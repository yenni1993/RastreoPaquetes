using AplicacionRastreoPaquetes.Business.DTO;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase del paquete de la empresa DHL y medio de transporte Avión.
    /// </summary>
    public class PaqueteDhlAvion
    {
        public PaqueteriaDTO dtoPaquete = new PaqueteriaDTO();

        /// <summary>
        /// Método que permite agregar datos del paquete.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        /// <returns>DTO con los datos asignados al paquete.</returns>
        public PaqueteriaDTO AgregarDatosPaquete(PaqueteriaDTO _dtoPaquete)
        {
            return this.dtoPaquete = _dtoPaquete;
        }
    }
}
