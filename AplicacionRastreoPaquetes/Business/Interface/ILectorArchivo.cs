using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    public interface ILectorArchivo
    {
        List<string> LeerContenidoArchivo(string _cRuta);
    }
}
