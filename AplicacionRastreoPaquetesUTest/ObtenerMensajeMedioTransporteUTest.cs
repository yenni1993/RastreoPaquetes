using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class ObtenerMensajeMedioTransporteUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        [DataRow("DHL", "Avion")]
        [DataRow("DHL", "Barco")]
        [DataRow("DHL", "Tren")]
        [DataRow("Estafeta", "Avion")]
        [DataRow("Estafeta", "Barco")]
        [DataRow("Estafeta", "Tren")]
        [DataRow("Fedex", "Avion")]
        [DataRow("Fedex", "Barco")]
        [DataRow("Fedex", "Tren")]
        public void ObtenerMensaje_EnviarEmpresaConTransporteExistente_NoDevuelveMensajeError(string _cNombreEmpresa, string _cMedioTransporte)
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            PaqueteriaDTO paqueteriaDTO = new PaqueteriaDTO() { cNombreEmpresa = _cNombreEmpresa, cNombreMedioTransporte = _cMedioTransporte };
            IObtenerMensaje SUT = new ObtenerMensajeMedioTransporte(paqueteriaDTO, true);
            string cMensaje = string.Empty;

            //Act
            //Método que será sometido a pruebas.
            cMensaje = SUT.ObtenerMensaje();

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(string.IsNullOrWhiteSpace(cMensaje));
        }


        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        [DataRow("DHL", "Avion")]
        [DataRow("DHL", "Barco")]
        [DataRow("DHL", "Tren")]
        [DataRow("Estafeta", "Avion")]
        [DataRow("Estafeta", "Barco")]
        [DataRow("Estafeta", "Tren")]
        [DataRow("Fedex", "Avion")]
        [DataRow("Fedex", "Barco")]
        [DataRow("Fedex", "Tren")]
        public void ObtenerMensaje_EnviarEmpresaConTransporteInexistente_DevuelveMensajeError(string _cNombreEmpresa, string _cMedioTransporte)
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            PaqueteriaDTO paqueteriaDTO = new PaqueteriaDTO() { cNombreEmpresa = _cNombreEmpresa, cNombreMedioTransporte = _cMedioTransporte };
            IObtenerMensaje SUT = new ObtenerMensajeMedioTransporte(paqueteriaDTO, false);
            string cMensajeEsperado = $"{paqueteriaDTO.cNombreEmpresa} no ofrece el servicio de transporte {paqueteriaDTO.cNombreMedioTransporte}, te recomendamos cotizar en otra empresa.";
            string cMensajeActual = string.Empty;

            //Act
            //Método que será sometido a pruebas.
            cMensajeActual = SUT.ObtenerMensaje();

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(cMensajeEsperado, cMensajeActual);
        }
    }
}
