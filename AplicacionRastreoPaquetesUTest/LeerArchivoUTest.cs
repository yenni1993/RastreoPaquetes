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
            ILectorArchivo SUT = new AplicacionRastreoPaquetes.Business.Servicio.LeerArchivo();
            List<string> lstContenidoArchivo = new List<string>();
            string cRuta = @"C:\RastreoPaquetito123.csv";

            //Act
            //Método que será sometido a pruebas.
            lstContenidoArchivo = SUT.LeerContenidoArchivo(cRuta);

            //Assert
            //Validación de valores esperados.
            Assert.IsFalse(lstContenidoArchivo.Any());
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void LeerContenidoArchivo_RutaCorrectaArchivo_DevuelveContenidoArchivo()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            ILectorArchivo SUT = new AplicacionRastreoPaquetes.Business.Servicio.LeerArchivo();
            List<string> lstContenidoArchivo = new List<string>();
            string cRuta = @"C:\RastreoPaquete.csv";

            //Act
            //Método que será sometido a pruebas.
            lstContenidoArchivo = SUT.LeerContenidoArchivo(cRuta);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(lstContenidoArchivo.Any());
        }
    }
}
