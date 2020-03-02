using System;

namespace AplicacionRastreoPaquetes.Business.DTO
{
    public class PaqueteriaDTO
    {
        /// <summary>
        /// Nombre de una empresa de paquetería.
        /// </summary>
        public string cNombreEmpresa { get; set; }

        /// <summary>
        /// Nombre del medio de transporte de la paquetería.
        /// </summary>
        public string cNombreMedioTransporte { get; set; }

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
        /// Distancia que existe entre un medio de transporte a otro.
        /// </summary>
        public decimal dDistancia { get; set; }

        /// <summary>
        /// Costo de envío de un paquete.
        /// </summary>
        public decimal dCostoEnvio { get; set; }

        /// <summary>
        /// Fecha de entrega de un paquete.
        /// </summary>
        public DateTime dtEntrega { get; set; }

        /// <summary>
        /// Fecha de pedido de un paquete.
        /// </summary>
        public DateTime dtPedido { get; set; }

        /// <summary>
        /// Tiempo que dura un traslado de un paquete.
        /// </summary>
        public TimeSpan tsTiempoTraslado { get; set; }
    }
}
