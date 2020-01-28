using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;
using System;
using System.Collections.Generic;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    /// <summary>
    /// Clase del cliente.
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Método que permite aplicar el rastreo de paquetes.
        /// </summary>
        /// <param name="_lstContenidoArchivo">Lista con el contenido del archivo a leer.</param>
        public void AplicarRastreoPaquete(List<string> _lstContenidoArchivo)
        {
            //DTO.
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            PaqueteriaDTO dtoPaqueteriaActualizado = new PaqueteriaDTO();
            PaqueteriaDTO dtoPaqueteriaEconomica = new PaqueteriaDTO();
            //Servicio.
            ManejadorRangoTiempo srvManejadorRangoTiempoMeses = new ManejadorRangoTiempoMeses();
            ManejadorRangoTiempo srvManejadorRangoTiempoDias = new ManejadorRangoTiempoDias();
            ManejadorRangoTiempo srvManejadorRangoTiempoHoras = new ManejadorRangoTiempoHoras();
            ManejadorRangoTiempo srvManejadorRangoTiempoMinutos = new ManejadorRangoTiempoMinutos();
            //Interface.
            IAsignadorDatosPaquete IAsignadorDatosPaquete;
            IBuscadorEmpresaPaqueteria IBuscadorEmpresaPaqueteria;
            IBuscadorMedioTransporte IBuscadorMedioTransporte;
            IObtenerMensaje IObtenerMensaje;
            IValidadorEmpresaPaqueteria IValidadorEmpresaPaqueteria;
            IValidadorMedioTransporte IValidadorMedioTransporte;
            //Atributos.
            List<PaqueteriaDTO> lstPaqueteriaDTO = new List<PaqueteriaDTO>();
            DateTime dtActual;
            TimeSpan tsDiferencia = new TimeSpan();
            string cMensaje = string.Empty;
            bool lExisteEmpresaPaqueteria = false;
            bool lExisteMedioTransporte = false;

            foreach (string cLineaArchivo in _lstContenidoArchivo)
            {
                if (!string.IsNullOrWhiteSpace(cLineaArchivo))
                {
                    dtActual = DateTime.Now;
                    dtoPaqueteria.cNombreLugarOrigen = cLineaArchivo.Split(',')[0];
                    dtoPaqueteria.cNombreLugarDestino = cLineaArchivo.Split(',')[1];
                    dtoPaqueteria.dDistancia = decimal.Parse(cLineaArchivo.Split(',')[2]);
                    dtoPaqueteria.cNombreEmpresa = cLineaArchivo.Split(',')[3];
                    dtoPaqueteria.cNombreMedioTransporte = cLineaArchivo.Split(',')[4];
                    dtoPaqueteria.dtPedido = Convert.ToDateTime(cLineaArchivo.Split(',')[5]);

                    IBuscadorEmpresaPaqueteria = new BuscadorEmpresaPaqueteria(null);
                    dtoPaqueteria.lstNombreEmpresaPaqueteria = IBuscadorEmpresaPaqueteria.BuscarListaEmpresaPaqueteria();
                    IValidadorEmpresaPaqueteria = new ValidarEmpresaPaqueteria();
                    lExisteEmpresaPaqueteria = IValidadorEmpresaPaqueteria.ValidarExistenciaEmpresaPaqueteria(dtoPaqueteria.lstNombreEmpresaPaqueteria, dtoPaqueteria.cNombreEmpresa);
                    IObtenerMensaje = new ObtenerMensajeEmpresaPaqueteria(dtoPaqueteria, lExisteEmpresaPaqueteria);
                    cMensaje = IObtenerMensaje.ObtenerMensaje();
                    ColorearMensajeError(cMensaje);

                    if (string.IsNullOrWhiteSpace(cMensaje))
                    {

                        IBuscadorMedioTransporte = new BuscadorMedioTransporte();
                        dtoPaqueteria.lstNombreMedioTransporte = IBuscadorMedioTransporte.BuscarListaMedioTransportePorEmpresa(dtoPaqueteria.cNombreEmpresa);
                        IValidadorMedioTransporte = new ValidarMedioTransporte();
                        lExisteMedioTransporte = IValidadorMedioTransporte.ValidarExistenciaMedioTranporte(dtoPaqueteria.lstNombreMedioTransporte, dtoPaqueteria.cNombreMedioTransporte);
                        IObtenerMensaje = new ObtenerMensajeMedioTransporte(dtoPaqueteria, lExisteMedioTransporte);
                        cMensaje = IObtenerMensaje.ObtenerMensaje();
                        ColorearMensajeError(cMensaje);
                    }

                    if (string.IsNullOrWhiteSpace(cMensaje))
                    {
                        IAsignadorDatosPaquete = new AsignarDatosPaquete();
                        dtoPaqueteriaActualizado = IAsignadorDatosPaquete.AsignarNuevosDatos(dtoPaqueteria);//Patrón de diseño: Constructor.

                        tsDiferencia = (dtActual - dtoPaqueteriaActualizado.dtEntrega);
                        srvManejadorRangoTiempoMeses = new ManejadorRangoTiempoMeses();
                        srvManejadorRangoTiempoMeses.AsignarSiguienteRangoTiempo(srvManejadorRangoTiempoDias);
                        dtoPaqueteria.cRangoTiempo = srvManejadorRangoTiempoMeses.ObtenerRangoTiempo(tsDiferencia);//Patrón de diseño: Cadena de Responsabilidad.

                        IObtenerMensaje = new ObtenerMensajePaquete(dtoPaqueteriaActualizado, dtActual);
                        cMensaje = IObtenerMensaje.ObtenerMensaje();
                        ColorearMensajePaquete(dtoPaqueteriaActualizado, dtActual, cMensaje);//Patrón de diseño: Estrategia.

                        IBuscadorMedioTransporte = new BuscadorMedioTransporte();
                        lstPaqueteriaDTO = IBuscadorMedioTransporte.BuscarListaMedioTransporteConEmpresa();
                        IBuscadorEmpresaPaqueteria = new BuscadorEmpresaPaqueteria(dtoPaqueteria);
                        dtoPaqueteriaEconomica = IBuscadorEmpresaPaqueteria.BuscarEmpresaPaqueteriaEconomica(lstPaqueteriaDTO);


                        if (!string.IsNullOrWhiteSpace(dtoPaqueteriaEconomica.cNombreEmpresa))
                        {
                            IObtenerMensaje = new ObtenerMensajeEmpresaPaqueteriaEconomica(dtoPaqueteriaEconomica);
                            cMensaje = IObtenerMensaje.ObtenerMensaje();
                            Console.WriteLine(cMensaje);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Método que permite leer el contenido de un archivo dada la ruta especificada.
        /// </summary>
        /// <param name="_cRuta">Ruta donde se encuentra el archivo.</param>
        /// <returns>Lista con el contenido del archivo.</returns>
        public List<string> LeerArchivo(string _cRuta)
        {
            ILectorArchivo ILectorArchivo = new LeerArchivo();
            string cExtension = string.Empty;
            List<string> lstContenidoArchivo = new List<string>();
            lstContenidoArchivo = ILectorArchivo.LeerContenidoArchivo(_cRuta);
            return lstContenidoArchivo;
        }

        /// <summary>
        /// Método que permite colorear el mensaje que se muestra en el sistema.
        /// </summary>
        /// <param name="_dtoPaquete">DTO con los datos del paquete.</param>
        /// <param name="_dtActual">Fecha del día de hoy.</param>
        /// <param name="_cMensaje">Texto del mensaje que se va a colorear.</param>
        public void ColorearMensajePaquete(PaqueteriaDTO _dtoPaquete, DateTime _dtActual, string _cMensaje)
        {
            if (!string.IsNullOrWhiteSpace(_cMensaje))
            {
                ColorMensaje srvColorMensaje = new ColorMensaje();
                IColorMensaje IColorMensaje;
                string cColorMensajePaquete = string.Empty;

                if (_dtoPaquete.dtEntrega < _dtActual)
                {
                    IColorMensaje = new ColorMensajeVerde();
                    srvColorMensaje.AgregarColorMensaje(IColorMensaje);
                }
                else
                {
                    IColorMensaje = new ColorMensajeAmarillo();
                    srvColorMensaje.AgregarColorMensaje(IColorMensaje);
                }

                srvColorMensaje.ColorearMensaje(_cMensaje);
            }
        }

        /// <summary>
        /// Método que permite colorear el mensaje que se muestra en el sistema.
        /// </summary>
        /// <param name="_cMensaje">Texto del mensaje que se va a colorear.</param>
        public void ColorearMensajeError(string _cMensaje)
        {
            if (!string.IsNullOrWhiteSpace(_cMensaje))
            {
                ColorMensaje srvColorMensaje = new ColorMensaje();
                IColorMensaje IColorMensaje;
                string cColorMensajePaquete = string.Empty;

                IColorMensaje = new ColorMensajeRojo();
                srvColorMensaje.AgregarColorMensaje(IColorMensaje);
                srvColorMensaje.ColorearMensaje(_cMensaje);
            }
        }
    }
}
