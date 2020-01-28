using AplicacionRastreoPaquetes.Business.DTO;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase del paquete de la empresa Estafeta y medio de transporte Tren.
    /// </summary>
    public class PaqueteEstafetaTren
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
