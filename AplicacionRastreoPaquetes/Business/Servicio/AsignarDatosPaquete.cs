using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Enum;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class AsignarDatosPaquete
    {
        public PaqueteriaDTO AsignarNuevosDatos(PaqueteriaDTO _dtoPaquete)
        {
            DirectorEmpresa srvDirector;
            PaqueteriaDTO dtoPaqueteActualizado = new PaqueteriaDTO();

            if (_dtoPaquete.cNombreEmpresa == EnumEmpresaPaqueteria.DHL.ToString())
            {
                if (_dtoPaquete.cNombreMedioTransporte == EnumMedioTransporte.Avion.ToString())
                {
                    ConstructorPaqueteDhlAvion srvConstructorPaqueteDhlAvion = new ConstructorPaqueteDhlAvion();
                    PaqueteDhlAvion srvPaqueteDhlAvion = new PaqueteDhlAvion();
                    srvDirector = new DirectorEmpresa(srvConstructorPaqueteDhlAvion);
                    srvDirector.EnviarPaquetePorDhlEnAvion(_dtoPaquete);
                    srvPaqueteDhlAvion = srvConstructorPaqueteDhlAvion.ObtenerResultadoPaquete();
                    dtoPaqueteActualizado = srvPaqueteDhlAvion.dtoPaquete;
                }
                else if (_dtoPaquete.cNombreMedioTransporte == EnumMedioTransporte.Barco.ToString())
                {
                    ConstructorPaqueteDhlBarco srvConstructorPaqueteDhlBarco = new ConstructorPaqueteDhlBarco();
                    PaqueteDhlBarco srvPaqueteDhlBarco = new PaqueteDhlBarco();
                    srvDirector = new DirectorEmpresa(srvConstructorPaqueteDhlBarco);
                    srvDirector.EnviarPaquetePorDhlEnBarco(_dtoPaquete);
                    srvPaqueteDhlBarco = srvConstructorPaqueteDhlBarco.ObtenerResultadoPaquete();
                    dtoPaqueteActualizado = srvPaqueteDhlBarco.dtoPaquete;
                }
            }
            else if (_dtoPaquete.cNombreEmpresa == EnumEmpresaPaqueteria.Fedex.ToString())
            {
                if (_dtoPaquete.cNombreMedioTransporte == EnumMedioTransporte.Barco.ToString())
                {
                    ConstructorPaqueteFedexBarco srvConstructorPaqueteFedexBarco = new ConstructorPaqueteFedexBarco();
                    PaqueteFedexBarco srvPaqueteFedexBarco = new PaqueteFedexBarco();
                    srvDirector = new DirectorEmpresa(srvConstructorPaqueteFedexBarco);
                    srvDirector.EnviarPaquetePorFedexEnBarco(_dtoPaquete);
                    srvPaqueteFedexBarco = srvConstructorPaqueteFedexBarco.ObtenerResultadoPaquete();
                    dtoPaqueteActualizado = srvPaqueteFedexBarco.dtoPaquete;
                }
            }
            else if (_dtoPaquete.cNombreEmpresa == EnumEmpresaPaqueteria.Estafeta.ToString())
            {
                if (_dtoPaquete.cNombreMedioTransporte == EnumMedioTransporte.Tren.ToString())
                {
                    ConstructorPaqueteEstafetaTren srvConstructorPaqueteEstafetaTren = new ConstructorPaqueteEstafetaTren();
                    PaqueteEstafetaTren srvPaqueteEstafetaTren = new PaqueteEstafetaTren();
                    srvDirector = new DirectorEmpresa(srvConstructorPaqueteEstafetaTren);
                    srvDirector.EnviarPaquetePorEstafetaEnTren(_dtoPaquete);
                    srvPaqueteEstafetaTren = srvConstructorPaqueteEstafetaTren.ObtenerResultadoPaquete();
                }
            }
            return dtoPaqueteActualizado;
        }
    }
}
