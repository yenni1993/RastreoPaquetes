using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;
using System;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite obtener un mensaje de un paquete y que implementa de la interface IObtenerMensaje.
    /// </summary>
    public class ObtenerMensajePaquete : IObtenerMensaje
    {
        private PaqueteriaDTO dtoPaquete;
        private DateTime dtActual;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        /// <param name="_dtActual">Fecha del día de hoy.</param>
        public ObtenerMensajePaquete(PaqueteriaDTO _dtoPaquete, DateTime _dtActual)
        {
            this.dtoPaquete = _dtoPaquete;
            this.dtActual = _dtActual;
        }

        /// <summary>
        /// Método que permite obtener un mensaje.
        /// </summary>
        /// <returns>Mensaje obtenido.</returns>
        public string ObtenerMensaje()
        {
            string cMensaje = string.Empty;
            string cExpresion1 = string.Empty;
            string cExpresion2 = string.Empty;
            string cExpresion3 = string.Empty;
            string cExpresion4 = string.Empty;

            cExpresion1 = this.dtoPaquete.dtEntrega < this.dtActual ? "salió" : "ha salido";
            cExpresion2 = this.dtoPaquete.dtEntrega < this.dtActual ? "llegó" : "llegará";
            cExpresion3 = this.dtoPaquete.dtEntrega < this.dtActual ? "hace" : "dentro de";
            cExpresion4 = this.dtoPaquete.dtEntrega < this.dtActual ? "tuvo" : "tendrá";            

            cMensaje = $"Tu paquete {cExpresion1} de {this.dtoPaquete.cNombreLugarOrigen} y {cExpresion2} a {this.dtoPaquete.cNombreLugarDestino} " +
                $"{cExpresion3} {this.dtoPaquete.cRangoTiempo} y {cExpresion4} un costo de ${this.dtoPaquete.dCostoEnvio} " +
                $"(Cualquier reclamación con {this.dtoPaquete.cNombreEmpresa}).";

            return cMensaje;
        }
    }
}
