namespace TestProject1;

[TestClass]
public class HolidayTests
{
    [TestMethod]
    public void 今天是聖誕節()
    {
        ITimeProvider timeProvider =  new StubTimeProvider();

        var target = new Holiday(timeProvider);
        var actual = target.SayXmas();
        
        Assert.AreEqual("Merry Xmas", actual);
    }
}

public class StubTimeProvider : ITimeProvider
{
    public DateTime GetToday()
    {
        return new DateTime(2002, 12, 25);
    }
}
