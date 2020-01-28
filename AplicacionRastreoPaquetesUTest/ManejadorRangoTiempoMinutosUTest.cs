using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class ManejadorRangoTiempoMinutosUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerRangoTiempo_MinutoEntregaMinutoActual_DevuelveTotalMinutosTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string SUT = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 50, 00);
            DateTime dtFechaEntrega = new DateTime(2020, 01, 18, 12, 10, 00);
            IManejadorRangoTiempo IManejadorRangoTiempoMinutos = new ManejadorRangoTiempoMinutos();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEntrega);
            SUT = IManejadorRangoTiempoMinutos.ObtenerRangoTiempo(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("40 minutos", SUT);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerRangoTiempo_MinutoEntregaMayorMinutoDiaActual_DevuelveTotalMinutosTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string SUT = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 30, 00);
            DateTime dtFechaEntrega = new DateTime(2020, 01, 22, 12, 50, 00);
            IManejadorRangoTiempo IManejadorRangoTiempoMinutos = new ManejadorRangoTiempoMinutos();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEntrega);
            SUT = IManejadorRangoTiempoMinutos.ObtenerRangoTiempo(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("20 minutos", SUT);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerRangoTiempo_MinutoEntregaIgualMinutoActual_NoDevuelveTotalMinutosTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string SUT = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            DateTime dtFechaEntrega = new DateTime(2020, 01, 18, 04, 00, 00);
            IManejadorRangoTiempo IManejadorRangoTiempoMinutos = new ManejadorRangoTiempoMinutos();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEntrega);
            SUT = IManejadorRangoTiempoMinutos.ObtenerRangoTiempo(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("0 minutos", SUT);
        }
    }
}
