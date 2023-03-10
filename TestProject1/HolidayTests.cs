namespace TestProject1;

[TestClass]
public class HolidayTests
{
    [TestMethod]
    public void 今天是聖誕節()
    {
        var target = new Holiday
        {
            Today = new DateTime(3031, 12, 25),
        };

        var actual = target.SayXmas();
        
        Assert.AreEqual("Merry Xmas", actual);
    }    
}