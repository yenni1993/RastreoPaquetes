using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    public interface IValidadorEmpresaPaqueteria
    {
        bool ValidarExistenciaEmpresaPaqueteria(List<string> _lstNombreEmpresaExistente, string _cNombreEmpresaBuscar);
    }
}
