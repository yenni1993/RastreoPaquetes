using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class ObtenerMensajeEmpresaPaqueteriaUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        [DataRow("DHL")]
        [DataRow("Estafeta")]
        [DataRow("Fedex")]
        public void ObtenerMensaje_EnviarEmpresaExistente_NoDevuelveMensajeError(string _cNombreEmpresa)
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            PaqueteriaDTO paqueteriaDTO = new PaqueteriaDTO() { cNombreEmpresa = _cNombreEmpresa };
            IObtenerMensaje SUT = new ObtenerMensajeEmpresaPaqueteria(paqueteriaDTO, true);
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
        [DataRow("DHL")]
        [DataRow("Estafeta")]
        [DataRow("Fedex")]
        public void ObtenerMensaje_EnviarEmpresaInexistente_DevuelveMensajeError(string _cNombreEmpresa)
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            PaqueteriaDTO paqueteriaDTO = new PaqueteriaDTO() { cNombreEmpresa = _cNombreEmpresa };
            IObtenerMensaje SUT = new ObtenerMensajeEmpresaPaqueteria(paqueteriaDTO, false);
            string cMensajeEsperado = $"La paquetería: {paqueteriaDTO.cNombreEmpresa} no se encuentra registrada en nuestra red de distribución.";
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
