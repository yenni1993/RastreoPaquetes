using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;
using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ConstructorPaqueteDhlBarco : IConstructorPaquete
    {
        private PaqueteDhlBarco srvPaqueteDhlBarco;

        public void AsignarCostoEnvio(PaqueteriaDTO _dtoPaquete)
        {
            _dtoPaquete.dCostoEnvio = (_dtoPaquete.dCostoKilometroPeso * _dtoPaquete.dDistancia) * (1 + (_dtoPaquete.dMargenUtilidad / 100));
            srvPaqueteDhlBarco.AgregarDatosPaquete(_dtoPaquete);
        }

        public void AsignarFechaEntrega(PaqueteriaDTO _dtoPaquete)
        {
            _dtoPaquete.dtEntrega = _dtoPaquete.dtPedido + _dtoPaquete.tsTiempoTraslado;
            srvPaqueteDhlBarco.AgregarDatosPaquete(_dtoPaquete);
        }

        public void AsignarTiempoTraslado(PaqueteriaDTO _dtoPaquete)
        {
            double dbTiempoTraslado = 0;
            dbTiempoTraslado = Convert.ToDouble(_dtoPaquete.dDistancia) / Convert.ToDouble(_dtoPaquete.dVelocidadEntrega);
            _dtoPaquete.tsTiempoTraslado = TimeSpan.FromSeconds(dbTiempoTraslado);
            srvPaqueteDhlBarco.AgregarDatosPaquete(_dtoPaquete);
        }

        public void Inicializar()
        {
            srvPaqueteDhlBarco = new PaqueteDhlBarco();
        }

        public PaqueteDhlBarco ObtenerResultadoPaquete()
        {
            return srvPaqueteDhlBarco;
        }
    }
}
