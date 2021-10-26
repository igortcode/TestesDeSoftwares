using Xunit;

namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact] //Indicando que é um método de teste.
        public void Calculadora_Soma_RetornarValorSoma()
        {
            //Nomenclatura padrão utilizada Objeto_Método_OQueEspera.
            //Padrão AAA

            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(2, 2);

            //Assert
            Assert.Equal(4, resultado);
        }

        //Testando em vários cenários
        [Theory]
        [InlineData(1,1,2)] //Parametros a serem testados.
        [InlineData(2, 5, 7)]
        [InlineData(6, 6, 12)]
        [InlineData(8, 9, 17)]
        [InlineData(4, 3, 7)]
        [InlineData(5, 8, 13)]
        [InlineData(6, 2, 8)]
        public void Calculadora_Somar_RetornarValoresSomaCorretos(double v1, double v2, double total)
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(v1, v2);

            //Assert
            Assert.Equal(total, resultado);
        }
    }
}
