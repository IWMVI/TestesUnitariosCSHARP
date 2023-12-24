using Xunit;
using calculadora.Services;

namespace calculadoraTestes;

public class calculadoraTestes
{

    private CalculadoraImplementacao _calc;

    public calculadoraTestes()
    {
        _calc = new CalculadoraImplementacao();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }
    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EParERetornarVerdadeiro()
    {
        int num1 = 4;

        bool resultado = _calc.Par(num1);

        Assert.True(resultado);
    }

    // [Theory]
    // [InlineData(2)]
    // [InlineData(4)]
    // [InlineData(6)]
    // [InlineData(8)]
    // [InlineData(10)]
    // public void DeveVerificarSeEParERetornarVerdadeiro(int numero)
    // {
    //     //Arrange
    //     //Act
    //     bool resultado = _calc.Par(numero);

    //     Assert.True(resultado);
    // }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeEParERetornarVerdadeiro(int[] numeros)
    {
        //Arrange
        //Act / Assert
        // foreach (var item in numeros)
        // {
        //     Assert.True(_calc.Par(item));
        // }
        Assert.All(numeros, num => Assert.True(_calc.Par(num)));
    }
}
