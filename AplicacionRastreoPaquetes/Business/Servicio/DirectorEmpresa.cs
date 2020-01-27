using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class DirectorEmpresa
    {
        private IConstructorPaquete IConstructorPaquete;

        public DirectorEmpresa(IConstructorPaquete _IConstructorPaquete)
        {
            this.IConstructorPaquete = _IConstructorPaquete;
        }

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
