using Calculadora.Models;

namespace Testes;

public class CalculadoraProjetoTests
{
    public CalculadoraProjeto ConstruirClasse()
    {
        string data = "29/05/2024";
        CalculadoraProjeto calc = new CalculadoraProjeto(data);

        return calc;
    }
    

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestSomar(int num1, int num2, int resultado)
    {
        CalculadoraProjeto calc = ConstruirClasse();

        int resultadoCalculadora = calc.Somar(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TestMultiplicar(int num1, int num2, int resultado)
    {
        CalculadoraProjeto calc = ConstruirClasse();

        int resultadoCalculadora = calc.Multiplicar(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (5, 5, 1)]
    public void TestDividir(int num1, int num2, int resultado)
    {
        CalculadoraProjeto calc = ConstruirClasse();

        int resultadoCalculadora = calc.Dividir(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData (5, 5, 0)]
    public void TestSubtrair(int num1, int num2, int resultado)
    {
        CalculadoraProjeto calc = ConstruirClasse();

        int resultadoCalculadora = calc.Subtrair(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestDividirPorZero()
    {
        CalculadoraProjeto calc = ConstruirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3,0));
    }

    [Fact]
    public void TestHistorico()
    {
        CalculadoraProjeto calc = ConstruirClasse();

        calc.Somar(1, 2);
        calc.Somar(2, 8);
        calc.Somar(3, 7);
        calc.Somar(4, 1);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}