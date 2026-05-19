namespace Template.Core.Interfacce;

public interface IClock
{
    DateTime GetNow();
    int NumeroVisite { get; set; }
}
