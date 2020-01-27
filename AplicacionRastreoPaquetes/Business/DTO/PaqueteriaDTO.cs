using System;
using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.DTO
{
    public class PaqueteriaDTO
    {
        #region [Datos de la empresa]
        /// <summary>
        /// Margen de utilidad entre el precio de venta y 
        /// los costos fijos de una empresa de paquetería.
        /// </summary>
        public decimal dMargenUtilidad { get; set; }

        /// <summary>
        /// Nombre de una empresa de paquetería.
        /// </summary>
        public string cNombreEmpresa { get; set; }
        #endregion

        #region [Datos del medio de transporte]
        /// <summary>
        /// Costo por kilómetro en pesos de un medio de transporte.
        /// </summary>
        public decimal dCostoKilometroPeso { get; set; }

        /// <summary>
        /// Distancia que existe entre un medio de transporte a otro.
        /// </summary>
        public decimal dDistancia { get; set; }

        /// <summary>
        /// Velocidad de entrega que recorre un medio de transporte.
        /// </summary>
        public decimal dVelocidadEntrega { get; set; }

        /// <summary>
        /// Nombre de un medio de transporte.
        /// </summary>
        public string cNombreMedioTransporte { get; set; }

        /// <summary>
        /// Tipo de velocidad de un medio de transporte. 
        /// Ejemplo: Kilómetro por hora (km/h).
        /// </summary>
        public int cTipoVelocidad { get; set; }
        #endregion

        #region [Datos del paquete]
        /// <summary>
        /// Nombre de un paquete.
        /// </summary>
        public string cNombrePaquete { get; set; }

        /// <summary>
        /// Nombre del lugar de origen de un paquete.
        /// </summary>
        public string cNombreLugarOrigen { get; set; }

        /// <summary>
        /// Nombre del lugar de destino de un paquete.
        /// </summary>
        public string cNombreLugarDestino { get; set; }

        /// <summary>
        /// Rango del tiempo de un paquete.
        /// Ejemplo: 2 horas, 4 días, 1 mes, etc.
        /// </summary>
        public string cRangoTiempo { get; set; }

        /// <summary>
        /// Costo de envío de un paquete.
        /// </summary>
        public decimal dCostoEnvio { get; set; }

        /// <summary>
        /// Tiempo que dura un traslado de un paquete.
        /// </summary>
        public TimeSpan tsTiempoTraslado { get; set; }

        /// <summary>
        /// Fecha de entrega de un paquete.
        /// </summary>
        public DateTime dtEntrega { get; set; }

        /// <summary>
        /// Fecha de pedido de un paquete.
        /// </summary>
        public DateTime dtPedido { get; set; }
        #endregion

        #region [Otros]
        /// <summary>
        /// Lista con los nombres de las empresas de paqueterías.
        /// </summary>
        public List<string> lstNombreEmpresaPaqueteria { get; set; }

        /// <summary>
        /// Lista con los nombres de los medios de trasnporte.
        /// </summary>
        public List<string> lstNombreMedioTransporte { get; set; }
        #endregion
    }
}
