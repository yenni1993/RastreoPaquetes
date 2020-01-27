using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class ObtenerMensajeEmpresaPaqueteriaEconomica : IObtenerMensaje
    {
        private PaqueteriaDTO dtoPaquete;

        public ObtenerMensajeEmpresaPaqueteriaEconomica(PaqueteriaDTO _dtoPaquete)
        {
            this.dtoPaquete = _dtoPaquete;
        }

        public string ObtenerMensaje()
        {
            string cMensaje = string.Empty;
            cMensaje = $"Si hubieras pedido en {this.dtoPaquete.cNombreEmpresa} te hubiera costado ${this.dtoPaquete.dCostoEnvio} más barato.";
            return cMensaje;
        }
    }
}
