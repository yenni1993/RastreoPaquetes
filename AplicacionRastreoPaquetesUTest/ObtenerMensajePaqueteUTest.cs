using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class ObtenerMensajePaqueteUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        [DataRow("DHL")]
        [DataRow("Estafeta")]
        [DataRow("Fedex")]
        public void ObtenerMensaje_EnviarFechaEntregaMenorFechaActual_DevuelveMensajeErrorEnPasado(string _cNombreEmpresa)
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            PaqueteriaDTO paqueteriaDTO = CrearPaqueteriaDTO(_cNombreEmpresa, "China", "México", "4 días", 450, new DateTime(2020, 02, 24, 12, 00, 00));
            IObtenerMensaje SUT = new ObtenerMensajePaquete(paqueteriaDTO, new DateTime(2020, 02, 28, 12, 00, 00));
            string cMensajeEsperado = $"Tu paquete salió de {paqueteriaDTO.cNombreLugarOrigen} y llegó a {paqueteriaDTO.cNombreLugarDestino} " +
                $"hace {paqueteriaDTO.cRangoTiempo} y tuvo un costo de ${paqueteriaDTO.dCostoEnvio} " +
                $"(Cualquier reclamación con {paqueteriaDTO.cNombreEmpresa}).";
            string cMensajeActual = string.Empty;

            //Act
            //Método que será sometido a pruebas.
            cMensajeActual = SUT.ObtenerMensaje();

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(cMensajeEsperado, cMensajeActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        [DataRow("DHL")]
        [DataRow("Estafeta")]
        [DataRow("Fedex")]
        public void ObtenerMensaje_EnviarFechaEntregaMayorFechaActual_DevuelveMensajeErrorEnFuturo(string _cNombreEmpresa)
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            PaqueteriaDTO paqueteriaDTO = CrearPaqueteriaDTO(_cNombreEmpresa, "China", "México", "4 días", 450, new DateTime(2020, 02, 28, 12, 00, 00));
            IObtenerMensaje SUT = new ObtenerMensajePaquete(paqueteriaDTO, new DateTime(2020, 02, 24, 12, 00, 00));
            string cMensajeEsperado = $"Tu paquete ha salido de {paqueteriaDTO.cNombreLugarOrigen} y llegará a {paqueteriaDTO.cNombreLugarDestino} " +
                $"dentro de {paqueteriaDTO.cRangoTiempo} y tendrá un costo de ${paqueteriaDTO.dCostoEnvio} " +
                $"(Cualquier reclamación con {paqueteriaDTO.cNombreEmpresa}).";
            string cMensajeActual = string.Empty;

            //Act
            //Método que será sometido a pruebas.
            cMensajeActual = SUT.ObtenerMensaje();

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(cMensajeEsperado, cMensajeActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        [DataRow("DHL")]
        [DataRow("Estafeta")]
        [DataRow("Fedex")]
        public void ObtenerMensaje_EnviarFechaEntregaIgualFechaActual_DevuelveMensajeErrorEnFuturo(string _cNombreEmpresa)
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            PaqueteriaDTO paqueteriaDTO = CrearPaqueteriaDTO(_cNombreEmpresa, "China", "México", "2 horas", 450, new DateTime(2020, 02, 24, 12, 00, 00));
            IObtenerMensaje SUT = new ObtenerMensajePaquete(paqueteriaDTO, new DateTime(2020, 02, 24, 12, 00, 00));
            string cMensajeEsperado = $"Tu paquete ha salido de {paqueteriaDTO.cNombreLugarOrigen} y llegará a {paqueteriaDTO.cNombreLugarDestino} " +
                $"dentro de {paqueteriaDTO.cRangoTiempo} y tendrá un costo de ${paqueteriaDTO.dCostoEnvio} " +
                $"(Cualquier reclamación con {paqueteriaDTO.cNombreEmpresa}).";
            string cMensajeActual = string.Empty;

            //Act
            //Método que será sometido a pruebas.
            cMensajeActual = SUT.ObtenerMensaje();

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(cMensajeEsperado, cMensajeActual);
        }

        /// <summary>
        /// Método que permite crear el DTO con los datos de la paquetería.
        /// </summary>
        /// <param name="_cNombreEmpresa">Nombre de la empresa.</param>
        /// <param name="_cNombreLugarOrigen">Nombre del lugar de origen.</param>
        /// <param name="_cNombreLugarDestino">Nombre del lugar de destino.</param>
        /// <param name="_cRangoTiempo">Rango del tiempo.</param>
        /// <param name="_dCostoEnvio">Costo del envío.</param>
        /// <param name="_dtEntrega">Fecha de entrega.</param>
        /// <returns>DTO con los datos de la paquetería.</returns>
        private PaqueteriaDTO CrearPaqueteriaDTO(string _cNombreEmpresa, string _cNombreLugarOrigen,
            string _cNombreLugarDestino, string _cRangoTiempo, decimal _dCostoEnvio, DateTime _dtEntrega)
        {
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO()
            {
                cNombreEmpresa = _cNombreEmpresa,
                cNombreLugarOrigen = _cNombreLugarOrigen,
                cNombreLugarDestino = _cNombreLugarDestino,
                cRangoTiempo = _cRangoTiempo,
                dCostoEnvio = _dCostoEnvio,
                dtEntrega = _dtEntrega
            };

            return dtoPaqueteria;
        }
    }
}
