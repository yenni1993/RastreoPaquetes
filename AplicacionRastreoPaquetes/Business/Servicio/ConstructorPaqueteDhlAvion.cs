using System;
using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite construir el paquete de la empresa de paquetería DHL con medio de transporte Avión y 
    /// que implementa de la interface IConstructorPaquete
    /// </summary>
    public class ConstructorPaqueteDhlAvion : IConstructorPaquete
    {
        private PaqueteDhlAvion srvPaqueteDhlAvion;

        /// <summary>
        /// Método que asigna el costo de envío del paquete.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        public void AsignarCostoEnvio(PaqueteriaDTO _dtoPaquete)
        {
            _dtoPaquete.dCostoEnvio = (_dtoPaquete.dCostoKilometroPeso * _dtoPaquete.dDistancia) * (1 + (_dtoPaquete.dMargenUtilidad / 100));
            srvPaqueteDhlAvion.AgregarDatosPaquete(_dtoPaquete);
        }

        /// <summary>
        /// Método que permite asignar la fecha de entrega del paquete.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        public void AsignarFechaEntrega(PaqueteriaDTO _dtoPaquete)
        {
            _dtoPaquete.dtEntrega = _dtoPaquete.dtPedido + _dtoPaquete.tsTiempoTraslado;
            srvPaqueteDhlAvion.AgregarDatosPaquete(_dtoPaquete);
        }

        /// <summary>
        /// Método que permite asignar el tiempo de traslado al enviar un paquete.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        public void AsignarTiempoTraslado(PaqueteriaDTO _dtoPaquete)
        {
            double dbTiempoTraslado = 0;
            dbTiempoTraslado = Convert.ToDouble(_dtoPaquete.dDistancia) / Convert.ToDouble(_dtoPaquete.dVelocidadEntrega);
            _dtoPaquete.tsTiempoTraslado = TimeSpan.FromHours(dbTiempoTraslado);
            srvPaqueteDhlAvion.AgregarDatosPaquete(_dtoPaquete);
        }

        /// <summary>
        /// Método que permite inicializar el objeto.
        /// </summary>
        public void Inicializar()
        {
            srvPaqueteDhlAvion = new PaqueteDhlAvion();
        }

        /// <summary>
        /// Método que permite obtener el resultado del paquete 
        /// de la empresa DHL con medio de transporte Avión.
        /// </summary>
        /// <returns>Paquete de la empresa DHL con medio de transporte Avión.</returns>
        public PaqueteDhlAvion ObtenerResultadoPaquete()
        {
            return srvPaqueteDhlAvion;
        }
    }
}
