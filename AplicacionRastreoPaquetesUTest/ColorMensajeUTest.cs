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
        public void AgregarColorMensaje_ColorAmarilloMensaje_AsignarColorAmarilloMensaje()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IColorMensaje IColorMensaje = new ColorMensajeAmarillo();
            ColorMensaje srvColorMensaje = new ColorMensaje();
            string cMensaje = "Color Amarillo";

            //Act
            //Método que será sometido a pruebas.
            srvColorMensaje.AgregarColorMensaje(IColorMensaje);
            srvColorMensaje.ColorearMensaje(cMensaje);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(true);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void AgregarColorMensaje_ColorRojoMensaje_AsignarColorRojoMensaje()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IColorMensaje IColorMensaje = new ColorMensajeRojo();
            ColorMensaje srvColorMensaje = new ColorMensaje();
            string cMensaje = "Color Rojo";

            //Act
            //Método que será sometido a pruebas.
            srvColorMensaje.AgregarColorMensaje(IColorMensaje);
            srvColorMensaje.ColorearMensaje(cMensaje);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(true);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void AgregarColorMensaje_ColorVerdeMensaje_AsignarColorVerdeMensaje()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IColorMensaje IColorMensaje = new ColorMensajeVerde();
            ColorMensaje srvColorMensaje = new ColorMensaje();
            string cMensaje = "Color Verde";

            //Act
            //Método que será sometido a pruebas.
            srvColorMensaje.AgregarColorMensaje(IColorMensaje);
            srvColorMensaje.ColorearMensaje(cMensaje);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(true);
        }
    }
}
