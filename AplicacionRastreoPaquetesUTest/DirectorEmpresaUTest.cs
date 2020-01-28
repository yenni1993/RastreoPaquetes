using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class DirectorEmpresaUTest
    {
        #region [EnviarPaquetePorDhlEnAvion]
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void EnviarPaquetePorDhlEnAvion_CostoKilometroPesoPaqueteDhlAvion_DevuelveCostoKilometroPeso()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IConstructorPaquete IConstructorPaqueteDhlAvion = new ConstructorPaqueteDhlAvion();
            DirectorEmpresa srvDirectorEmpresa = new DirectorEmpresa(IConstructorPaqueteDhlAvion);
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria = CrearPaqueteriaDTO();

            //Act
            //Método que será sometido a pruebas.
            srvDirectorEmpresa.EnviarPaquetePorDhlEnAvion(dtoPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(10, dtoPaqueteria.dCostoKilometroPeso);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void EnviarPaquetePorDhlEnAvion_MargenUtilidadPaqueteDhlAvion_DevuelveMargenUtilidad()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IConstructorPaquete IConstructorPaqueteDhlAvion = new ConstructorPaqueteDhlAvion();
            DirectorEmpresa srvDirectorEmpresa = new DirectorEmpresa(IConstructorPaqueteDhlAvion);
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria = CrearPaqueteriaDTO();

            //Act
            //Método que será sometido a pruebas.
            srvDirectorEmpresa.EnviarPaquetePorDhlEnAvion(dtoPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(40, dtoPaqueteria.dMargenUtilidad);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void EnviarPaquetePorDhlEnAvion_VelocidadEntregaPaqueteDhlAvion_DevuelveVelocidadEntrega()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IConstructorPaquete IConstructorPaqueteDhlAvion = new ConstructorPaqueteDhlAvion();
            DirectorEmpresa srvDirectorEmpresa = new DirectorEmpresa(IConstructorPaqueteDhlAvion);
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria = CrearPaqueteriaDTO();

            //Act
            //Método que será sometido a pruebas.
            srvDirectorEmpresa.EnviarPaquetePorDhlEnAvion(dtoPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(600, dtoPaqueteria.dVelocidadEntrega);
        }
        #endregion

        #region [EnviarPaquetePorDhlEnBarco]
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void EnviarPaquetePorDhlEnBarco_CostoKilometroPesoPaqueteDhlBarco_DevuelveCostoKilometroPeso()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IConstructorPaquete IConstructorPaqueteDhlBarco = new ConstructorPaqueteDhlBarco();
            DirectorEmpresa srvDirectorEmpresa = new DirectorEmpresa(IConstructorPaqueteDhlBarco);
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria = CrearPaqueteriaDTO();

            //Act
            //Método que será sometido a pruebas.
            srvDirectorEmpresa.EnviarPaquetePorDhlEnBarco(dtoPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(1, dtoPaqueteria.dCostoKilometroPeso);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void EnviarPaquetePorDhlEnBarco_MargenUtilidadPaqueteDhlBarco_DevuelveMargenUtilidad()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IConstructorPaquete IConstructorPaqueteDhlBarco = new ConstructorPaqueteDhlBarco();
            DirectorEmpresa srvDirectorEmpresa = new DirectorEmpresa(IConstructorPaqueteDhlBarco);
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria = CrearPaqueteriaDTO();

            //Act
            //Método que será sometido a pruebas.
            srvDirectorEmpresa.EnviarPaquetePorDhlEnBarco(dtoPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(40, dtoPaqueteria.dMargenUtilidad);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void EnviarPaquetePorDhlEnBarco_VelocidadEntregaPaqueteDhlBarco_DevuelveVelocidadEntrega()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IConstructorPaquete IConstructorPaqueteDhlBarco = new ConstructorPaqueteDhlBarco();
            DirectorEmpresa srvDirectorEmpresa = new DirectorEmpresa(IConstructorPaqueteDhlBarco);
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria = CrearPaqueteriaDTO();

            //Act
            //Método que será sometido a pruebas.
            srvDirectorEmpresa.EnviarPaquetePorDhlEnBarco(dtoPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(46, dtoPaqueteria.dVelocidadEntrega);
        }
        #endregion

        #region [EnviarPaquetePorEstafetaEnTren]
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void EnviarPaquetePorEstafetaEnTren_CostoKilometroPesoPaqueteEstafetaTren_DevuelveCostoKilometroPeso()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IConstructorPaquete IConstructorPaqueteEstafetaTren = new ConstructorPaqueteEstafetaTren();
            DirectorEmpresa srvDirectorEmpresa = new DirectorEmpresa(IConstructorPaqueteEstafetaTren);
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria = CrearPaqueteriaDTO();

            //Act
            //Método que será sometido a pruebas.
            srvDirectorEmpresa.EnviarPaquetePorEstafetaEnTren(dtoPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(5, dtoPaqueteria.dCostoKilometroPeso);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void EnviarPaquetePorEstafetaEnTren_MargenUtilidadPaqueteEstafetaTren_DevuelveMargenUtilidad()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IConstructorPaquete IConstructorPaqueteEstafetaTren = new ConstructorPaqueteEstafetaTren();
            DirectorEmpresa srvDirectorEmpresa = new DirectorEmpresa(IConstructorPaqueteEstafetaTren);
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria = CrearPaqueteriaDTO();

            //Act
            //Método que será sometido a pruebas.
            srvDirectorEmpresa.EnviarPaquetePorEstafetaEnTren(dtoPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(20, dtoPaqueteria.dMargenUtilidad);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void EnviarPaquetePorEstafetaEnTren_VelocidadEntregaPaqueteEstafetaTren_DevuelveVelocidadEntrega()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IConstructorPaquete IConstructorPaqueteEstafetaTren = new ConstructorPaqueteEstafetaTren();
            DirectorEmpresa srvDirectorEmpresa = new DirectorEmpresa(IConstructorPaqueteEstafetaTren);
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria = CrearPaqueteriaDTO();

            //Act
            //Método que será sometido a pruebas.
            srvDirectorEmpresa.EnviarPaquetePorEstafetaEnTren(dtoPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(80, dtoPaqueteria.dVelocidadEntrega);
        }
        #endregion

        #region [EnviarPaquetePorFedexEnBarco]
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void EnviarPaquetePorFedexEnBarco_CostoKilometroPesoPaqueteFedexBarco_DevuelveCostoKilometroPeso()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IConstructorPaquete IConstructorPaqueteFedexBarco = new ConstructorPaqueteFedexBarco();
            DirectorEmpresa srvDirectorEmpresa = new DirectorEmpresa(IConstructorPaqueteFedexBarco);
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria = CrearPaqueteriaDTO();

            //Act
            //Método que será sometido a pruebas.
            srvDirectorEmpresa.EnviarPaquetePorFedexEnBarco(dtoPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(1, dtoPaqueteria.dCostoKilometroPeso);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void EnviarPaquetePorFedexEnBarco_MargenUtilidadPaqueteFedexBarco_DevuelveMargenUtilidad()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IConstructorPaquete IConstructorPaqueteFedexBarco = new ConstructorPaqueteFedexBarco();
            DirectorEmpresa srvDirectorEmpresa = new DirectorEmpresa(IConstructorPaqueteFedexBarco);
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria = CrearPaqueteriaDTO();

            //Act
            //Método que será sometido a pruebas.
            srvDirectorEmpresa.EnviarPaquetePorFedexEnBarco(dtoPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(50, dtoPaqueteria.dMargenUtilidad);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void EnviarPaquetePorFedexEnBarco_VelocidadEntregaPaqueteFedexBarco_DevuelveVelocidadEntrega()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            IConstructorPaquete IConstructorPaqueteFedexBarco = new ConstructorPaqueteFedexBarco();
            DirectorEmpresa srvDirectorEmpresa = new DirectorEmpresa(IConstructorPaqueteFedexBarco);
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria = CrearPaqueteriaDTO();

            //Act
            //Método que será sometido a pruebas.
            srvDirectorEmpresa.EnviarPaquetePorFedexEnBarco(dtoPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(46, dtoPaqueteria.dVelocidadEntrega);
        }
        #endregion

        private PaqueteriaDTO CrearPaqueteriaDTO()
        {
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO();
            dtoPaqueteria.dDistancia = 1104;
            dtoPaqueteria.dtPedido = new DateTime(2020, 01, 10, 08, 30, 00);
            return dtoPaqueteria;
        }
    }
}
