using System;
using System.Collections.Generic;
using System.Linq;
using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite buscar empresas de paqueterías y que implementa de la interface IBuscadorEmpresaPaqueteria.
    /// </summary>
    public class BuscadorEmpresaPaqueteria : IBuscadorEmpresaPaqueteria
    {
        private PaqueteriaDTO dtoPaqueteria;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="_dtoPaqueteria">DTO con los datos de la paquetería.</param>
        public BuscadorEmpresaPaqueteria(PaqueteriaDTO _dtoPaqueteria)
        {
            this.dtoPaqueteria = _dtoPaqueteria;
        }

        /// <summary>
        /// Método que permite buscar la empresa de paquetería más económica.
        /// </summary>
        /// <param name="lstEmpresaPaqueteria">Lista de empresas de paqueterías para comparar sus precios económicos.</param>
        /// <returns>DTO con los datos de la empresa de paquetería con el precio más económico.</returns>
        public PaqueteriaDTO BuscarEmpresaPaqueteriaEconomica(List<IEmpresaPaqueteria> lstEmpresaPaqueteria)
        {
            PaqueteriaDTO dtoPaqueteriaSiguiente = new PaqueteriaDTO();
            PaqueteriaDTO dtoPaqueteriaMenorCosto = new PaqueteriaDTO();
            decimal dDiferenciaCostoEnvio = 0.0M;

            foreach (IEmpresaPaqueteria dtoPaqueteriaEconomica in lstEmpresaPaqueteria)
            {
                if (dtoPaqueteriaEconomica.cNombreEmpresa != this.dtoPaqueteria.cNombreEmpresa)
                {
                    List<IMedioTransporte> lstMedioTransporte = dtoPaqueteriaEconomica.lstMediosTransportes.Where(w => w.cNombreMedioTransporte == this.dtoPaqueteria.cNombreMedioTransporte).ToList();

                    if (lstMedioTransporte.Any())
                    {
                        foreach (IMedioTransporte mt in lstMedioTransporte)
                        {
                            dtoPaqueteriaSiguiente.cNombreEmpresa = dtoPaqueteriaEconomica.cNombreEmpresa;
                            dtoPaqueteriaSiguiente.cNombreLugarOrigen = this.dtoPaqueteria.cNombreLugarOrigen;
                            dtoPaqueteriaSiguiente.cNombreLugarDestino = this.dtoPaqueteria.cNombreLugarDestino;
                            dtoPaqueteriaSiguiente.dDistancia = this.dtoPaqueteria.dDistancia;
                            dtoPaqueteriaSiguiente.cNombreMedioTransporte = this.dtoPaqueteria.cNombreMedioTransporte;
                            dtoPaqueteriaSiguiente.dtPedido = this.dtoPaqueteria.dtPedido;

                            dtoPaqueteriaEconomica.AsignarNuevosDatos(ref dtoPaqueteriaSiguiente);
                            dDiferenciaCostoEnvio = Math.Abs(this.dtoPaqueteria.dCostoEnvio - dtoPaqueteriaSiguiente.dCostoEnvio);

                            if (string.IsNullOrWhiteSpace(dtoPaqueteriaMenorCosto.cNombreEmpresa))
                            {
                                if (this.dtoPaqueteria.dCostoEnvio > dtoPaqueteriaSiguiente.dCostoEnvio)
                                {
                                    dtoPaqueteriaMenorCosto = dtoPaqueteriaSiguiente;
                                }
                            }
                            else
                            {
                                if (dtoPaqueteriaMenorCosto.dCostoEnvio > dtoPaqueteriaSiguiente.dCostoEnvio)
                                {
                                    dtoPaqueteriaMenorCosto = dtoPaqueteriaSiguiente;
                                }
                            }
                        }
                    }
                }
            }

            dtoPaqueteriaMenorCosto.dCostoEnvio = dDiferenciaCostoEnvio;
            return dtoPaqueteriaMenorCosto;
        }
    }
}
