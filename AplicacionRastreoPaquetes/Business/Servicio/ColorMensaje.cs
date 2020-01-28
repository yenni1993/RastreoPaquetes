using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite colorear el mensaje que se muestra en el sistema.
    /// </summary>
    public class ColorMensaje
    {
        IColorMensaje IColorMensaje { get; set; }

        /// <summary>
        /// Método que permite agregar color al mensaje.
        /// </summary>
        /// <param name="_IColorMensaje">Interface del color del mensaje.</param>
        public void AgregarColorMensaje(IColorMensaje _IColorMensaje)
        {
            this.IColorMensaje = _IColorMensaje;
        }

        /// <summary>
        /// Método que permite colorear el mensaje que se muestra en el sistema.
        /// </summary>
        /// <param name="_cMensaje">Texto del mensaje que se va a colorear.</param>
        public void ColorearMensaje(string _cMensaje)
        {
            this.IColorMensaje.ColorearMensaje(_cMensaje);
        }
    }
}
