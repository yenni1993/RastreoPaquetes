using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class ConvertidorFechaUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ConvertirFecha_EnviarFechaEnCadenaTexto_ObtenerAnioFechaConvertida()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            DateTime dtFecha = new DateTime();
            IConvertidorFecha SUT = new ConvertidorFecha();

            //Act
            //Método que será sometido a pruebas.
            dtFecha = SUT.ConvertirFecha("2020/02/24");

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(2020, dtFecha.Year);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ConvertirFecha_EnviarFechaEnCadenaTexto_ObtenerMesFechaConvertida()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            DateTime dtFecha = new DateTime();
            IConvertidorFecha SUT = new ConvertidorFecha();

            //Act
            //Método que será sometido a pruebas.
            dtFecha = SUT.ConvertirFecha("2020/02/24");

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(2, dtFecha.Month);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ConvertirFecha_EnviarFechaEnCadenaTexto_ObtenerDiaFechaConvertida()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            DateTime dtFecha = new DateTime();
            IConvertidorFecha SUT = new ConvertidorFecha();

            //Act
            //Método que será sometido a pruebas.
            dtFecha = SUT.ConvertirFecha("2020/02/24");

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(24, dtFecha.Day);
        }
    }
}
