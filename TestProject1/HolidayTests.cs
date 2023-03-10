namespace TestProject1;

[TestClass]
public class HolidayTests
{
    [TestMethod]
    public void 今天是聖誕節()
    {
        var target = new MyHoliday();
        var actual = target.SayXmas();

        var expected = "Merry Xmas";
        Assert.AreEqual(expected, actual);
    }
}

public class MyHoliday : Holiday
{
    protected override DateTime GetToday()
    {
        return new DateTime(1999, 12, 25);
    }
}