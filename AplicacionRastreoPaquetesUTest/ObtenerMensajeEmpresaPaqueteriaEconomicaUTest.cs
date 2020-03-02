using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class ObtenerMensajeEmpresaPaqueteriaEconomicaUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        [DataRow("DHL", 150)]
        [DataRow("Estafeta", 150)]
        [DataRow("Fedex", 150)]
        public void ObtenerMensaje_EnviarEmpresaDHLConCostoEnvio_DevuelveMensajeError(string _cNombreEmpresa, int _iCostoEnvio)
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            PaqueteriaDTO paqueteriaDTO = new PaqueteriaDTO() { cNombreEmpresa = _cNombreEmpresa, dCostoEnvio = Convert.ToDecimal(_iCostoEnvio) };
            IObtenerMensaje SUT = new ObtenerMensajeEmpresaPaqueteriaEconomica(paqueteriaDTO);
            string cMensajeEsperado = $"Si hubieras pedido en {paqueteriaDTO.cNombreEmpresa} te hubiera costado ${paqueteriaDTO.dCostoEnvio} más barato.";
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
