using Xunit;
using Library; // Importujemy naszą bibliotekę, którą testujemy

namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void TestAddMethod()
    {
        // Arrange (Przygotowanie)
        var calculator = new Calculator();
        int expected = 5;

        // Act (Działanie)
        int actual = calculator.Add(2, 3);

        // Assert (Asercja - Sprawdzenie)
        // Sprawdza, czy wynik 5 jest równy oczekiwanej wartości
        Assert.Equal(expected, actual); 
    }
}