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

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.Collections.Immutable;
using Template;
using Template.Console.UI;
using Template.Core.Interfacce;
using Template.Dati;
using Template.Dati.Northwind.Models;

var percorsoFile = @"C:\temp\temp.txt";

//IGestioneFiles gestioneFiles = new LeggiFileTxt();
//var contenutoFile = await gestioneFiles.LeggiFile(percorsoFile);
//if(contenutoFile is not null)
//{
//    Console.WriteLine(contenutoFile);
//}
//else
//{
//    Console.WriteLine("Il file è vuoto o non esiste.");
//}

//var nuovoPercorsoFile = @"C:\temp\tempNuovo.json";
////var contenutoDaScrivere = "Ciao, questo è un nuovo contenuto per il file.";
////await gestioneFiles.CreaFile(nuovoPercorsoFile, contenutoDaScrivere);

//var gestioneJsonStudente = new GestioneJsonStudente();
//var studente = new Studente() { Nome = "Mario", Cognome = "Rossi", Matricola = "abcde" };
//var studente2 = new Studente() { Nome = "Luig", Cognome = "Bianchi", Matricola = "fghil" };
//var lista = new List<Studente>();
//lista.AddRange(studente,studente2);
//await gestioneJsonStudente.AggiungiStudenti(lista, nuovoPercorsoFile);

//await gestioneJsonStudente.AggiungiStudente(studente, nuovoPercorsoFile);
//await gestioneJsonStudente.AggiungiStudente(studente2, nuovoPercorsoFile);

//var listaStudenti = await gestioneJsonStudente.LeggiListaStudenti(nuovoPercorsoFile);
//foreach(var studente in listaStudenti ?? new List<Studente>())
//{
//    Console.WriteLine($"Nome: {studente.Nome}, Cognome: {studente.Cognome}, Matricola: {studente.Matricola}");
//}

var database = new NorthwindContext();
//var prodotti = await database.Products.Include(p => p.Category).ToListAsync();

//var data = await database.Orders.Include(o => o.Employee)
//    .Select(o => new
//     {
//         o.OrderId,
//         o.OrderDate,
//         EmployeeName = o.Employee.FirstName + " " + o.Employee.LastName
//     }).ToListAsync();

//foreach (var item in data)
//{
//    Console.WriteLine($"OrderId: {item.OrderId}, OrderDate: {item.OrderDate}, EmployeeName: {item.EmployeeName}");
//}

//var orderDetails = await database.OrderDetails
//    .Include(od => od.Product)
//    .ThenInclude(p => p.Category)
//    .AsNoTracking()
//    .ToListAsync();


//var nuovoProdotto = new Product()
//{
//    ProductName = "Nuovo Prodotto4",
//    UnitPrice = 10.99m,
//    UnitsInStock = 100,
//    CategoryId = 1, // Assicurati che questa categoria esista
//    SupplierId = 1  // Assicurati che questo fornitore esista
//};

//database.Products.Add(nuovoProdotto);



//var nuovaCategoria = new Category()
//{
//    CategoryName = "Nuova Categoria",
//    Description = "Descrizione della nuova categoria"
//};
//database.Categories.Add(nuovaCategoria);//await database.SaveChangesAsync();


//nuovoProdotto.ProductName = "zzzzzz";

//await database.SaveChangesAsync();


//var categories = await database.Categories
//    .Include(c => c.Products)
//    .ThenInclude(p =>p.Supplier)    
//    .ToListAsync();


//foreach (var category in categories)
//{
//    Console.WriteLine($"Categoria: {category.CategoryName}");

//}

//Console.WriteLine("Terminata esecuzione");

//await Esercizi.esercizio1();
//await Esercizi.esercizio2();
await Esercizi.esercizio3();







