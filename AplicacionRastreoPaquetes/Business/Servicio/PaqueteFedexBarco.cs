using AplicacionRastreoPaquetes.Business.DTO;
using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class PaqueteFedexBarco
    {
        public PaqueteriaDTO dtoPaquete = new PaqueteriaDTO();

        public PaqueteriaDTO AgregarDatosPaquete(PaqueteriaDTO _dtoPaquete)
        {
            return this.dtoPaquete = _dtoPaquete;
        }
    }
}
