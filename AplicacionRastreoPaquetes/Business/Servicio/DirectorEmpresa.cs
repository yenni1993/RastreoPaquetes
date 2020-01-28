using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase del director de la empresa.
    /// </summary>
    public class DirectorEmpresa
    {
        private IConstructorPaquete IConstructorPaquete;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="_IConstructorPaquete">Interface del constructor del paquete.</param>
        public DirectorEmpresa(IConstructorPaquete _IConstructorPaquete)
        {
            this.IConstructorPaquete = _IConstructorPaquete;
        }

        /// <summary>
        /// Método que permite enviar el paquete de la empresa Fedex en Barco.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        public void EnviarPaquetePorFedexEnBarco(PaqueteriaDTO _dtoPaquete)
        {
            if (_dtoPaquete == null)
            {
                _dtoPaquete = new PaqueteriaDTO();
            }

            _dtoPaquete.dCostoKilometroPeso = 1;
            _dtoPaquete.dMargenUtilidad = 50;
            _dtoPaquete.dVelocidadEntrega = 46;
            this.IConstructorPaquete.Inicializar();
            this.IConstructorPaquete.AsignarTiempoTraslado(_dtoPaquete);
            this.IConstructorPaquete.AsignarFechaEntrega(_dtoPaquete);
            this.IConstructorPaquete.AsignarCostoEnvio(_dtoPaquete);
        }

        /// <summary>
        /// Método que permite enviar el paquete de la empresa DHL en Avión.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        public void EnviarPaquetePorDhlEnAvion(PaqueteriaDTO _dtoPaquete)
        {
            if (_dtoPaquete == null)
            {
                _dtoPaquete = new PaqueteriaDTO();
            }

            _dtoPaquete.dCostoKilometroPeso = 10;
            _dtoPaquete.dMargenUtilidad = 40;
            _dtoPaquete.dVelocidadEntrega = 600;
            this.IConstructorPaquete.Inicializar();
            this.IConstructorPaquete.AsignarTiempoTraslado(_dtoPaquete);
            this.IConstructorPaquete.AsignarFechaEntrega(_dtoPaquete);
            this.IConstructorPaquete.AsignarCostoEnvio(_dtoPaquete);
        }

        /// <summary>
        /// Método que permite enviar el paquete de la empresa DHL en Barco.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        public void EnviarPaquetePorDhlEnBarco(PaqueteriaDTO _dtoPaquete)
        {
            if (_dtoPaquete == null)
            {
                _dtoPaquete = new PaqueteriaDTO();
            }

            _dtoPaquete.dCostoKilometroPeso = 1;
            _dtoPaquete.dMargenUtilidad = 40;
            _dtoPaquete.dVelocidadEntrega = 46;
            this.IConstructorPaquete.Inicializar();
            this.IConstructorPaquete.AsignarTiempoTraslado(_dtoPaquete);
            this.IConstructorPaquete.AsignarFechaEntrega(_dtoPaquete);
            this.IConstructorPaquete.AsignarCostoEnvio(_dtoPaquete);
        }

        /// <summary>
        /// Método que permite enviar el paquete de la empresa Estafeta en Tren.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        public void EnviarPaquetePorEstafetaEnTren(PaqueteriaDTO _dtoPaquete)
        {
            if (_dtoPaquete == null)
            {
                _dtoPaquete = new PaqueteriaDTO();
            }

            _dtoPaquete.dCostoKilometroPeso = 5;
            _dtoPaquete.dMargenUtilidad = 20;
            _dtoPaquete.dVelocidadEntrega = 80;
            this.IConstructorPaquete.Inicializar();
            this.IConstructorPaquete.AsignarTiempoTraslado(_dtoPaquete);
            this.IConstructorPaquete.AsignarFechaEntrega(_dtoPaquete);
            this.IConstructorPaquete.AsignarCostoEnvio(_dtoPaquete);
        }
    }
}
