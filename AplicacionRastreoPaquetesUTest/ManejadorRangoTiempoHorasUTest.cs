using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class ManejadorRangoTiempoHorasUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void AsignarSiguienteRangoTiempo_RangoTiempoDeHorasAMinutos_ValidacionCorrecta()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IManejadorRangoTiempo IManejadorRangoTiempoHoras = new ManejadorRangoTiempoHoras();
            IManejadorRangoTiempo IManejadorRangoTiempoMinutos = new ManejadorRangoTiempoMinutos();

            //Act
            //Método que será sometido a pruebas.
            IManejadorRangoTiempoHoras.AsignarSiguienteRangoTiempo(IManejadorRangoTiempoMinutos);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(true);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerRangoTiempo_HoraEntregaMenorHoraActual_DevuelveTotalHorasTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 16, 00, 00);
            DateTime dtFechaEntrega = new DateTime(2020, 01, 18, 12, 00, 00);
            IManejadorRangoTiempo IManejadorRangoTiempoHoras = new ManejadorRangoTiempoHoras();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEntrega);
            cTiempoTranscurrido = IManejadorRangoTiempoHoras.ObtenerRangoTiempo(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("4 horas", cTiempoTranscurrido);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerRangoTiempo_HoraEntregaMayorHoraActual_DevuelveTotalHorasTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 16, 00, 00);
            DateTime dtFechaEntrega = new DateTime(2020, 01, 18, 22, 00, 00);
            IManejadorRangoTiempo IManejadorRangoTiempoHoras = new ManejadorRangoTiempoHoras();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEntrega);
            cTiempoTranscurrido = IManejadorRangoTiempoHoras.ObtenerRangoTiempo(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("6 horas", cTiempoTranscurrido);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerRangoTiempo_HoraEntregaIgualHoraActual_DevuelveTotalMinutosTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 10, 50, 00);
            DateTime dtFechaEntrega = new DateTime(2020, 01, 18, 10, 20, 00);
            IManejadorRangoTiempo IManejadorRangoTiempoHoras = new ManejadorRangoTiempoHoras();
            IManejadorRangoTiempo IManejadorRangoTiempoMinutos = new ManejadorRangoTiempoMinutos();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEntrega);
            IManejadorRangoTiempoHoras.AsignarSiguienteRangoTiempo(IManejadorRangoTiempoMinutos);
            cTiempoTranscurrido = IManejadorRangoTiempoHoras.ObtenerRangoTiempo(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("30 minutos", cTiempoTranscurrido);
        }
    }
}
