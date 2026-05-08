using System.Text;
using Template.Core;
using Template.Core.Interfacce;

namespace Template.Dati;

public class MockGestioneFacolta : IGestioneFacoltà
{
    private readonly IDatiStudenti datiStudenti;

    public MockGestioneFacolta(IDatiStudenti datiStudenti)
    {
        this.datiStudenti = datiStudenti;
    }

    public decimal CalcolaMediaVoti(int studenteId)
    {
        var studente = datiStudenti.EstraiStudente(studenteId);
        var media = studente?.Esami.Average(e => e.Voto);
        return Convert.ToDecimal(media);
    }
    
    public string GeneraReportEsamiSostenuti(int studenteId)
    {
        var studente = datiStudenti.EstraiStudente(studenteId);
        var stringBuilder = new StringBuilder();
        foreach ( var  esame in studente?.Esami ?? new List<EsameSostenuto>())
        {
            stringBuilder.AppendLine($"Esame: {esame.EsameId}, Voto: {esame.Voto}, Data: {esame.Data}");
        }

        if(studente?.Esami.Count == 20)
        {
            stringBuilder.AppendLine("Complimenti. Ti puoi laureare");
        }

        return stringBuilder.ToString();
    }

    public bool PuòLaurearsi(int studenteId)
    {
        var studente = datiStudenti.EstraiStudente(studenteId);
        return studente != null && studente.Esami.Count >= 20;
    }

    public void RegistraEsameStudente(EsameSostenuto esameSostenuto)
    {
        var studente = datiStudenti.EstraiStudente(esameSostenuto.StudenteId);
        if (studente != null) {
            studente.Esami.Add(esameSostenuto);
        }
    }
}
