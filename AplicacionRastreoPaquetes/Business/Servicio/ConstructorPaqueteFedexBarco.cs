using System;
using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite construir el paquete de la empresa de paquetería Fedex con medio de transporte Barco y 
    /// que implementa de la interface IConstructorPaquete
    /// </summary>
    public class ConstructorPaqueteFedexBarco : IConstructorPaquete
    {
        private PaqueteFedexBarco srvPaqueteFedexBarco;

        /// <summary>
        /// Método que asigna el costo de envío del paquete.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        public void AsignarCostoEnvio(PaqueteriaDTO _dtoPaquete)
        {
            _dtoPaquete.dCostoEnvio = (_dtoPaquete.dCostoKilometroPeso * _dtoPaquete.dDistancia) * (1 + (_dtoPaquete.dMargenUtilidad / 100));
            srvPaqueteFedexBarco.AgregarDatosPaquete(_dtoPaquete);
        }

        /// <summary>
        /// Método que permite asignar la fecha de entrega del paquete.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        public void AsignarFechaEntrega(PaqueteriaDTO _dtoPaquete)
        {
            _dtoPaquete.dtEntrega = _dtoPaquete.dtPedido + _dtoPaquete.tsTiempoTraslado;
            srvPaqueteFedexBarco.AgregarDatosPaquete(_dtoPaquete);
        }

        /// <summary>
        /// Método que permite asignar el tiempo de traslado al enviar un paquete.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        public void AsignarTiempoTraslado(PaqueteriaDTO _dtoPaquete)
        {
            double dbTiempoTraslado = 0;
            dbTiempoTraslado = Convert.ToDouble(_dtoPaquete.dDistancia) / Convert.ToDouble(_dtoPaquete.dVelocidadEntrega);
            _dtoPaquete.tsTiempoTraslado = TimeSpan.FromSeconds(dbTiempoTraslado);
            srvPaqueteFedexBarco.AgregarDatosPaquete(_dtoPaquete);
        }

        /// <summary>
        /// Método que permite inicializar el objeto.
        /// </summary>
        public void Inicializar()
        {
            srvPaqueteFedexBarco = new PaqueteFedexBarco();
        }

        /// <summary>
        /// Método que permite obtener el resultado del paquete 
        /// de la empresa Fedex con medio de transporte Barco.
        /// </summary>
        /// <returns>Paquete de la empresa Fedex con medio de transporte Barco.</returns>
        public PaqueteFedexBarco ObtenerResultadoPaquete()
        {
            return srvPaqueteFedexBarco;
        }
    }
}
