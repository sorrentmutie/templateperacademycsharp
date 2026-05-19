namespace Template.Core.Interfacce;

public interface ISaluto
{
    string GetSaluto();
}


public class SalutoInItaliano : ISaluto
{
    private readonly IClock clock;

    public SalutoInItaliano(IClock clock)
    {
        this.clock = clock;
    }

    public string GetSaluto()
    {
        var ora = clock.GetNow();
        if(ora.Hour <=12)
        {
            return "Buongiorno";
        }

        return "Buonasera";
    }
}