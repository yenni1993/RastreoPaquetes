using AplicacionRastreoPaquetes.Business.DTO;
using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    /// <summary>
    /// Interface que permite buscar datos de los medios de transporte.
    /// </summary>
    public interface IBuscadorMedioTransporte
    {
        /// <summary>
        /// Método que permite buscar un listado de medios de transporte.
        /// </summary>
        /// <returns>Lista DTO con los datos de la paquetería y sus medios de transporte.</returns>
        List<PaqueteriaDTO> BuscarListaMedioTransporteConEmpresa();

        /// <summary>
        /// Método que permite buscar un listado de medios de transporte por empresa de paquetería.
        /// </summary>
        /// <param name="_cNombreEmpresa">Nombre de la empresa de paquetería.</param>
        /// <returns>Lista de nombres de medios de transporte.</returns>
        List<string> BuscarListaMedioTransportePorEmpresa(string _cNombreEmpresa);
    }
}
