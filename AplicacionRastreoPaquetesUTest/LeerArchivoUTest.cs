using AplicacionRastreoPaquetes.Business.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class LeerArchivoUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void LeerContenidoArchivo_RutaInCorrectaArchivo_NoDevuelveContenidoArchivo()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            ILectorArchivo ILectorArchivo = new AplicacionRastreoPaquetes.Business.Servicio.LeerArchivo();
            List<string> SUT = new List<string>();
            string cRuta = @"C:\RastreoPaquetito123.csv";

            //Act
            //Método que será sometido a pruebas.
            SUT = ILectorArchivo.LeerContenidoArchivo(cRuta);

            //Assert
            //Validación de valores esperados.
            Assert.IsFalse(SUT.Any());
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void LeerContenidoArchivo_RutaCorrectaArchivo_DevuelveContenidoArchivo()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            ILectorArchivo ILectorArchivo = new AplicacionRastreoPaquetes.Business.Servicio.LeerArchivo();
            List<string> SUT = new List<string>();
            string cRuta = @"C:\RastreoPaquete.csv";

            //Act
            //Método que será sometido a pruebas.
            SUT = ILectorArchivo.LeerContenidoArchivo(cRuta);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(SUT.Any());
        }
    }
}
