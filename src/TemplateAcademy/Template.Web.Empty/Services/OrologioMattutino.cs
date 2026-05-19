using Template.Core.Interfacce;

namespace Template.Web.Empty.Services;

public class OrologioMattutino : IClock
{
    public int NumeroVisite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public DateTime GetNow()
    {
        return new DateTime(2000, 1, 1, 10, 0, 0);
    }
}

public class OrologioVero : IClock
{

    public int NumeroVisite { get; set; }

    public DateTime GetNow()
    {
        NumeroVisite++;
        return DateTime.Now;
    }
}

