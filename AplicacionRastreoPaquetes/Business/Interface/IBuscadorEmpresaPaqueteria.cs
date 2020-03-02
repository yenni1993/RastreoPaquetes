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
        /// Método que permite buscar la empresa de paquetería más económica.
        /// </summary>
        /// <param name="lstEmpresaPaqueteria">Lista de empresas de paqueterías para comparar sus precios económicos.</param>
        /// <returns>DTO con los datos de la empresa de paquetería con el precio más económico.</returns>
        PaqueteriaDTO BuscarEmpresaPaqueteriaEconomica(List<IEmpresaPaqueteria> lstEmpresaPaqueteria);
    }
}
