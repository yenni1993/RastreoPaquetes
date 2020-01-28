using System;
using System.Collections.Generic;
using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Enum;
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
        /// Método que permite buscar la paquetería más económica.
        /// </summary>
        /// <param name="lstPaqueteriaDTO">Lista de paqueterías a comparar sus precios económicos.</param>
        /// <returns>DTO con los datos de la paquetería con el precio más económico.</returns>
        public PaqueteriaDTO BuscarEmpresaPaqueteriaEconomica(List<PaqueteriaDTO> _lstPaqueteriaDTO)
        {
            PaqueteriaDTO dtoPaqueteriaSiguiente = new PaqueteriaDTO();
            PaqueteriaDTO dtoPaqueteriaMenorCosto = new PaqueteriaDTO();
            decimal dDiferenciaCostoEnvio = 0.0M;

            foreach (PaqueteriaDTO dtoPaqueteriaEconomica in _lstPaqueteriaDTO)
            {
                if (dtoPaqueteriaEconomica.cNombreEmpresa != this.dtoPaqueteria.cNombreEmpresa)
                {
                    if (dtoPaqueteriaEconomica.lstNombreMedioTransporte.Contains(this.dtoPaqueteria.cNombreMedioTransporte))
                    {
                        dtoPaqueteriaSiguiente.cNombreEmpresa = dtoPaqueteriaEconomica.cNombreEmpresa;
                        dtoPaqueteriaSiguiente.cNombreLugarOrigen = this.dtoPaqueteria.cNombreLugarOrigen;
                        dtoPaqueteriaSiguiente.cNombreLugarDestino = this.dtoPaqueteria.cNombreLugarDestino;
                        dtoPaqueteriaSiguiente.dDistancia = this.dtoPaqueteria.dDistancia;
                        dtoPaqueteriaSiguiente.cNombreMedioTransporte = this.dtoPaqueteria.cNombreMedioTransporte;
                        dtoPaqueteriaSiguiente.dtPedido = this.dtoPaqueteria.dtPedido;

                        AsignarDatosPaquete srvAsignarDatosPaquete = new AsignarDatosPaquete();
                        dtoPaqueteriaSiguiente = srvAsignarDatosPaquete.AsignarNuevosDatos(dtoPaqueteriaSiguiente);
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

            dtoPaqueteriaMenorCosto.dCostoEnvio = dDiferenciaCostoEnvio;
            return dtoPaqueteriaMenorCosto;
        }

        /// <summary>
        /// Método que permite buscar una lista de empresas de paqueterías.
        /// </summary>
        /// <returns>Lista con los nombres de las empresas de paqueterías.</returns>
        public List<string> BuscarListaEmpresaPaqueteria()
        {
            List<string> lstNombreEmpresaPaqueteria = new List<string>();

            lstNombreEmpresaPaqueteria.Add(EnumEmpresaPaqueteria.DHL.ToString());
            lstNombreEmpresaPaqueteria.Add(EnumEmpresaPaqueteria.Estafeta.ToString());
            lstNombreEmpresaPaqueteria.Add(EnumEmpresaPaqueteria.Fedex.ToString());

            return lstNombreEmpresaPaqueteria;

        }
    }
}
