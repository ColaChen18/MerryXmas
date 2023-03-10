namespace TestProject1;

public class Holiday
{
    public string SayXmas()
    {
        var today = GetToday();
        if (today.Month == 12 && today.Day == 25)
        {
            return "Merry Xmas";
        }

        return "Today is not Xmas";
    }

    private static DateTime GetToday()
    {
        return DateTime.Today;
    }
}