using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class FormatoTextoUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void AplicarFormato_EnviarTextoVacio_NoAplicaFormatoTexto()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTexto = string.Empty;
            IFormatoTexto SUT = new FormatoTexto();

            //Act
            //Método que será sometido a pruebas.
            cTexto = SUT.AplicarFormato(cTexto);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(string.IsNullOrWhiteSpace(cTexto));
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void AplicarFormato_EnviarTextoSinAcento_DevuelveTextoSinAcento()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTextoEsperado = "Avion";
            string cTextoActual = string.Empty;
            IFormatoTexto SUT = new FormatoTexto();

            //Act
            //Método que será sometido a pruebas.
            cTextoActual = SUT.AplicarFormato("Avion");

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(cTextoEsperado, cTextoActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void AplicarFormato_EnviarTextoConAcento_DevuelveTextoSinAcento()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            string cTextoEsperado = "Avion";
            string cTextoActual = string.Empty;
            IFormatoTexto SUT = new FormatoTexto();

            //Act
            //Método que será sometido a pruebas.
            cTextoActual = SUT.AplicarFormato("Avión");

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(cTextoEsperado, cTextoActual);
        }
    }
}
