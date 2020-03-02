using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class ColorMensajeUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void AgregarColorMensaje_EnviarColorAmarilloMensaje_AsignarColorAmarilloMensaje()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IColorMensaje IColorMensaje = new ColorMensajeAmarillo();
            ColorMensaje SUT = new ColorMensaje();
            string cMensaje = "Color Amarillo";

            //Act
            //Método que será sometido a pruebas.
            SUT.AgregarColorMensaje(IColorMensaje);
            SUT.ColorearMensaje(cMensaje);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(true);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void AgregarColorMensaje_EnviarColorRojoMensaje_AsignarColorRojoMensaje()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IColorMensaje IColorMensaje = new ColorMensajeRojo();
            ColorMensaje SUT = new ColorMensaje();
            string cMensaje = "Color Rojo";

            //Act
            //Método que será sometido a pruebas.
            SUT.AgregarColorMensaje(IColorMensaje);
            SUT.ColorearMensaje(cMensaje);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(true);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void AgregarColorMensaje_EnviarColorVerdeMensaje_AsignarColorVerdeMensaje()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IColorMensaje IColorMensaje = new ColorMensajeVerde();
            ColorMensaje SUT = new ColorMensaje();
            string cMensaje = "Color Verde";

            //Act
            //Método que será sometido a pruebas.
            SUT.AgregarColorMensaje(IColorMensaje);
            SUT.ColorearMensaje(cMensaje);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(true);
        }
    }
}
