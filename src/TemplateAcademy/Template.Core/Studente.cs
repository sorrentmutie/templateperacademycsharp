
using Template.Core;

namespace Template;
public class Studente
{
    public int Id { get; set; }
    public required string Matricola { get; set; }
    public string? Nome { get; set; }
    public string? Cognome { get; set; }
    public List<EsameSostenuto>  Esami { get; set; } = new List<EsameSostenuto>();

    //public static string FaiQualcosa(string input) { 
    ////    return $"Hai inserito {input}";
    ////}
}
