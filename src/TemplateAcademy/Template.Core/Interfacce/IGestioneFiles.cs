
namespace Template.Core.Interfacce;

public interface IGestioneFiles
{
    Task<string> LeggiFile(string filename);
    Task CreaFile(string filename, string content);
    Task AggiungiRiga(string filename, string content);
    Task ModificaInteroFile(string filename, string content);
}
