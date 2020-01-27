using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class BuscadorEmpresaPaqueteriaUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        [DataRow("DHL")]
        [DataRow("Estafeta")]
        [DataRow("Fedex")]
        public void BuscadorEmpresaPaqueteriaUTest_EnviarNombreEmpresa_ListaNombreEmpresa(string _cNombreEmpresa)
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            BuscadorEmpresaPaqueteria srvBuscadorEmpresaPaqueteria = new BuscadorEmpresaPaqueteria(null);
            List<string> lstNombreEmpresa = new List<string>();

            //Act
            //Método que será sometido a pruebas.
            lstNombreEmpresa = srvBuscadorEmpresaPaqueteria.BuscarListaEmpresaPaqueteria();

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(lstNombreEmpresa.Any() && lstNombreEmpresa.Contains(_cNombreEmpresa));
        }
    }
}
