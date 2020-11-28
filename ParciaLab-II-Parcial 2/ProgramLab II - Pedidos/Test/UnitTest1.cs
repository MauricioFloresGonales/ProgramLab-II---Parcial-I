using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CrearBebida()
        {
            Bebida comidaTest = new Bebida("fanta", 170, EGusto.SinGas);
            Assert.IsNotNull(comidaTest);
        }
        [TestMethod]
        public void CrearComida()
        {
            Comida comidaTest = new Comida("pizaa", 100, ETipo.Vegetariana, false);
            Assert.IsNotNull(comidaTest);
        }
        [TestMethod]
        public void CrearCliente()
        {
            Cliente<Comida, Bebida> clienteTest = new Cliente<Comida, Bebida>(
                "mauricio",
                new Comida("pizaa", 100, ETipo.Vegetariana, false),
                new Bebida("fanta", 170, EGusto.SinGas),
                270,
                "local"
                );
            Assert.IsNotNull(clienteTest);
        }
        [TestMethod]
        public void metodoDBGetComida()
        {
            List<Comida> comidas = new List<Comida>();
            comidas = DB.GetComidas();
            
            Assert.IsTrue(comidas.Count > 0);
        }
        [TestMethod]
        public void NombrePeliculaSeaMismo()
        {
            try
            {
                Archivo<Bebida, Comida>.GenerarTicket(new Cliente<Bebida, Comida>(
                    "mauricio",
                    new Bebida("fanta", 170, EGusto.SinGas),
                    new Comida("pizaa", 100, ETipo.Vegetariana, false),
                    270,
                    "local"
                    ), "test");
            }
            catch (Exception)
            {
                throw;
            }
        }
        [TestMethod]
        public void TestAtenderCliente()
        {
            Tienda<Cliente<Bebida,Comida>> asd();
            Cliente<Bebida, Comida> ejemplo = new Cliente<Bebida, Comida>(
                    "mauricio",
                    new Bebida("fanta", 170, EGusto.SinGas),
                    new Comida("pizaa", 100, ETipo.Vegetariana, false),
                    270,
                    "local"
                    );

            ejemplo = Tienda<Cliente<Comida,Comida>>.AtenderCliente

            Assert.IsTrue(comidas.Count > 0);
        }
    }
}
