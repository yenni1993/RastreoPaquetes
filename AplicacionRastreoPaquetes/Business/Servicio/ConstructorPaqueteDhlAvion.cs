using System;
using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ConstructorPaqueteDhlAvion : IConstructorPaquete
    {
        private PaqueteDhlAvion srvPaqueteDhlAvion;

        public void AsignarCostoEnvio(PaqueteriaDTO _dtoPaquete)
        {
            _dtoPaquete.dCostoEnvio = (_dtoPaquete.dCostoKilometroPeso * _dtoPaquete.dDistancia) * (1 + (_dtoPaquete.dMargenUtilidad / 100));
            srvPaqueteDhlAvion.AgregarDatosPaquete(_dtoPaquete);
        }

        public void AsignarFechaEntrega(PaqueteriaDTO _dtoPaquete)
        {
            _dtoPaquete.dtEntrega = _dtoPaquete.dtPedido + _dtoPaquete.tsTiempoTraslado;
            srvPaqueteDhlAvion.AgregarDatosPaquete(_dtoPaquete);
        }

        public void AsignarTiempoTraslado(PaqueteriaDTO _dtoPaquete)
        {
            double dbTiempoTraslado = 0;
            dbTiempoTraslado = Convert.ToDouble(_dtoPaquete.dDistancia) / Convert.ToDouble(_dtoPaquete.dVelocidadEntrega);
            _dtoPaquete.tsTiempoTraslado = TimeSpan.FromHours(dbTiempoTraslado);
            srvPaqueteDhlAvion.AgregarDatosPaquete(_dtoPaquete);
        }

        public void Inicializar()
        {
            srvPaqueteDhlAvion = new PaqueteDhlAvion();
        }

        public PaqueteDhlAvion ObtenerResultadoPaquete()
        {
            return srvPaqueteDhlAvion;
        }
    }
}
