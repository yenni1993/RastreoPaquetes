using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Enum;
using AplicacionRastreoPaquetes.Business.Interface;
using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase que permite buscar medios de transporte y que implementa de la interface IBuscadorMedioTransporte.
    /// </summary>
    public class BuscadorMedioTransporte : IBuscadorMedioTransporte
    {
        /// <summary>
        /// Método que permite buscar un listado de medios de transporte.
        /// </summary>
        /// <returns>Lista DTO con los datos de la paquetería y sus medios de transporte.</returns>
        public List<PaqueteriaDTO> BuscarListaMedioTransporteConEmpresa()
        {
            List<PaqueteriaDTO> lstPaqueteriaDTO = new List<PaqueteriaDTO>();

            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria.lstNombreMedioTransporte = new List<string>();
            dtoPaqueteria.cNombreEmpresa = EnumEmpresaPaqueteria.DHL.ToString();
            dtoPaqueteria.lstNombreMedioTransporte.Add(EnumMedioTransporte.Avion.ToString());
            dtoPaqueteria.lstNombreMedioTransporte.Add(EnumMedioTransporte.Barco.ToString());
            lstPaqueteriaDTO.Add(dtoPaqueteria);

            dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria.lstNombreMedioTransporte = new List<string>();
            dtoPaqueteria.cNombreEmpresa = EnumEmpresaPaqueteria.Estafeta.ToString();
            dtoPaqueteria.lstNombreMedioTransporte.Add(EnumMedioTransporte.Tren.ToString());
            lstPaqueteriaDTO.Add(dtoPaqueteria);

            dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria.lstNombreMedioTransporte = new List<string>();
            dtoPaqueteria.cNombreEmpresa = EnumEmpresaPaqueteria.Fedex.ToString();
            dtoPaqueteria.lstNombreMedioTransporte.Add(EnumMedioTransporte.Barco.ToString());
            lstPaqueteriaDTO.Add(dtoPaqueteria);

            return lstPaqueteriaDTO;
        }

        /// <summary>
        /// Método que permite buscar un listado de medios de transporte por empresa de paquetería.
        /// </summary>
        /// <param name="_cNombreEmpresa">Nombre de la empresa de paquetería.</param>
        /// <returns>Lista de nombres de medios de transporte.</returns>
        public List<string> BuscarListaMedioTransportePorEmpresa(string _cNombreEmpresa)
        {
            List<string> lstNombreMedioTransporte = new List<string>();

            switch (_cNombreEmpresa)
            {
                case "DHL":
                    lstNombreMedioTransporte.Add(EnumMedioTransporte.Avion.ToString());
                    lstNombreMedioTransporte.Add(EnumMedioTransporte.Barco.ToString());
                    break;

                case "Estafeta":
                    lstNombreMedioTransporte.Add(EnumMedioTransporte.Tren.ToString());
                    break;

                case "Fedex":
                    lstNombreMedioTransporte.Add(EnumMedioTransporte.Barco.ToString());
                    break;
            }

            return lstNombreMedioTransporte;
        }
    }
}
