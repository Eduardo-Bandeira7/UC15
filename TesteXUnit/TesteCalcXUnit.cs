using CalculadoraFS3;

namespace TesteXUnit
{
    public class TesteCalcXUnit
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange - prepara��o
            double pNun = 1;
            double sNun = 2;
            double rNun = 3;

            //Act - A��o
            var resultado = Calculadora.Somar(pNun, sNun);

            //Assert - Verifica��o
            Assert.Equal(rNun, resultado);

        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        [InlineData(2,3,5)]
        public void SomarDoisnumerosLista(double pNun, double sNun, double rNun)
        {
            //Act
            var resultado = Calculadora.Somar(pNun, sNun);

            //Assert
            Assert.Equal(rNun, resultado);
        }
    }
}