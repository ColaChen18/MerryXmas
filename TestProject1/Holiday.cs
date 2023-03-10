namespace TestProject1;

public class Holiday
{
    private readonly ITimeProvider _timeProvider;

    public Holiday(ITimeProvider timeProvider)
    {
        _timeProvider = timeProvider;
    }

    public string SayXmas()
    {
        var today = _timeProvider.GetToday();
        if (today.Month == 12 && today.Day == 25)
        {
            return "Merry Xmas";
        }

        return "Today is not Xmas";
    }
}