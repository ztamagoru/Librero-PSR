using librero1;

namespace Test_librero1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SiLaCantidadDeBasesEsDiferenteALaDeLibrosTiraUnError()
        {
            // cantidad de medidas diferentes
            // excepcion esperada

            var bases = new List<int>() { 1 };
            var libros = new List<int>() { 1, 2 };
            Assert.ThrowsException<Exception>(() =>
            {
                Librero1.Librero(bases, libros);
            });
        }

        [TestMethod]
        public void Caso1()
        {
            // test inicial para ver si el tdd anda

            var bases = new List<int>() { 1, 2 };
            var libros = new List<int>() { 1, 2 };
            var resultado = Librero1.Librero(bases, libros);
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void Caso2()
        {
            // segundo test con diferente resultado para ver si el tdd anda

            var bases = new List<int>() { 1, 4 };
            var libros = new List<int>() { 1, 4 };
            var resultado = Librero1.Librero(bases, libros);
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void Caso3()
        {
            // caso 2 pero en orden alterno

            var bases = new List<int>() { 1, 4 };
            var libros = new List<int>() { 4, 1 };
            var resultado = Librero1.Librero(bases, libros);
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void Caso4()
        {
            // caso inspirado en el ejemplo 1 

            var bases = new List<int>() { 1, 4, 5 };
            var libros = new List<int>() { 9, 6, 5 };
            var resultado = Librero1.Librero(bases, libros);
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        public void Caso5()
        {
            // caso con resultado erroneo
            // se espera un -1

            var bases = new List<int>() { 1, 2 };
            var libros = new List<int>() { 4, 1 };
            var resultado = Librero1.Librero(bases, libros);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void Ejemplo1()
        {
            // ejemplo 1 citado en la consigna del trabajo

            var bases = new List<int>() { 3, 2, 6, 2, 4, 2, 1, 6 };
            var libros = new List<int>() { 6, 8, 4, 8, 7, 9, 8, 4 };
            var resultado = Librero1.Librero(bases, libros);
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        public void Ejemplo2()
        {
            // ejemplo 2 citado en la consigna del trabajo

            var bases = new List<int>() { 1, 1, 1, 21 };
            var libros = new List<int>() { 4, 4, 4, 4 };
            var resultado = Librero1.Librero(bases, libros);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void Casoprueba()
        {
            // inspirado en problematica encontrada

            var bases = new List<int>() { 2, 2, 2 };
            var libros = new List<int>() { 8, 9, 7 };
            var resultado = Librero1.Librero(bases, libros);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void Test1PequenioQueDaOk()
        {
            // test para ver que tan rápido corre con 100 entradas

            var bases = new List<int>();
            var libros = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                bases.Add(4);
                libros.Add(6);
            }
            var resultado = Librero1.Librero(bases, libros);
            Assert.AreEqual(10, resultado);
        }
        [TestMethod]
        public void Test2MedianoQueDaOk()
        {
            // test para ver que tan rápido corre con 1000 entradas

            var bases = new List<int>();
            var libros = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                bases.Add(4);
                libros.Add(6);
            }
            var resultado = Librero1.Librero(bases, libros);
            Assert.AreEqual(10, resultado);
        }
        [TestMethod]
        public void Test3GrandeQueDaOk()
        {
            // test para ver que tan rápido corre con 10000 entradas

            var bases = new List<int>();
            var libros = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                bases.Add(4);
                libros.Add(6);
            }
            var resultado = Librero1.Librero(bases, libros);
            Assert.AreEqual(10, resultado);
        }
        [TestMethod]
        public void Test4MuyGrandeQueDaOk()
        {
            // test para ver que tan rápido corre con 100000 entradas

            var bases = new List<int>();
            var libros = new List<int>();
            for (int i = 0; i < 100000; i++)
            {
                bases.Add(4);
                libros.Add(6);
            }
            var resultado = Librero1.Librero(bases, libros);
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TieneQueTirarErrorAProposisto()
        {
            // medidas fuera de rango
            // excepcion esperada

            var bases = new List<int>() { 1, 101 };
            var libros = new List<int>() { 0, 1 };
            var resultado = Librero1.Librero(bases, libros);
        }

        [TestMethod]
        public void Caso6()
        {
            // inspirado en problematica encontrada

            var bases = new List<int>() { 6, 7 };
            var libros = new List<int>() { 6, 4 };
            var resultado = Librero1.Librero(bases, libros);
            Assert.AreEqual(-1, resultado);
        }
    }
}