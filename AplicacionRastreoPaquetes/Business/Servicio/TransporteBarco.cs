using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase del transporte barco y que implementa de la interface IMedioTransporte.
    /// </summary>
    public class TransporteBarco : IMedioTransporte
    {
        /// <summary>
        /// Nombre del medio de transporte.
        /// </summary>
        public string cNombreMedioTransporte { get; set; }

        /// <summary>
        /// Velocidad de entrega que recorre un medio de transporte.
        /// </summary>
        public decimal dVelocidadEntrega { get; set; }

        /// <summary>
        /// Costo de envío de un paquete.
        /// </summary>
        public decimal dCostoKmPeso { get; set; }
    }
}
