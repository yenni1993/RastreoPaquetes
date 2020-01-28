namespace AplicacionRastreoPaquetes.Business.Interface
{
    /// <summary>
    /// Interface que permite colorear el mensaje que se muestra en el sistema.
    /// </summary>
    public interface IColorMensaje
    {
        /// <summary>
        /// Método que permite colorear el mensaje que se muestra en el sistema.
        /// </summary>
        /// <param name="_cMensaje">Texto del mensaje que se va a colorear.</param>
        void ColorearMensaje(string _cMensaje);
    }
}
