using AplicacionRastreoPaquetes.Business.DTO;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class PaqueteDhlAvion
    {
        public PaqueteriaDTO dtoPaquete = new PaqueteriaDTO();

        public PaqueteriaDTO AgregarDatosPaquete(PaqueteriaDTO _dtoPaquete)
        {
            return this.dtoPaquete = _dtoPaquete;
        }
    }
}
