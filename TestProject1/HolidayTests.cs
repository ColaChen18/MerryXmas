using Autofac;
using NSubstitute;

namespace TestProject1;

[TestClass]
public class HolidayTests
{
    [TestMethod]
    public void 今天是聖誕節()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<TimeProvider>().As<ITimeProvider>();
        builder.RegisterType<Holiday>();
        var container = builder.Build();

        // using var scope = container.BeginLifetimeScope();
        // var target = scope.Resolve<Holiday>();
        var timeProvider = Substitute.For<ITimeProvider>();
        timeProvider.GetToday().Returns(new DateTime(2020, 12, 25));

        var target = new Holiday(timeProvider);
        var actual = target.SayXmas();

        Assert.AreEqual("Merry Xmas", actual);
    }
}