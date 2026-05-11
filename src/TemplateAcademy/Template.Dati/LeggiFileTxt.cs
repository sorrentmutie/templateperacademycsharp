using Template.Core.Interfacce;

namespace Template.Dati;

public class LeggiFileTxt : IGestioneFiles
{
    public Task AggiungiRiga(string filename, string content)
    {
        throw new NotImplementedException();
    }

    public Task CreaFile(string filename, string content)
    {
        throw new NotImplementedException();
    }

    public async Task<string> LeggiFile(string filename)
    {
        using var reader = new StreamReader(filename);
        var content = await reader.ReadToEndAsync();
       // reader.Close();
        return content;
    }

    public Task ModificaInteroFile(string filename, string content)
    {
        throw new NotImplementedException();
    }
}
