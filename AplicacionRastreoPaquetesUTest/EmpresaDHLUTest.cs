using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class EmpresaDHLUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerCostoEnvio_EnviarDistanciaCostoKmPesoYMargenUtilidadCorrectos_ObtenerMismoCostoActualAlCostoEsperado()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            decimal dDistancia = 50000;
            decimal dCostoEnvioEsperado = 0.0M;
            decimal dCostoEnvioActual = 0.0M;
            IEmpresaPaqueteria SUT = new EmpresaDHL();
            SUT.IMedioTransporte = new TransporteAvion();
            SUT.dMargenUtilidad = 40;
            SUT.IMedioTransporte.dCostoKmPeso = 10;
            dCostoEnvioEsperado = CalcularCostoEnvio(dDistancia, SUT.IMedioTransporte.dCostoKmPeso, SUT.dMargenUtilidad);

            //Act
            //Método que será sometido a pruebas.
            dCostoEnvioActual = SUT.ObtenerCostoEnvio(dDistancia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(dCostoEnvioEsperado, dCostoEnvioActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerCostoEnvio_EnviarDistanciaIncorrecta_ObtenerDiferenteCostoActualAlCostoEsperado()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            decimal dDistancia = 50000;
            decimal dCostoEnvioEsperado = 0.0M;
            decimal dCostoEnvioActual = 0.0M;
            IEmpresaPaqueteria SUT = new EmpresaDHL();
            SUT.IMedioTransporte = new TransporteAvion();
            SUT.dMargenUtilidad = 40;
            SUT.IMedioTransporte.dCostoKmPeso = 10;
            dCostoEnvioEsperado = CalcularCostoEnvio(20000, SUT.IMedioTransporte.dCostoKmPeso, SUT.dMargenUtilidad);

            //Act
            //Método que será sometido a pruebas.
            dCostoEnvioActual = SUT.ObtenerCostoEnvio(dDistancia);

            //Assert
            //Validación de valores esperados.
            Assert.AreNotEqual(dCostoEnvioEsperado, dCostoEnvioActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerCostoEnvio_EnviarCostoKmPesoIncorrecto_ObtenerDiferenteCostoActualAlCostoEsperado()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            decimal dDistancia = 50000;
            decimal dCostoEnvioEsperado = 0.0M;
            decimal dCostoEnvioActual = 0.0M;
            IEmpresaPaqueteria SUT = new EmpresaDHL();
            SUT.IMedioTransporte = new TransporteAvion();
            SUT.dMargenUtilidad = 40;
            SUT.IMedioTransporte.dCostoKmPeso = 10;
            dCostoEnvioEsperado = CalcularCostoEnvio(dDistancia, 20, SUT.dMargenUtilidad);

            //Act
            //Método que será sometido a pruebas.
            dCostoEnvioActual = SUT.ObtenerCostoEnvio(dDistancia);

            //Assert
            //Validación de valores esperados.
            Assert.AreNotEqual(dCostoEnvioEsperado, dCostoEnvioActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerCostoEnvio_EnviarMargenUtilidadIncorrecta_ObtenerDiferenteCostoActualAlCostoEsperado()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            decimal dDistancia = 50000;
            decimal dCostoEnvioEsperado = 0.0M;
            decimal dCostoEnvioActual = 0.0M;
            IEmpresaPaqueteria SUT = new EmpresaDHL();
            SUT.IMedioTransporte = new TransporteAvion();
            SUT.dMargenUtilidad = 40;
            SUT.IMedioTransporte.dCostoKmPeso = 10;
            dCostoEnvioEsperado = CalcularCostoEnvio(dDistancia, SUT.IMedioTransporte.dCostoKmPeso, 60);

            //Act
            //Método que será sometido a pruebas.
            dCostoEnvioActual = SUT.ObtenerCostoEnvio(dDistancia);

            //Assert
            //Validación de valores esperados.
            Assert.AreNotEqual(dCostoEnvioEsperado, dCostoEnvioActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerCostoEnvio_EnviarDistanciaCostoKmPesoYMargenUtilidadIncorrectos_ObtenerDiferenteCostoActualAlCostoEsperado()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            decimal dDistancia = 50000;
            decimal dCostoEnvioEsperado = 0.0M;
            decimal dCostoEnvioActual = 0.0M;
            IEmpresaPaqueteria SUT = new EmpresaDHL();
            SUT.IMedioTransporte = new TransporteAvion();
            SUT.dMargenUtilidad = 40;
            SUT.IMedioTransporte.dCostoKmPeso = 10;
            dCostoEnvioEsperado = CalcularCostoEnvio(20000, 20, 60);

            //Act
            //Método que será sometido a pruebas.
            dCostoEnvioActual = SUT.ObtenerCostoEnvio(dDistancia);

            //Assert
            //Validación de valores esperados.
            Assert.AreNotEqual(dCostoEnvioEsperado, dCostoEnvioActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerFechaEntrega_AumentarHorasFechaPedido_ObtenerFechaPedidoConHorasExtras()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            DateTime dtFechaEntregaEsperado = new DateTime(2020, 02, 24, 10, 15, 00);
            DateTime dtFechaEntregaActual = new DateTime();
            IEmpresaPaqueteria SUT = new EmpresaDHL();

            //Act
            //Método que será sometido a pruebas.
            dtFechaEntregaActual = SUT.ObtenerFechaEntrega(new DateTime(2020, 02, 24, 8, 15, 00), new TimeSpan(2, 00, 00));

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(dtFechaEntregaEsperado, dtFechaEntregaActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerFechaEntrega_AumentarMinutosFechaPedido_ObtenerFechaPedidoConMinutosExtras()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            DateTime dtFechaEntregaEsperado = new DateTime(2020, 02, 24, 10, 55, 00);
            DateTime dtFechaEntregaActual = new DateTime();
            IEmpresaPaqueteria SUT = new EmpresaDHL();

            //Act
            //Método que será sometido a pruebas.
            dtFechaEntregaActual = SUT.ObtenerFechaEntrega(new DateTime(2020, 02, 24, 10, 15, 00), new TimeSpan(00, 40, 00));

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(dtFechaEntregaEsperado, dtFechaEntregaActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerFechaEntrega_AumentarSegundosFechaPedido_ObtenerFechaPedidoConSegundosExtras()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            DateTime dtFechaEntregaEsperado = new DateTime(2020, 02, 24, 10, 15, 58);
            DateTime dtFechaEntregaActual = new DateTime();
            IEmpresaPaqueteria SUT = new EmpresaDHL();

            //Act
            //Método que será sometido a pruebas.
            dtFechaEntregaActual = SUT.ObtenerFechaEntrega(new DateTime(2020, 02, 24, 10, 15, 00), new TimeSpan(00, 00, 58));

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(dtFechaEntregaEsperado, dtFechaEntregaActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerFechaEntrega_AumentarHorasMinutosSegundosFechaPedido_ObtenerFechaPedidoConHorasMinutosSegundosExtras()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            DateTime dtFechaEntregaEsperado = new DateTime(2020, 02, 24, 11, 35, 40);
            DateTime dtFechaEntregaActual = new DateTime();
            IEmpresaPaqueteria SUT = new EmpresaDHL();

            //Act
            //Método que será sometido a pruebas.
            dtFechaEntregaActual = SUT.ObtenerFechaEntrega(new DateTime(2020, 02, 24, 10, 15, 00), new TimeSpan(1, 20, 40));

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(dtFechaEntregaEsperado, dtFechaEntregaActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTraslado_EnviarDistanciaYVelocidadEntregaCorrectos_ObtenerMismoTiempoEsperadoAlTiempoActual()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            decimal dDistancia = 50000;
            TimeSpan tsTiempoTrasladoEsperado = new TimeSpan();
            TimeSpan tsTiempoTrasladoActual = new TimeSpan();
            IEmpresaPaqueteria SUT = new EmpresaDHL();
            SUT.IMedioTransporte = new TransporteAvion();
            SUT.IMedioTransporte.dVelocidadEntrega = 600;
            tsTiempoTrasladoEsperado = CalcularTiempoTraslado(dDistancia, SUT.IMedioTransporte.dVelocidadEntrega);

            //Act
            //Método que será sometido a pruebas.
            tsTiempoTrasladoActual = SUT.ObtenerTiempoTraslado(dDistancia);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual(tsTiempoTrasladoEsperado, tsTiempoTrasladoActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTraslado_EnviarDistanciaIncorrecta_ObtenerDiferenteTiempoEsperadoAlTiempoActual()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            decimal dDistancia = 50000;      
            TimeSpan tsTiempoTrasladoEsperado = new TimeSpan();
            TimeSpan tsTiempoTrasladoActual = new TimeSpan();
            IEmpresaPaqueteria SUT = new EmpresaDHL();
            SUT.IMedioTransporte = new TransporteAvion();
            SUT.IMedioTransporte.dVelocidadEntrega = 600;
            tsTiempoTrasladoEsperado = CalcularTiempoTraslado(30000, SUT.IMedioTransporte.dVelocidadEntrega);

            //Act
            //Método que será sometido a pruebas.
            tsTiempoTrasladoActual = SUT.ObtenerTiempoTraslado(dDistancia);

            //Assert
            //Validación de valores esperados.
            Assert.AreNotEqual(tsTiempoTrasladoEsperado, tsTiempoTrasladoActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTraslado_EnviarVelocidadEntregaIncorrecta_ObtenerDiferenteTiempoEsperadoAlTiempoActual()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            decimal dDistancia = 50000;
            TimeSpan tsTiempoTrasladoEsperado = new TimeSpan();
            TimeSpan tsTiempoTrasladoActual = new TimeSpan();
            IEmpresaPaqueteria SUT = new EmpresaDHL();
            SUT.IMedioTransporte = new TransporteAvion();
            SUT.IMedioTransporte.dVelocidadEntrega = 600;
            tsTiempoTrasladoEsperado = CalcularTiempoTraslado(dDistancia, 400);

            //Act
            //Método que será sometido a pruebas.
            tsTiempoTrasladoActual = SUT.ObtenerTiempoTraslado(dDistancia);

            //Assert
            //Validación de valores esperados.
            Assert.AreNotEqual(tsTiempoTrasladoEsperado, tsTiempoTrasladoActual);
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void ObtenerTiempoTraslado_EnviarDistanciaYVelocidadEntregaIncorrectos_ObtenerDiferenteTiempoEsperadoAlTiempoActual()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            decimal dDistancia = 50000;
            TimeSpan tsTiempoTrasladoEsperado = new TimeSpan();
            TimeSpan tsTiempoTrasladoActual = new TimeSpan();
            IEmpresaPaqueteria SUT = new EmpresaDHL();
            SUT.IMedioTransporte = new TransporteAvion();
            SUT.IMedioTransporte.dVelocidadEntrega = 600;
            tsTiempoTrasladoEsperado = CalcularTiempoTraslado(30000, 400);

            //Act
            //Método que será sometido a pruebas.
            tsTiempoTrasladoActual = SUT.ObtenerTiempoTraslado(dDistancia);

            //Assert
            //Validación de valores esperados.
            Assert.AreNotEqual(tsTiempoTrasladoEsperado, tsTiempoTrasladoActual);
        }

        /// <summary>
        /// Método que permite calcular el costo de envío de una empresa con su medio de transporte.
        /// </summary>
        /// <param name="_dDistancia">Distancia que existe entre un medio de transporte a otro.</param>
        /// <param name="dCostoKmPeso">Costo de envío por kilómetro en pesos de un paquete.</param>
        /// <param name="_dMargenUtilidad">Margen de utilidad entre el precio de venta y los costos fijos de una empresa de paquetería.</param>
        /// <returns>Cálculo del costo de envío.</returns>
        private decimal CalcularCostoEnvio(decimal _dDistancia, decimal dCostoKmPeso, decimal _dMargenUtilidad)
        {
            decimal dCostoEnvio = 0.0M;
            dCostoEnvio = (dCostoKmPeso * _dDistancia) * (1 + (_dMargenUtilidad / 100));
            return dCostoEnvio;
        }

        /// <summary>
        /// Método que permite calcular el tiempo de traslado de un paquete.
        /// </summary>
        /// <param name="_dDistancia">Distancia que existe entre un medio de transporte a otro.</param>
        /// <param name="dVelocidadEntrega">Velocidad de entrega que recorre un medio de transporte.</param>
        /// <returns>Cálculo del tiempo de traslado.</returns>
        private TimeSpan CalcularTiempoTraslado(decimal _dDistancia, decimal dVelocidadEntrega)
        {
            double dbTiempoTraslado = 0;
            TimeSpan tsTiempoTraslado = new TimeSpan();
            dbTiempoTraslado = Convert.ToDouble(_dDistancia) / Convert.ToDouble(dVelocidadEntrega);
            tsTiempoTraslado = TimeSpan.FromSeconds(dbTiempoTraslado);
            return tsTiempoTraslado;
        }
    }
}
