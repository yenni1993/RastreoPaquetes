using AplicacionRastreoPaquetes.Business.Interface;
using System.Collections.Generic;
using System.Linq;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ValidarEmpresaPaqueteria : IValidadorEmpresaPaqueteria
    {
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
