using System.Text.Json;

namespace Template.Dati
{



    public class GestioneJsonStudente    {
        public List<Studente> ListaStudenti { get; set; } = new();

        public async Task<List<Studente>?> LeggiListaStudenti(string fileName)
        {
            using var reader = new StreamReader(fileName);
            var json = await reader.ReadToEndAsync();
            return JsonSerializer.Deserialize<List<Studente>>(json);
        }


        public async Task AggiungiStudenti(List<Studente> nuoviStudenti, string fileName)
        {
            ListaStudenti?.AddRange(nuoviStudenti);
            var json = JsonSerializer.Serialize(ListaStudenti);
            using var streamWriter = new StreamWriter(fileName);
            await streamWriter.WriteAsync(json);
        }

        public async Task AggiungiStudente(Studente nuovoStudente, string fileName)
        {
            ListaStudenti?.Add(nuovoStudente);

            var json = JsonSerializer.Serialize(ListaStudenti);

            using var streamWriter = new StreamWriter(fileName);
            await streamWriter.WriteAsync(json);

        }


    }
}
