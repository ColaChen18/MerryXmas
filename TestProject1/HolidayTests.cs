using NSubstitute;

namespace TestProject1;

[TestClass]
public class HolidayTests
{
    [TestMethod]
    public void 今天是聖誕節()
    {
        var provider = Substitute.For<ITimeProvider>();
        provider.GetToday().Returns(new DateTime(2000, 12, 25));
        
        var target = new Holiday(provider);
        var actual = target.SayXmas();
        
        Assert.AreEqual("Merry Xmas", actual);
    }
}