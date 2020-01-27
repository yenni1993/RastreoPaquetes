using AplicacionRastreoPaquetes.Business.Interface;
using System.Collections.Generic;
using System.Linq;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ValidarMedioTransporte : IValidadorMedioTransporte
    {
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
