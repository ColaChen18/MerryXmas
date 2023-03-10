using Microsoft.Extensions.DependencyInjection;
using NSubstitute;

namespace TestProject1;

[TestClass]
public class HolidayTests
{
    [TestMethod]
    public void 今天是聖誕節()
    {
        Register();

        var timeProvider = Substitute.For<ITimeProvider>();
        timeProvider.GetToday().Returns(new DateTime(1999, 12, 25));
        var target = new Holiday(timeProvider);
        var actual = target.SayXmas();
        
        Assert.AreEqual("Merry Xmas", actual);
    }

    private static void Register()
    {
        var service = new ServiceCollection();
        service.AddScoped<ITimeProvider, TimeProvider>();
        service.AddSingleton<Holiday>();
    }
}