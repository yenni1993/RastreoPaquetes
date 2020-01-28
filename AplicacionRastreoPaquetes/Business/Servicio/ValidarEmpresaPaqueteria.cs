using AplicacionRastreoPaquetes.Business.Interface;
using System.Collections.Generic;
using System.Linq;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite validar la empresa de paquetería y que implementa de la interface IValidadorEmpresaPaqueteria.
    /// </summary>
    public class ValidarEmpresaPaqueteria : IValidadorEmpresaPaqueteria
    {
        /// <summary>
        /// Método que permite validar la existencia de la empresa de paquetería.
        /// </summary>
        /// <param name="_lstNombreEmpresaExistente">Lista con los nombres de las empresas de paquetería existentes.</param>
        /// <param name="_cNombreEmpresaBuscar">Nombre de la empresa que se desea buscar.</param>
        /// <returns>Valor boleano que indica si la empresa existe (true) o no (false) en la lista mencionada previamente.</returns>
        public bool ValidarExistenciaEmpresaPaqueteria(List<string> _lstNombreEmpresaExistente, string _cNombreEmpresaBuscar)
        {
            bool lExisteEmpresaPaqueteria = false;

            if (_lstNombreEmpresaExistente.Any())
            {
                lExisteEmpresaPaqueteria = _lstNombreEmpresaExistente.Contains(_cNombreEmpresaBuscar);
            }

            return lExisteEmpresaPaqueteria;
        }
    }
}
