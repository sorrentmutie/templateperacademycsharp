namespace Template.Web.Blazor.Models;

public class Evento
{
    public int Id { get; set; }
    public required string Titolo { get; set; }
    public DateTime Data { get; set; }
    public string? Località { get; set; }
    public string? Descrizione { get; set; }
}
