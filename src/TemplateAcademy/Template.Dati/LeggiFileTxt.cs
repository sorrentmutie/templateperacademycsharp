using Template.Core.Interfacce;

namespace Template.Dati;

public class LeggiFileTxt : IGestioneFiles
{
    public Task AggiungiRiga(string filename, string content)
    {
        throw new NotImplementedException();
    }

    public async Task CreaFile(string filename, string content)
    {
        using var streamWriter = new StreamWriter(filename);
        await streamWriter.WriteAsync(content);

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
