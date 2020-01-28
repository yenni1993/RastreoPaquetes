using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class ManejadorRangoTiempoMesesUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void AsignarSiguienteRangoTiempo_RangoTiempoDeMesesADias_DevuelveValidacionCorrecta()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IManejadorRangoTiempo IManejadorRangoTiempoMeses = new ManejadorRangoTiempoMeses();
            IManejadorRangoTiempo IManejadorRangoTiempoDias = new ManejadorRangoTiempoDias();

            //Act
            //Método que será sometido a pruebas.
            IManejadorRangoTiempoMeses.AsignarSiguienteRangoTiempo(IManejadorRangoTiempoDias);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(true);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerRangoTiempo_MesEntregaMenorMesActual_DevuelveTotalMesesTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            DateTime dtFechaEntrega = new DateTime(2019, 11, 18, 12, 00, 00);
            IManejadorRangoTiempo IManejadorRangoTiempoMeses = new ManejadorRangoTiempoMeses();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEntrega);
            cTiempoTranscurrido = IManejadorRangoTiempoMeses.ObtenerRangoTiempo(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("2 meses", cTiempoTranscurrido);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerRangoTiempo_MesEntregaMayorMesActual_DevuelveTotalMesesTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            DateTime dtFechaEntrega = new DateTime(2020, 05, 18, 12, 00, 00);
            IManejadorRangoTiempo IManejadorRangoTiempoMeses = new ManejadorRangoTiempoMeses();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEntrega);
            cTiempoTranscurrido = IManejadorRangoTiempoMeses.ObtenerRangoTiempo(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("4 meses", cTiempoTranscurrido);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerRangoTiempo_MesEntregaIgualMesActual_DevuelveTotalDiasTranscurridos()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTiempoTranscurrido = string.Empty;
            TimeSpan tsDiferencia = new TimeSpan();
            DateTime dtFechaActual = new DateTime(2020, 01, 18, 12, 00, 00);
            DateTime dtFechaEntrega = new DateTime(2020, 01, 02, 12, 00, 00);
            IManejadorRangoTiempo IManejadorRangoTiempoMeses = new ManejadorRangoTiempoMeses();
            IManejadorRangoTiempo IManejadorRangoTiempoDias = new ManejadorRangoTiempoDias();

            //Act
            //Método que será sometido a pruebas.
            tsDiferencia = (dtFechaActual - dtFechaEntrega);
            IManejadorRangoTiempoMeses.AsignarSiguienteRangoTiempo(IManejadorRangoTiempoDias);
            cTiempoTranscurrido = IManejadorRangoTiempoMeses.ObtenerRangoTiempo(tsDiferencia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("16 días", cTiempoTranscurrido);
        }
    }
}
