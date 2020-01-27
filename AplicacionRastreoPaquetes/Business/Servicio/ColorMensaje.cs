using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ColorMensaje
    {
        IColorMensaje IColorMensaje { get; set; }

        public void AgregarColorMensaje(IColorMensaje _IColorMensaje)
        {
            this.IColorMensaje = _IColorMensaje;
        }

        public void ColorearMensaje(string _cMensaje)
        {
            this.IColorMensaje.ColorearMensaje(_cMensaje);
        }
    }
}
