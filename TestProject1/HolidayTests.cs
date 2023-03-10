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

    [TestMethod]
    public void 今天不是聖誕節()
    {
        var target = new MyHoliday();
        target.SetToday(new DateTime(2200,3,8));
        var actual = target.SayXmas();

        var expected = "Today is not Xmas";
        Assert.AreEqual(expected, actual);
    }
}

public class MyHoliday : Holiday
{
    private DateTime _today;

    public void SetToday(DateTime today)
    {
        _today = today;
    }
    
    protected override DateTime GetToday()
    {
        return _today;
    }
}