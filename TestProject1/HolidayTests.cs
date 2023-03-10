namespace TestProject1;

[TestClass]
public class HolidayTests
{
    [TestMethod]
    public void 今天是聖誕節()
    {

    }
}

public class StubTimeProvider : ITimeProvider
{
    public DateTime GetToday()
    {
        return new DateTime(2002, 12, 25);
    }
}
