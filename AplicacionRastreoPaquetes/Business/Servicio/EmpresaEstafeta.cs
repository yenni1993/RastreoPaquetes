using System;
using System.Collections.Generic;
using System.Linq;
using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase de la empresa Estafeta y que implementa de la interface IEmpresaPaqueteria.
    /// </summary>
    public class EmpresaEstafeta : IEmpresaPaqueteria
    {
        #region [Propiedades]
        /// <summary>
        /// Nombre de la empresa de paquetería.
        /// </summary>
        public string cNombreEmpresa { get; set; }

        /// <summary>
        /// Margen de utilidad entre el precio de venta y los costos fijos de una empresa de paquetería.
        /// </summary>
        public decimal dMargenUtilidad { get; set; }

        /// <summary>
        /// Lista con los medios de transportes.
        /// </summary>
        public List<IMedioTransporte> lstMediosTransportes { get; set; }

        /// <summary>
        /// Interface del medio de transporte.
        /// </summary>
        public IMedioTransporte IMedioTransporte { get; set; }
        #endregion

        #region [Métodos]
        /// <summary>
        /// Método que obtiene el costo de envío del paquete.
        /// </summary>
        /// <param name="_dDistancia">Distancia que existe entre un medio de transporte a otro.</param>
        /// <returns>Costo de envío.</returns>
        public decimal ObtenerCostoEnvio(decimal _dDistancia)
        {
            decimal dCostoEnvio = 0.0M;
            return dCostoEnvio = (IMedioTransporte.dCostoKmPeso * _dDistancia) * (1 + (dMargenUtilidad / 100));
        }

        /// <summary>
        /// Método que permite asignar la fecha de entrega del paquete.
        /// </summary>
        /// <param name="_dtPedido">Fecha de pedido de un paquete.</param>
        /// <param name="_tsTiempoTraslado">Tiempo que dura un traslado de un paquete.</param>
        /// <returns>Fecha de entrega del paquete.</returns>
        public DateTime ObtenerFechaEntrega(DateTime _dtPedido, TimeSpan _tsTiempoTraslado)
        {
            DateTime dtFechaEntrega = new DateTime();
            return dtFechaEntrega = _dtPedido + _tsTiempoTraslado;
        }

        /// <summary>
        /// Método que permite asignar el tiempo de traslado al enviar un paquete.
        /// </summary>
        /// <param name="_dDistancia"></param>
        /// <returns>Tiempo de traslado del paquete.</returns>
        public TimeSpan ObtenerTiempoTraslado(decimal _dDistancia)
        {
            double dbTiempoTraslado = 0;
            TimeSpan tsTiempoTraslado = new TimeSpan();
            dbTiempoTraslado = Convert.ToDouble(_dDistancia) / Convert.ToDouble(IMedioTransporte.dVelocidadEntrega);
            return tsTiempoTraslado = TimeSpan.FromSeconds(dbTiempoTraslado);
        }

        /// <summary>
        /// Método que permite asignar nuevos datos al paquete 
        /// </summary>
        /// <param name="_dtoPaqueteria">DTO con los datos del paquete.</param>
        /// <returns>DTO con los datos del paquete actualizado.</returns>
        public PaqueteriaDTO AsignarNuevosDatos(ref PaqueteriaDTO _dtoPaqueteria)
        {
            PaqueteriaDTO dtoPaqueteria = _dtoPaqueteria;
            this.IMedioTransporte = lstMediosTransportes.Where(e => e.cNombreMedioTransporte == dtoPaqueteria.cNombreMedioTransporte).FirstOrDefault();
            dtoPaqueteria.dCostoEnvio = ObtenerCostoEnvio(dtoPaqueteria.dDistancia);
            dtoPaqueteria.tsTiempoTraslado = ObtenerTiempoTraslado(dtoPaqueteria.dDistancia);
            dtoPaqueteria.dtEntrega = ObtenerFechaEntrega(dtoPaqueteria.dtPedido, dtoPaqueteria.tsTiempoTraslado);
            return dtoPaqueteria;
        }
        #endregion
    }
}
