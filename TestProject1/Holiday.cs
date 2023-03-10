namespace TestProject1;

public class Holiday
{
    private DateTime _today;
    public DateTime Today
    {
        private get
        {
            if (_today == null)
            {
                _today = DateTime.Today;
            }
            return _today;
        }
        set => _today = value;
    }

    public string SayXmas()
    {
        var today = Today;
        if (today.Month == 12 && today.Day == 25)
        {
            return "Merry Xmas";
        }

        return "Today is not Xmas";
    }
}