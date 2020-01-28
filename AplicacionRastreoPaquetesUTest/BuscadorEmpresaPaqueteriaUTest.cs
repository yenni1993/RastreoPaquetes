using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class BuscadorEmpresaPaqueteriaUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void BuscarListaEmpresaPaqueteria_EmpresaExistente_DevuelveListaNombreEmpresa()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IBuscadorEmpresaPaqueteria IBuscadorEmpresaPaqueteria = new BuscadorEmpresaPaqueteria(null);
            List<string> SUT = new List<string>();

            //Act
            //Método que será sometido a pruebas.
            SUT = IBuscadorEmpresaPaqueteria.BuscarListaEmpresaPaqueteria();

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(SUT.Any() 
                && SUT.Contains("DHL")
                && SUT.Contains("Estafeta")
                && SUT.Contains("Fedex"));
        }
    }
}
