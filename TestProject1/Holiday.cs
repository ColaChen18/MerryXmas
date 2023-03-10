namespace TestProject1;

public class Holiday
{
    public string SayXmas()
    {
        var today = DateTime.Today;
        if (today.Month ==12 && today.Day ==25)
        {
            return "Merry Xmas";
        }

        return "Today is not Xmas";
    }
}