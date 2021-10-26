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
    }
}
