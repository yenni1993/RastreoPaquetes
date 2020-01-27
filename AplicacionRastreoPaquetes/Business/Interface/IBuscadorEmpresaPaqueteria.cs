using AplicacionRastreoPaquetes.Business.DTO;
using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    public interface IBuscadorEmpresaPaqueteria
    {
        List<string> BuscarListaEmpresaPaqueteria();
        PaqueteriaDTO BuscarEmpresaPaqueteriaEconomica(List<PaqueteriaDTO> lstPaqueteriaDTO);
    }
}
