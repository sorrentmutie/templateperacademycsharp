//using System.Numerics;
//using Template;
//using Template.Console.UI;
//using Template.Core;
//using Template.Core.Interfacce;
//using Template.Dati;

//Console.WriteLine("Hello, World!");

//IDatiStudenti datiStudenti = new MockServizioStudenti();
//IGestioneFacoltà gestioneFacoltà = new MockGestioneFacolta(datiStudenti);

//gestioneFacoltà.RegistraEsameStudente(
//    new EsameSostenuto() { EsameId = 1, StudenteId = 1, Voto = 28, Data = DateTime.Now });

//gestioneFacoltà.RegistraEsameStudente(
//    new EsameSostenuto() { EsameId = 2, StudenteId = 1, Voto = 30, Data = DateTime.Now });


//for(int i = 0; i < 18; i++)
//{
//    gestioneFacoltà.RegistraEsameStudente(
//        new EsameSostenuto() { EsameId = i + 3, StudenteId = 1, Voto = i % 2 == 0 ?   30: 25, Data = DateTime.Now });
//}

//var report = gestioneFacoltà.GeneraReportEsamiSostenuti(1);
//Console.WriteLine(report);


//Console.WriteLine(gestioneFacoltà.PuòLaurearsi(1) ? "Puoi laurearti" : "Non puoi laurearti");


//var studenti = datiStudenti.EstraiStudenti();
//var studentePiuBravo = studenti.StudentePiuBravo();





//var studentiFiltrati = studenti
//    .Where(s => s.Esami.Count > 5)
//    .Select(x => new { NomeCompleto = x.Nome + " " + x.Cognome, EsamiSvolti = x.Esami.Count })
//    .OrderByDescending(s => s.EsamiSvolti);

//foreach(var studente in studentiFiltrati)
//{
//    Console.WriteLine(studente.NomeCompleto + " "+ studente.EsamiSvolti);




//}

//var Maggiorenne = MinValue(18);

//var z = Maggiorenne(20);



//Func<int, bool> MinValue(int min) => value => value >= min;
//Func<int, bool> MaxValue(int max) => value => value <= max;
//Func<int, bool> Between(int min, int max)
//    => value => value >= min && value <= max;

using Template.Core.Interfacce;
using Template.Dati;

var percorsoFile = @"C:\temp\temp.txt";

IGestioneFiles gestioneFiles = new LeggiFileTxt();
var contenutoFile = await gestioneFiles.LeggiFile(percorsoFile);
if(contenutoFile is not null)
{
    Console.WriteLine(contenutoFile);
}
else
{
    Console.WriteLine("Il file è vuoto o non esiste.");
}

var nuovoPercorsoFile = @"C:\temp\tempNuovo.txt";
var contenutoDaScrivere = "Ciao, questo è un nuovo contenuto per il file.";
await gestioneFiles.CreaFile(nuovoPercorsoFile, contenutoDaScrivere);



