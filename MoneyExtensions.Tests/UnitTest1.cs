using MoneyExtension;

namespace MoneyExtensions.Tests;

[TestClass]
public class MoneyExtensionTest
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.98M;
        var cents = valor.ToCents();
        
        Assert.AreEqual(27998, cents);
    }
}