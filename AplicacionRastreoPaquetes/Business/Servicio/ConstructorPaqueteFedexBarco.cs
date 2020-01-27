using System;
using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ConstructorPaqueteFedexBarco : IConstructorPaquete
    {
        private PaqueteFedexBarco srvPaqueteFedexBarco;

        public void AsignarCostoEnvio(PaqueteriaDTO _dtoPaquete)
        {
            _dtoPaquete.dCostoEnvio = (_dtoPaquete.dCostoKilometroPeso * _dtoPaquete.dDistancia) * (1 + (_dtoPaquete.dMargenUtilidad / 100));
            srvPaqueteFedexBarco.AgregarDatosPaquete(_dtoPaquete);
        }

        public void AsignarFechaEntrega(PaqueteriaDTO _dtoPaquete)
        {
            _dtoPaquete.dtEntrega = _dtoPaquete.dtPedido + _dtoPaquete.tsTiempoTraslado;
            srvPaqueteFedexBarco.AgregarDatosPaquete(_dtoPaquete);
        }

        public void AsignarTiempoTraslado(PaqueteriaDTO _dtoPaquete)
        {
            double dbTiempoTraslado = 0;
            dbTiempoTraslado = Convert.ToDouble(_dtoPaquete.dDistancia) / Convert.ToDouble(_dtoPaquete.dVelocidadEntrega);
            _dtoPaquete.tsTiempoTraslado = TimeSpan.FromSeconds(dbTiempoTraslado);
            srvPaqueteFedexBarco.AgregarDatosPaquete(_dtoPaquete);
        }

        public void Inicializar()
        {
            srvPaqueteFedexBarco = new PaqueteFedexBarco();
        }

        public PaqueteFedexBarco ObtenerResultadoPaquete()
        {
            return srvPaqueteFedexBarco;
        }
    }
}
