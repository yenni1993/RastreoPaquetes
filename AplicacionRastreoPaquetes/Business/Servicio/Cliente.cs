﻿using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            //DTOs.
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            PaqueteriaDTO dtoPaqueteriaActualizado = new PaqueteriaDTO();
            PaqueteriaDTO dtoPaqueteriaEconomica = new PaqueteriaDTO();

            //Interfaces.
            IManejadorRangoTiempo IManejadorRangoTiempoAnios = new ManejadorRangoTiempoAnios();
            IManejadorRangoTiempo IManejadorRangoTiempoBimestre = new ManejadorRangoTiempoBimestres();
            IManejadorRangoTiempo IManejadorRangoTiempoMeses = new ManejadorRangoTiempoMeses();
            IManejadorRangoTiempo IManejadorRangoTiempoSemanas = new ManejadorRangoTiempoSemanas();
            IManejadorRangoTiempo IManejadorRangoTiempoDias = new ManejadorRangoTiempoDias();
            IManejadorRangoTiempo IManejadorRangoTiempoHoras = new ManejadorRangoTiempoHoras();
            IManejadorRangoTiempo IManejadorRangoTiempoMinutos = new ManejadorRangoTiempoMinutos();

            IMedioTransporte ITransporteTren = new TransporteTren() { cNombreMedioTransporte = "Tren", dCostoKmPeso = 5, dVelocidadEntrega = 80 };
            IMedioTransporte ITransporteAvion = new TransporteAvion() { dCostoKmPeso = 10, cNombreMedioTransporte = "Avion", dVelocidadEntrega = 600 };
            IMedioTransporte ITransporteBarco = new TransporteBarco() { dCostoKmPeso = 1, cNombreMedioTransporte = "Barco", dVelocidadEntrega = 46 };
            IEmpresaPaqueteria IEmpresaDHL = new EmpresaDHL() { cNombreEmpresa = "DHL", dMargenUtilidad = 40, lstMediosTransportes = new List<IMedioTransporte>() { ITransporteAvion, ITransporteBarco } };
            IEmpresaPaqueteria IEmpresaEstafeta = new EmpresaEstafeta() { cNombreEmpresa = "Estafeta", dMargenUtilidad = 20, lstMediosTransportes = new List<IMedioTransporte>() { ITransporteTren } };
            IEmpresaPaqueteria IEmpresaFedex = new EmpresaFedex() { cNombreEmpresa = "Fedex", dMargenUtilidad = 50, lstMediosTransportes = new List<IMedioTransporte>() { ITransporteBarco } };

            IBuscadorEmpresaPaqueteria IBuscadorEmpresaPaqueteria;
            IObtenerMensaje IObtenerMensaje;
            IValidadorEmpresaPaqueteria IValidadorEmpresaPaqueteria;
            IValidadorMedioTransporte IValidadorMedioTransporte;
            IFormatoTexto IFormatoTexto = new FormatoTexto();
            IConvertidorFecha IConvertidorFecha = new ConvertidorFecha();
            ICreadorDirectorio ICreadorDirectorio = new CreadorDirectorio();
            ICreadorSubdirectorio ICreadorSubdirectorio = new CreadorSubdirectorio();
            ICreadorArchivo ICreadorArchivo = new CreadorArchivo();
            IEscrituraArchivo IEscrituraArchivoPendiente = new EscrituraArchivo();
            IEscrituraArchivo IEscrituraArchivoEntregado = new EscrituraArchivo();

            //Atributos.
            DirectoryInfo directorioEmpresa = null;
            DirectoryInfo directorioPendiente = null;
            DirectoryInfo directorioEntregado = null;
            List<PaqueteriaDTO> lstPaqueteriaDTO = new List<PaqueteriaDTO>();
            DateTime dtActual;
            TimeSpan tsDiferencia = new TimeSpan();
            List<IEmpresaPaqueteria> lstEmpresaPaqueteria = new List<IEmpresaPaqueteria>();
            string cMensaje = string.Empty;
            bool lExisteEmpresaPaqueteria = false;
            bool lExisteMedioTransporte = false;

            lstEmpresaPaqueteria.Add(IEmpresaDHL);
            lstEmpresaPaqueteria.Add(IEmpresaEstafeta);
            lstEmpresaPaqueteria.Add(IEmpresaFedex);
            ICreadorArchivo.lstArchivo = new List<string>() { "Años.txt", "Bimestre.txt", "Dias.txt", "Horas.txt", "Meses.txt", "Minutos.txt", "Semanas.txt" };

            foreach (string cLineaArchivo in _lstContenidoArchivo)
            {
                if (!string.IsNullOrWhiteSpace(cLineaArchivo))
                {
                    string[] arrLineaArchivoSplit = cLineaArchivo.Split(',');
                    dtActual = IConvertidorFecha.ConvertirFecha("2020/01/23 14:00:00");
                    dtoPaqueteria.cNombreLugarOrigen = arrLineaArchivoSplit[0];
                    dtoPaqueteria.cNombreLugarDestino = arrLineaArchivoSplit[1];
                    dtoPaqueteria.dDistancia = decimal.Parse(arrLineaArchivoSplit[2]);
                    dtoPaqueteria.cNombreEmpresa = IFormatoTexto.AplicarFormato(arrLineaArchivoSplit[3]);
                    dtoPaqueteria.cNombreMedioTransporte = IFormatoTexto.AplicarFormato(arrLineaArchivoSplit[4]);
                    dtoPaqueteria.dtPedido = Convert.ToDateTime(arrLineaArchivoSplit[5]);

                    IValidadorEmpresaPaqueteria = new ValidarEmpresaPaqueteria();
                    lExisteEmpresaPaqueteria = IValidadorEmpresaPaqueteria.ValidarExistenciaEmpresaPaqueteria(lstEmpresaPaqueteria.Select(s => s.cNombreEmpresa).ToList(), dtoPaqueteria.cNombreEmpresa);
                    IObtenerMensaje = new ObtenerMensajeEmpresaPaqueteria(dtoPaqueteria, lExisteEmpresaPaqueteria);
                    cMensaje = IObtenerMensaje.ObtenerMensaje();
                    ColorearMensajeError(cMensaje);
                    IEmpresaPaqueteria IEmpresaPaqueteria = lstEmpresaPaqueteria.Where(w => w.cNombreEmpresa == dtoPaqueteria.cNombreEmpresa).FirstOrDefault();

                    if (string.IsNullOrWhiteSpace(cMensaje))
                    {
                        IValidadorMedioTransporte = new ValidarMedioTransporte();
                        lExisteMedioTransporte = IValidadorMedioTransporte.ValidarExistenciaMedioTranporte(IEmpresaPaqueteria.lstMediosTransportes.Select(s => s.cNombreMedioTransporte).ToList(), dtoPaqueteria.cNombreMedioTransporte);
                        IObtenerMensaje = new ObtenerMensajeMedioTransporte(dtoPaqueteria, lExisteMedioTransporte);
                        cMensaje = IObtenerMensaje.ObtenerMensaje();
                        ColorearMensajeError(cMensaje);
                    }

                    if (string.IsNullOrWhiteSpace(cMensaje))
                    {
                        directorioEmpresa = ICreadorDirectorio.CrearDirectorio(dtoPaqueteria.cNombreEmpresa);
                        directorioPendiente = ICreadorSubdirectorio.CrearSubdDirectorio(directorioEmpresa, "Pendientes");
                        directorioEntregado = ICreadorSubdirectorio.CrearSubdDirectorio(directorioEmpresa, "Entregados");                        
                        ICreadorArchivo.CrearArchivo(directorioPendiente);
                        ICreadorArchivo.CrearArchivo(directorioEntregado);

                        IEmpresaPaqueteria.AsignarNuevosDatos(ref dtoPaqueteria);
                        dtoPaqueteriaActualizado = dtoPaqueteria;
                        tsDiferencia = (dtActual - dtoPaqueteriaActualizado.dtEntrega);

                        IManejadorRangoTiempoAnios.AsignarSiguienteRangoTiempo(IManejadorRangoTiempoBimestre);
                        IManejadorRangoTiempoBimestre.AsignarSiguienteRangoTiempo(IManejadorRangoTiempoMeses);
                        IManejadorRangoTiempoMeses.AsignarSiguienteRangoTiempo(IManejadorRangoTiempoSemanas);
                        IManejadorRangoTiempoSemanas.AsignarSiguienteRangoTiempo(IManejadorRangoTiempoDias);
                        IManejadorRangoTiempoDias.AsignarSiguienteRangoTiempo(IManejadorRangoTiempoHoras);
                        IManejadorRangoTiempoHoras.AsignarSiguienteRangoTiempo(IManejadorRangoTiempoMinutos);
                        dtoPaqueteria.cRangoTiempo = IManejadorRangoTiempoAnios.ObtenerRangoTiempo(tsDiferencia);//Patrón de diseño: Cadena de Responsabilidad.

                        IObtenerMensaje = new ObtenerMensajePaquete(dtoPaqueteriaActualizado, dtActual);
                        cMensaje = IObtenerMensaje.ObtenerMensaje();
                        ColorearMensajePaquete(dtoPaqueteriaActualizado, dtActual, cMensaje);//Patrón de diseño: Estrategia.

                        IBuscadorEmpresaPaqueteria = new BuscadorEmpresaPaqueteria(dtoPaqueteria);
                        dtoPaqueteriaEconomica = IBuscadorEmpresaPaqueteria.BuscarEmpresaPaqueteriaEconomica(lstEmpresaPaqueteria);

                        if (!string.IsNullOrWhiteSpace(dtoPaqueteriaEconomica.cNombreEmpresa))
                        {
                            IObtenerMensaje = new ObtenerMensajeEmpresaPaqueteriaEconomica(dtoPaqueteriaEconomica);
                            cMensaje = IObtenerMensaje.ObtenerMensaje();
                            Console.WriteLine(cMensaje);
                        }

                        if (dtoPaqueteriaActualizado.dtEntrega < dtActual)
                            IEscrituraArchivoEntregado.EscribirAchivo(directorioEntregado, cMensaje);
                        else
                            IEscrituraArchivoPendiente.EscribirAchivo(directorioEntregado, cMensaje);
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
