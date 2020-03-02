using AplicacionRastreoPaquetes.Business.DTO;
using System;
using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Interface
{
    /// <summary>
    /// Interface de la empresa de la paquetería.
    /// </summary>
    public interface IEmpresaPaqueteria
    {
        #region [Propiedades]
        /// <summary>
        /// Nombre de una empresa de paquetería.
        /// </summary>
        string cNombreEmpresa { get; set; }

        /// <summary>
        /// Lista con los medios de transportes.
        /// </summary>
        List<IMedioTransporte> lstMediosTransportes { get; set; }

        /// <summary>
        /// Interface del medio de transporte.
        /// </summary>
        IMedioTransporte IMedioTransporte { get; set; }

        /// <summary>
        /// Margen de utilidad entre el precio de venta y los costos fijos de una empresa de paquetería.
        /// </summary>
        decimal dMargenUtilidad { get; set; }
        #endregion

        #region [Métodos]
        /// <summary>
        /// Método que asigna el costo de envío del paquete.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>

        /// <summary>
        /// Método que obtiene el costo de envío del paquete.
        /// </summary>
        /// <param name="_dDistancia">Distancia que existe entre un medio de transporte a otro.</param>
        /// <returns>Costo de envío.</returns>
        decimal ObtenerCostoEnvio(decimal _dDistancia);

        /// <summary>
        /// Método que permite asignar la fecha de entrega del paquete.
        /// </summary>
        /// <param name="_dtPedido">Fecha de pedido de un paquete.</param>
        /// <param name="_tsTiempoTraslado">Tiempo que dura un traslado de un paquete.</param>
        /// <returns>Fecha de entrega del paquete.</returns>
        DateTime ObtenerFechaEntrega(DateTime _dtPedido, TimeSpan _tsTiempoTraslado);

        /// <summary>
        /// Método que permite asignar el tiempo de traslado al enviar un paquete.
        /// </summary>
        /// <param name="_dDistancia"></param>
        /// <returns>Tiempo de traslado del paquete.</returns>
        TimeSpan ObtenerTiempoTraslado(decimal _dDistancia);

        /// <summary>
        /// Método que permite asignar nuevos datos al paquete 
        /// </summary>
        /// <param name="_dtoPaqueteria">DTO con los datos del paquete.</param>
        /// <returns>DTO con los datos del paquete actualizado.</returns>
        PaqueteriaDTO AsignarNuevosDatos(ref PaqueteriaDTO _dtoPaqueteria);
        #endregion
    }
}
