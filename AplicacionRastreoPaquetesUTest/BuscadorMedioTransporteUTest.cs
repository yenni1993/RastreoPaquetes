using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class BuscadorMedioTransporteUTest
    {
        #region [BuscarListaMedioTransporteConEmpresa]
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void BuscarListaMedioTransporteConEmpresa_EmpresaDHLConSuMedioTransporte_DevuelveListaConDatosCorrectosPaqueteria()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IBuscadorMedioTransporte IBuscadorMedioTransporte = new BuscadorMedioTransporte();
            List<PaqueteriaDTO> SUT = new List<PaqueteriaDTO>();

            //Act
            //Método que será sometido a pruebas.
            SUT = IBuscadorMedioTransporte.BuscarListaMedioTransporteConEmpresa();

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(SUT.Any()
                && SUT.Where(w => w.cNombreEmpresa == "DHL" 
                && w.lstNombreMedioTransporte.Contains("Avion") 
                && w.lstNombreMedioTransporte.Contains("Barco")).Any());
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void BuscarListaMedioTransporteConEmpresa_EmpresaEstafetaConSuMedioTransporte_DevuelveListaConDatosCorrectosPaqueteria()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IBuscadorMedioTransporte IBuscadorMedioTransporte = new BuscadorMedioTransporte();
            List<PaqueteriaDTO> SUT = new List<PaqueteriaDTO>();

            //Act
            //Método que será sometido a pruebas.
            SUT = IBuscadorMedioTransporte.BuscarListaMedioTransporteConEmpresa();

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(SUT.Any()
                && SUT.Where(w => w.cNombreEmpresa == "Estafeta"
                && w.lstNombreMedioTransporte.Contains("Tren")).Any());
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void BuscarListaMedioTransporteConEmpresa_EmpresaFedexConSuMedioTransporte_DevuelveListaConDatosCorrectosPaqueteria()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IBuscadorMedioTransporte IBuscadorMedioTransporte = new BuscadorMedioTransporte();
            List<PaqueteriaDTO> SUT = new List<PaqueteriaDTO>();

            //Act
            //Método que será sometido a pruebas.
            SUT = IBuscadorMedioTransporte.BuscarListaMedioTransporteConEmpresa();

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(SUT.Any()
                && SUT.Where(w => w.cNombreEmpresa == "Fedex"
                && w.lstNombreMedioTransporte.Contains("Barco")).Any());
        }

        #endregion

        #region [BuscarListaMedioTransportePorEmpresa]
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void BuscarListaMedioTransportePorEmpresa_EmpresaIncorrecta_DevuelveListaNombreMedioTransporteVacia()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IBuscadorMedioTransporte IBuscadorMedioTransporte = new BuscadorMedioTransporte();
            List<string> SUT = new List<string>();

            //Act
            //Método que será sometido a pruebas.
            SUT = IBuscadorMedioTransporte.BuscarListaMedioTransportePorEmpresa("Estafetita");

            //Assert
            //Validación de valores esperados.
            Assert.IsFalse(SUT.Any());
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void BuscarListaMedioTransportePorEmpresa_MedioTransporteEmpresaDHL_DevuelveListaNombreMedioTransporte()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IBuscadorMedioTransporte IBuscadorMedioTransporte = new BuscadorMedioTransporte();
            List<string> SUT = new List<string>();

            //Act
            //Método que será sometido a pruebas.
            SUT = IBuscadorMedioTransporte.BuscarListaMedioTransportePorEmpresa("DHL");

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(SUT.Any() 
                && SUT.Contains("Avion") 
                && SUT.Contains("Barco"));
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void BuscarListaMedioTransportePorEmpresa_MedioTransporteEmpresaEstafeta_DevuelveListaNombreMedioTransporte()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IBuscadorMedioTransporte IBuscadorMedioTransporte = new BuscadorMedioTransporte();
            List<string> SUT = new List<string>();

            //Act
            //Método que será sometido a pruebas.
            SUT = IBuscadorMedioTransporte.BuscarListaMedioTransportePorEmpresa("Estafeta");

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(SUT.Any()
                && SUT.Contains("Tren"));
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void BuscarListaMedioTransportePorEmpresa_MedioTransporteEmpresaFedex_DevuelveListaNombreMedioTransporte()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IBuscadorMedioTransporte IBuscadorMedioTransporte = new BuscadorMedioTransporte();
            List<string> SUT = new List<string>();

            //Act
            //Método que será sometido a pruebas.
            SUT = IBuscadorMedioTransporte.BuscarListaMedioTransportePorEmpresa("Fedex");

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(SUT.Any()
                && SUT.Contains("Barco"));
        }
        #endregion
    }
}
