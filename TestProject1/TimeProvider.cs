namespace TestProject1;

public class TimeProvider : ITimeProvider
{
    public DateTime GetToday()
    {
        return DateTime.Today;
    }
}