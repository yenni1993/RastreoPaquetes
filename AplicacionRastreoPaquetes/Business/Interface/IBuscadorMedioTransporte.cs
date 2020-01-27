using AplicacionRastreoPaquetes.Business.DTO;
using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    public interface IBuscadorMedioTransporte
    {
        List<PaqueteriaDTO> BuscarListaMedioTransporteConEmpresa();
        List<string> BuscarListaMedioTransportePorEmpresa(string _cNombreEmpresa);
    }
}
