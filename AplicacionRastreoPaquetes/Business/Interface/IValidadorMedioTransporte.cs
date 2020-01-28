using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    /// <summary>
    /// Interface que permite validar el medio de transporte.
    /// </summary>
    public interface IValidadorMedioTransporte
    {
        /// <summary>
        /// Método que permite validar la existencia del medio de transporte.
        /// </summary>
        /// <param name="_lstNombreMedioTransporteExistente">Lista con los nombres de los medios de transporte existentes.</param>
        /// <param name="_cNombreMedioTransporteBuscar">Nombre del medio de transporte que se desea buscar.</param>
        /// <returns>Valor boleano que indica si el medio de transporte existe (true) o no (false) en la lista mencionada previamente.</returns>
        bool ValidarExistenciaMedioTranporte(List<string> _lstNombreMedioTransporteExistente, string _cNombreMedioTransporteBuscar);
    }
}
