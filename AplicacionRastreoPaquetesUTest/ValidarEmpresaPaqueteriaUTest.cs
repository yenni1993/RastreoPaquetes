using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class ValidarEmpresaPaqueteriaUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ValidarExistenciaEmpresaPaqueteria_EnviarEmpresaABuscar_NoExisteEmpresa()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            bool lExisteEmpresaPaqueteria = false;
            IValidadorEmpresaPaqueteria SUT = new ValidarEmpresaPaqueteria();

            //Act
            //Método que será sometido a pruebas.
            lExisteEmpresaPaqueteria = SUT.ValidarExistenciaEmpresaPaqueteria(new List<string>() { "DHL", "Fedex" }, "Estafeta");

            //Assert
            //Validación de valores esperados.
            Assert.IsFalse(lExisteEmpresaPaqueteria);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ValidarExistenciaEmpresaPaqueteria_EnviarEmpresaABuscar_ExisteEmpresa()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            bool lExisteEmpresaPaqueteria = false;
            IValidadorEmpresaPaqueteria SUT = new ValidarEmpresaPaqueteria();

            //Act
            //Método que será sometido a pruebas.
            lExisteEmpresaPaqueteria = SUT.ValidarExistenciaEmpresaPaqueteria(new List<string>() { "DHL", "Fedex" }, "DHL");

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(lExisteEmpresaPaqueteria);
        }
    }
}
