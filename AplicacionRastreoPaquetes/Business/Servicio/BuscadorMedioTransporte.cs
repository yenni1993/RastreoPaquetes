using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Enum;
using AplicacionRastreoPaquetes.Business.Interface;
using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class BuscadorMedioTransporte : IBuscadorMedioTransporte
    {
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
