namespace AplicacionRastreoPaquetes.Business.DTO
{
    /// <summary>
    /// Clase con sus propiedades de un archivo.
    /// </summary>
    public class Archivo
    {
        /// <summary>
        /// Nombre de un archivo.
        /// </summary>
        public string cNombre { get; set; }

        /// <summary>
        /// Extensión de un archivo.
        /// Ejemplo: .csv, .jpg, .doc
        /// </summary>
        public string cExtension { get; set; }

        /// <summary>
        /// Ruta en donde se encuentra un archivo.
        /// </summary>
        public string cRuta { get; set; }
    }
}
