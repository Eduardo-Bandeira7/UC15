using CalculadoraFS3;

namespace MsTeste
{
    [TestClass]
    public class TesteCalcMsTeste
    {
        [TestMethod]
        public void TesteSomarDoisNumeros()
        {
            //Arrange - prepara��o
            double pNun = 1;
            double sNun = 1;
            double rNun = 2;


            //Act - A��o
            var resultado = Calculadora.Somar(pNun, sNun);


            //Asert - Verifica��o
            Assert.AreEqual(rNun, resultado);
        }

        [DataTestMethod]
        [DataRow(1,2,3)]
        [DataRow(2,2,4)]
        [DataRow(2,5,7)]

        public void TesteSomarDoisNumerosLista(double pNun, double sNun, double rNun)
        {
            //Act
            var resultado = Calculadora.Somar(pNun, sNun);

            //Assert
            Assert.AreEqual(rNun, resultado);
        }

    }
}