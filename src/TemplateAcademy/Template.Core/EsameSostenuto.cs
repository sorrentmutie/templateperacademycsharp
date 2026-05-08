namespace Template.Core;

public class EsameSostenuto
{
    public int Id { get; set; }
   // public string? Nome { get; set; }
    public int Voto { get; set; }
    public DateTime Data { get; set; }
    public int DocenteId { get; set; }
    public int StudenteId { get; set; }
    public int EsameId { get; set; }

}
