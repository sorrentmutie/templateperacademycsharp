using Template.Core;
using Template.Core.Interfacce;
using Template.Dati;

Console.WriteLine("Hello, World!");

IDatiStudenti datiStudenti = new MockServizioStudenti();
IGestioneFacoltà gestioneFacoltà = new MockGestioneFacolta(datiStudenti);

gestioneFacoltà.RegistraEsameStudente(
    new EsameSostenuto() { EsameId = 1, StudenteId = 1, Voto = 28, Data = DateTime.Now });

gestioneFacoltà.RegistraEsameStudente(
    new EsameSostenuto() { EsameId = 2, StudenteId = 1, Voto = 30, Data = DateTime.Now });

var report   =gestioneFacoltà.GeneraReportEsamiSostenuti(1);
Console.WriteLine(report);
Console.WriteLine(gestioneFacoltà.PuòLaurearsi(1) ? "Puoi laurearti" : "Non puoi laurearti");