using AplicacionRastreoPaquetes.Business.DTO;
using System;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    public interface IConstructorPaquete
    {
        void Inicializar();
        void AsignarTiempoTraslado(PaqueteriaDTO _dtoPaquete);
        void AsignarFechaEntrega(PaqueteriaDTO _dtoPaquete);
        void AsignarCostoEnvio(PaqueteriaDTO _dtoPaquete);
    }
}
