using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;
using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite construir el paquete de la empresa de paquetería DHL con medio de transporte Barco y 
    /// que implementa de la interface IConstructorPaquete
    /// </summary>
    public class ConstructorPaqueteDhlBarco : IConstructorPaquete
    {
        private PaqueteDhlBarco srvPaqueteDhlBarco;

        /// <summary>
        /// Método que asigna el costo de envío del paquete.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        public void AsignarCostoEnvio(PaqueteriaDTO _dtoPaquete)
        {
            _dtoPaquete.dCostoEnvio = (_dtoPaquete.dCostoKilometroPeso * _dtoPaquete.dDistancia) * (1 + (_dtoPaquete.dMargenUtilidad / 100));
            srvPaqueteDhlBarco.AgregarDatosPaquete(_dtoPaquete);
        }

        /// <summary>
        /// Método que permite asignar la fecha de entrega del paquete.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        public void AsignarFechaEntrega(PaqueteriaDTO _dtoPaquete)
        {
            _dtoPaquete.dtEntrega = _dtoPaquete.dtPedido + _dtoPaquete.tsTiempoTraslado;
            srvPaqueteDhlBarco.AgregarDatosPaquete(_dtoPaquete);
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
            srvPaqueteDhlBarco.AgregarDatosPaquete(_dtoPaquete);
        }

        /// <summary>
        /// Método que permite inicializar el objeto.
        /// </summary>
        public void Inicializar()
        {
            srvPaqueteDhlBarco = new PaqueteDhlBarco();
        }

        /// <summary>
        /// Método que permite obtener el resultado del paquete 
        /// de la empresa DHL con medio de transporte Barco.
        /// </summary>
        /// <returns>Paquete de la empresa DHL con medio de transporte Barco.</returns>
        public PaqueteDhlBarco ObtenerResultadoPaquete()
        {
            return srvPaqueteDhlBarco;
        }
    }
}
