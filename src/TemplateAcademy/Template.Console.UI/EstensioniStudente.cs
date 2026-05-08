namespace Template.Console.UI;

public static class EstensioniStudente
{
    public static Studente? StudentePiuBravo(this List<Studente> lista){
       var studente = lista.MaxBy(s => s.Esami.Average(e => e.Voto));
       return studente;
    }
}
