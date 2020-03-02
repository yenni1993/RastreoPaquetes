namespace AplicacionRastreoPaquetes.Business.Interface
{
    /// <summary>
    /// Interface del medio de transporte.
    /// </summary>
    public interface IMedioTransporte
    {
        #region [Propiedades]
        /// <summary>
        /// Nombre de un medio de transporte.
        /// </summary>
        string cNombreMedioTransporte { get; set; }

        /// <summary>
        /// Velocidad de entrega que recorre un medio de transporte.
        /// </summary>
        decimal dVelocidadEntrega { get; set; }

        /// <summary>
        /// Costo de envío por kilómetro en pesos de un paquete.
        /// </summary>
        decimal dCostoKmPeso { get; set; }
        #endregion
    }
}
