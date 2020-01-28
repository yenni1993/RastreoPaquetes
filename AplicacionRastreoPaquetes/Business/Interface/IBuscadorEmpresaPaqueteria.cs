using AplicacionRastreoPaquetes.Business.DTO;
using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    /// <summary>
    /// Interface que permite buscar datos de las empresas de paqueterías.
    /// </summary>
    public interface IBuscadorEmpresaPaqueteria
    {
        /// <summary>
        /// Método que permite buscar una lista de empresas de paqueterías.
        /// </summary>
        /// <returns>Lista con los nombres de las empresas de paqueterías.</returns>
        List<string> BuscarListaEmpresaPaqueteria();

        /// <summary>
        /// Método que permite buscar la paquetería más económica.
        /// </summary>
        /// <param name="lstPaqueteriaDTO">Lista de paqueterías a comparar sus precios económicos.</param>
        /// <returns>DTO con los datos de la paquetería con el precio más económico.</returns>
        PaqueteriaDTO BuscarEmpresaPaqueteriaEconomica(List<PaqueteriaDTO> lstPaqueteriaDTO);
    }
}
