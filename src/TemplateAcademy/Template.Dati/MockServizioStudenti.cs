using Template.Core.Interfacce;

namespace Template.Dati;

public class MockServizioStudenti : IDatiStudenti
{
    private List<Studente> studenti = new List<Studente>()
    {
         new Studente() { Id = 1, Matricola = "12345", Nome = "Mario", Cognome = "Rossi" },
         new Studente() { Id = 2, Matricola = "67890", Nome = "Luigi", Cognome = "Verdi" },
         new Studente() { Id = 3, Matricola = "54321", Nome = "Giovanni", Cognome = "Bianchi" }
         new Studente() { Id = 4, Matricola = "98765", Nome = "Francesca", Cognome = "Neri" }
    };

    public void AggiungiStudente(Studente studente)
    {
        studenti.Add(studente);
    }

    public void EliminaStudente(int id)
    {
       studenti.RemoveAll(s => s.Id == id);
    }

    public Studente? EstraiStudente(int id)
    {
        return studenti.FirstOrDefault(s => s.Id == id);
    }

    public List<Studente> EstraiStudenti()
    {
        return studenti;
    }

    public void ModificaStudente(Studente studente)
    {
        throw new NotImplementedException();
    }
}
