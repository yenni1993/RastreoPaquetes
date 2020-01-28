using AplicacionRastreoPaquetes.Business.DTO;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    /// <summary>
    /// Interface que permite asignar datos de los paquetes.
    /// </summary>
    public interface IAsignadorDatosPaquete
    {
        /// <summary>
        /// Método que permite asignar nuevos datos a un paquete.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos de un paquete.</param>
        /// <returns>DTO con los datos nuevos asignados de un paquete.</returns>
        PaqueteriaDTO AsignarNuevosDatos(PaqueteriaDTO _dtoPaquete);
    }
}
