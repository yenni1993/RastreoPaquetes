namespace AplicacionRastreoPaquetes.Business.Interface
{
    /// <summary>
    /// Interface para el formato de texto.
    /// </summary>
    public interface IFormatoTexto
    {
        /// <summary>
        /// Método que permite aplicar el formato del texto.
        /// </summary>
        /// <param name="_cTexto">Texto al que se desea aplicar formato.</param>
        /// <returns>Texto con el formato ya aplicado.</returns>
        string AplicarFormato(string _cTexto);
    }
}
