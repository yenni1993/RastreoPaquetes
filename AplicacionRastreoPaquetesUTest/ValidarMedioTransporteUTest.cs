using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class ValidarMedioTransporteUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ValidarExistenciaMedioTransporte_EnviarMedioTransporteABuscar_NoExisteMedioTransporte()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            bool lExisteMedioTransporte = false;
            IValidadorMedioTransporte SUT = new ValidarMedioTransporte();

            //Act
            //Método que será sometido a pruebas.
            lExisteMedioTransporte = SUT.ValidarExistenciaMedioTranporte(new List<string>() { "Barco", "Tren" }, "Avion");

            //Assert
            //Validación de valores esperados.
            Assert.IsFalse(lExisteMedioTransporte);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ValidarExistenciaMedioTransporte_EnviarMedioTransporteABuscar_ExisteMedioTransporte()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            bool lExisteMedioTransporte = false;
            IValidadorMedioTransporte SUT = new ValidarMedioTransporte();

            //Act
            //Método que será sometido a pruebas.
            lExisteMedioTransporte = SUT.ValidarExistenciaMedioTranporte(new List<string>() { "Barco", "Tren" }, "Barco");

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(lExisteMedioTransporte);
        }
    }
}
