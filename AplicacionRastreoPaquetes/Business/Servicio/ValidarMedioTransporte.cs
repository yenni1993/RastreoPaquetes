using AplicacionRastreoPaquetes.Business.Interface;
using System.Collections.Generic;
using System.Linq;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite validar el medio de transporte y que implementa de la interface IValidadorMedioTransporte.
    /// </summary>
    public class ValidarMedioTransporte : IValidadorMedioTransporte
    {
        /// <summary>
        /// Método que permite validar la existencia del medio de transporte.
        /// </summary>
        /// <param name="_lstNombreMedioTransporteExistente">Lista con los nombres de los medios de transporte existentes.</param>
        /// <param name="_cNombreMedioTransporteBuscar">Nombre del medio de transporte que se desea buscar.</param>
        /// <returns>Valor boleano que indica si el medio de transporte existe (true) o no (false) en la lista mencionada previamente.</returns>
        public bool ValidarExistenciaMedioTranporte(List<string> _lstNombreMedioTransporte, string _cNombreMedioTransporte)
        {
            bool lExisteMedioTransporte = false;

            if (_lstNombreMedioTransporte.Any())
            {
                lExisteMedioTransporte = _lstNombreMedioTransporte.Contains(_cNombreMedioTransporte);
            }

            return lExisteMedioTransporte;
        }
    }
}
