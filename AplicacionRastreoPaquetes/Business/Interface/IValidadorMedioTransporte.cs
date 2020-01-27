using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    public interface IValidadorMedioTransporte
    {
        bool ValidarExistenciaMedioTranporte(List<string> _lstNombreMedioTransporteExistente, string _cNombreMedioTransporteBuscar);
    }
}
