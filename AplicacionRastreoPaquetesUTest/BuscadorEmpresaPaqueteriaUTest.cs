using AplicacionRastreoPaquetes.Business.DTO;
using AplicacionRastreoPaquetes.Business.Interface;
using AplicacionRastreoPaquetes.Business.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AplicacionRastreoPaquetesUTest
{
    [TestClass]
    public class BuscadorEmpresaPaqueteriaUTest
    {
        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void BuscarEmpresaPaqueteriaEconomica_EnviarEmpresaDHLConAvion_NoDevuelveOtraEmpresaMasEconomicaConAvion()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            decimal dDistancia = 50000;
            decimal dCostoEnvio = CalcularCostoEnvio(dDistancia, 10, 40);
            PaqueteriaDTO paqueteriaDTO = CrearPaqueteriaDTO("DHL", "Avión", "China", "México", dDistancia, dCostoEnvio, new DateTime(2020, 02, 24, 12, 00, 00));
            IBuscadorEmpresaPaqueteria SUT = new BuscadorEmpresaPaqueteria(paqueteriaDTO);
            List<IEmpresaPaqueteria> lstEmpresaPaqueteria = new List<IEmpresaPaqueteria>();
            lstEmpresaPaqueteria.Add(CrearEmpresaPaqueteriaDHL());
            lstEmpresaPaqueteria.Add(CrearEmpresaPaqueteriaEstafeta());
            lstEmpresaPaqueteria.Add(CrearEmpresaPaqueteriaFedex());

            //Act
            //Método que será sometido a pruebas.
            paqueteriaDTO = SUT.BuscarEmpresaPaqueteriaEconomica(lstEmpresaPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(string.IsNullOrWhiteSpace(paqueteriaDTO.cNombreEmpresa));
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void BuscarEmpresaPaqueteriaEconomica_EnviarEmpresaDHLConBarco_NoDevuelveOtraEmpresaMasEconomicaConBarco()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            decimal dDistancia = 50000;
            decimal dCostoEnvio = CalcularCostoEnvio(dDistancia, 1, 40);
            PaqueteriaDTO paqueteriaDTO = CrearPaqueteriaDTO("DHL", "Barco", "China", "México", dDistancia, dCostoEnvio, new DateTime(2020, 02, 24, 12, 00, 00));
            IBuscadorEmpresaPaqueteria SUT = new BuscadorEmpresaPaqueteria(paqueteriaDTO);
            List<IEmpresaPaqueteria> lstEmpresaPaqueteria = new List<IEmpresaPaqueteria>();
            lstEmpresaPaqueteria.Add(CrearEmpresaPaqueteriaDHL());
            lstEmpresaPaqueteria.Add(CrearEmpresaPaqueteriaEstafeta());
            lstEmpresaPaqueteria.Add(CrearEmpresaPaqueteriaFedex());

            //Act
            //Método que será sometido a pruebas.
            paqueteriaDTO = SUT.BuscarEmpresaPaqueteriaEconomica(lstEmpresaPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(string.IsNullOrWhiteSpace(paqueteriaDTO.cNombreEmpresa));
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void BuscarEmpresaPaqueteriaEconomica_EnviarEmpresaEstafetaConTren_NoDevuelveOtraEmpresaMasEconomicaConTren()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            decimal dDistancia = 50000;
            decimal dCostoEnvio = CalcularCostoEnvio(dDistancia, 5, 20);
            PaqueteriaDTO paqueteriaDTO = CrearPaqueteriaDTO("Estafeta", "Tren", "China", "México", dDistancia, dCostoEnvio, new DateTime(2020, 02, 24, 12, 00, 00));
            IBuscadorEmpresaPaqueteria SUT = new BuscadorEmpresaPaqueteria(paqueteriaDTO);
            List<IEmpresaPaqueteria> lstEmpresaPaqueteria = new List<IEmpresaPaqueteria>();
            lstEmpresaPaqueteria.Add(CrearEmpresaPaqueteriaDHL());
            lstEmpresaPaqueteria.Add(CrearEmpresaPaqueteriaEstafeta());
            lstEmpresaPaqueteria.Add(CrearEmpresaPaqueteriaFedex());

            //Act
            //Método que será sometido a pruebas.
            paqueteriaDTO = SUT.BuscarEmpresaPaqueteriaEconomica(lstEmpresaPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.IsTrue(string.IsNullOrWhiteSpace(paqueteriaDTO.cNombreEmpresa));
        }

        [TestMethod]
        [TestCategory("Pruebas Unitarias")]
        public void BuscarEmpresaPaqueteriaEconomica_EnviarEmpresaFedexConBarco_DevuelveEmpresaDHLMasEconomicaConBarco()
        {
            //Arrange
            //Variables necesarias para realizar las pruebas.
            decimal dDistancia = 50000;
            decimal dCostoEnvio = CalcularCostoEnvio(dDistancia, 1, 50);
            PaqueteriaDTO paqueteriaDTO = CrearPaqueteriaDTO("Fedex", "Barco", "China", "México", dDistancia, dCostoEnvio, new DateTime(2020, 02, 24, 12, 00, 00));
            IBuscadorEmpresaPaqueteria SUT = new BuscadorEmpresaPaqueteria(paqueteriaDTO);
            List<IEmpresaPaqueteria> lstEmpresaPaqueteria = new List<IEmpresaPaqueteria>();
            lstEmpresaPaqueteria.Add(CrearEmpresaPaqueteriaDHL());
            lstEmpresaPaqueteria.Add(CrearEmpresaPaqueteriaEstafeta());
            lstEmpresaPaqueteria.Add(CrearEmpresaPaqueteriaFedex());

            //Act
            //Método que será sometido a pruebas.
            paqueteriaDTO = SUT.BuscarEmpresaPaqueteriaEconomica(lstEmpresaPaqueteria);

            //Assert
            //Validación de valores esperados.
            Assert.AreEqual("DHL", paqueteriaDTO.cNombreEmpresa);
        }
        
        /// <summary>
        /// Método que permite crear el DTO con los datos de la paquetería.
        /// </summary>
        /// <param name="_cNombreEmpresa">Nombre de la empresa.</param>
        /// <param name="_cNombreMedioTransporte">Nombre del medio de transporte.</param>
        /// <param name="_cNombreLugarOrigen">Nombre del lugar de origen.</param>
        /// <param name="_cNombreLugarDestino">Nombre del lugar de destino.</param>
        /// <param name="_dDistancia">Distancia recorrida.</param>
        /// <param name="_dCostoEnvio">Costo del envío.</param>
        /// <param name="_dtPedido">Fecha del pedido.</param>
        /// <returns>DTO con los datos de la paquetería.</returns>
        private PaqueteriaDTO CrearPaqueteriaDTO(string _cNombreEmpresa, string _cNombreMedioTransporte, string _cNombreLugarOrigen, 
            string _cNombreLugarDestino, decimal _dDistancia, decimal _dCostoEnvio, DateTime _dtPedido)
        {
            PaqueteriaDTO dtoPaqueteria = new PaqueteriaDTO()
            {
                cNombreEmpresa = _cNombreEmpresa,
                cNombreMedioTransporte = _cNombreMedioTransporte,
                cNombreLugarOrigen = _cNombreLugarOrigen,
                cNombreLugarDestino = _cNombreLugarDestino,
                dDistancia = _dDistancia,
                dCostoEnvio = _dCostoEnvio,
                dtPedido = _dtPedido
            };

            return dtoPaqueteria;
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
        /// Método que permite crear la empresa de paquetería DHL.
        /// </summary>
        /// <returns>Interface de empresa de paquetería.</returns>
        private IEmpresaPaqueteria CrearEmpresaPaqueteriaDHL()
        {
            IEmpresaPaqueteria IEmpresaPaqueteria = new EmpresaDHL()
            {
                cNombreEmpresa = "DHL",
                dMargenUtilidad = 40,
                lstMediosTransportes = new List<IMedioTransporte>() { CrearTransporteAvion(), CrearTransporteBarco() }
            };

            return IEmpresaPaqueteria;
        }

        /// <summary>
        /// Método que permite crear la empresa de paquetería Estafeta.
        /// </summary>
        /// <returns>Interface de empresa de paquetería.</returns>
        private IEmpresaPaqueteria CrearEmpresaPaqueteriaEstafeta()
        {
            IEmpresaPaqueteria IEmpresaPaqueteria = new EmpresaEstafeta()
            {
                cNombreEmpresa = "Estafeta",
                dMargenUtilidad = 20,
                lstMediosTransportes = new List<IMedioTransporte>() { CrearTransporteTren() }
            };
            return IEmpresaPaqueteria;
        }

        /// <summary>
        /// Método que permite crear la empresa de paquetería Fedex.
        /// </summary>
        /// <returns>Interface de empresa de paquetería.</returns>
        private IEmpresaPaqueteria CrearEmpresaPaqueteriaFedex()
        {
            IEmpresaPaqueteria IEmpresaPaqueteria = new EmpresaFedex()
            {
                cNombreEmpresa = "Fedex",
                dMargenUtilidad = 50,
                lstMediosTransportes = new List<IMedioTransporte>() { CrearTransporteBarco() }
            };
            return IEmpresaPaqueteria;
        }

        /// <summary>
        /// Método que permite crear el medio de transporte Avión.
        /// </summary>
        /// <returns>Interface del medio de transporte.</returns>
        private IMedioTransporte CrearTransporteAvion()
        {
            IMedioTransporte IMedioTransporte = new TransporteAvion()
            {
                cNombreMedioTransporte = "Avión",
                dCostoKmPeso = 10,
                dVelocidadEntrega = 600
            };

            return IMedioTransporte;
        }

        /// <summary>
        /// Método que permite crear el medio de transporte Barco.
        /// </summary>
        /// <returns>Interface del medio de transporte.</returns>
        private IMedioTransporte CrearTransporteBarco()
        {
            IMedioTransporte IMedioTransporte = new TransporteBarco()
            {
                cNombreMedioTransporte = "Barco",
                dCostoKmPeso = 1,
                dVelocidadEntrega = 46
            };

            return IMedioTransporte;
        }

        /// <summary>
        /// Método que permite crear el medio de transporte Tren.
        /// </summary>
        /// <returns>Interface del medio de transporte.</returns>
        private IMedioTransporte CrearTransporteTren()
        {
            IMedioTransporte IMedioTransporte = new TransporteTren()
            {
                cNombreMedioTransporte = "Tren",
                dCostoKmPeso = 5,
                dVelocidadEntrega = 80
            };

            return IMedioTransporte;
        }
    }
}
