using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    /// <summary>
    /// Interface que permite validar la empresa de paquetería.
    /// </summary>
    public interface IValidadorEmpresaPaqueteria
    {
        /// <summary>
        /// Método que permite validar la existencia de la empresa de paquetería.
        /// </summary>
        /// <param name="_lstNombreEmpresaExistente">Lista con los nombres de las empresas de paquetería existentes.</param>
        /// <param name="_cNombreEmpresaBuscar">Nombre de la empresa que se desea buscar.</param>
        /// <returns>Valor boleano que indica si la empresa existe (true) o no (false) en la lista mencionada previamente.</returns>
        bool ValidarExistenciaEmpresaPaqueteria(List<string> _lstNombreEmpresaExistente, string _cNombreEmpresaBuscar);
    }
}
