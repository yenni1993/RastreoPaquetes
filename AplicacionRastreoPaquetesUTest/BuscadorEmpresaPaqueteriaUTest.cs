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
            List<string> lstNombreEmpresa = new List<string>();

            //Act
            //Método que será sometido a pruebas.
            lstNombreEmpresa = IBuscadorEmpresaPaqueteria.BuscarListaEmpresaPaqueteria();

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(lstNombreEmpresa.Any() 
                && lstNombreEmpresa.Contains("DHL")
                && lstNombreEmpresa.Contains("Estafeta")
                && lstNombreEmpresa.Contains("Fedex"));
        }
    }
}
