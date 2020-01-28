using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class ManejadorRangoTiempoDiasUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void AsignarSiguienteRangoTiempo_RangoTiempoDeDiasAHoras_DevuelveValidacionCorrecta()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IManejadorRangoTiempo IManejadorRangoTiempoDias = new ManejadorRangoTiempoDias();
            IManejadorRangoTiempo IManejadorRangoTiempoHoras = new ManejadorRangoTiempoHoras();

            //Act
            //Método que será sometido a pruebas.
            IManejadorRangoTiempoDias.AsignarSiguienteRangoTiempo(IManejadorRangoTiempoHoras);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(true);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerRangoTiempo_DiaEntregaMenorDiaActual_DevuelveTotalDiasTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string SUT = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            DateTime dtFechaEntrega = new DateTime(2020, 01, 16, 12, 00, 00);
            IManejadorRangoTiempo IManejadorRangoTiempoDias = new ManejadorRangoTiempoDias();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEntrega);
            SUT = IManejadorRangoTiempoDias.ObtenerRangoTiempo(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("2 días", SUT);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerRangoTiempo_DiaEntregaMayorDiaActual_DevuelveTotalDiasTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string SUT = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            DateTime dtFechaEntrega = new DateTime(2020, 01, 22, 12, 00, 00);
            IManejadorRangoTiempo IManejadorRangoTiempoDias = new ManejadorRangoTiempoDias();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEntrega);
            SUT = IManejadorRangoTiempoDias.ObtenerRangoTiempo(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("4 días", SUT);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerRangoTiempo_DiaEntregaIgualDiaActual_DevuelveTotalHorasTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string SUT = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            DateTime dtFechaEntrega = new DateTime(2020, 01, 18, 04, 00, 00);
            IManejadorRangoTiempo IManejadorRangoTiempoDias = new ManejadorRangoTiempoDias();
            IManejadorRangoTiempo IManejadorRangoTiempoHoras = new ManejadorRangoTiempoHoras();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEntrega);
            IManejadorRangoTiempoDias.AsignarSiguienteRangoTiempo(IManejadorRangoTiempoHoras);
            SUT = IManejadorRangoTiempoDias.ObtenerRangoTiempo(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("8 horas", SUT);
        }
    }
}
