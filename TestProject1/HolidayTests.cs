using Microsoft.Extensions.DependencyInjection;

namespace TestProject1;

[TestClass]
public class HolidayTests
{
    [TestMethod]
    public void 今天是聖誕節()
    {
        var service = new ServiceCollection();
        service.AddScoped<ITimeProvider, TimeProvider>();
        service.AddSingleton<Holiday>();
        var buildServiceProvider = service.BuildServiceProvider();
        
        var target = buildServiceProvider.GetService<Holiday>();
        var actual = target.SayXmas();
        
        Assert.AreEqual("Merry Xmas", actual);
    }
}