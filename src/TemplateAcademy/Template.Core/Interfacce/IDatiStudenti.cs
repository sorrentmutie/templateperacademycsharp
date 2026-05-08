namespace Template.Core.Interfacce;

public interface IDatiStudenti
{
    List<Studente>  EstraiStudenti();
    Studente? EstraiStudente(int id);
     void AggiungiStudente(Studente studente);
     void ModificaStudente(Studente studente);
     void EliminaStudente(int id);
}

public interface IDatiGenerici<T>
{
    List<T> EstraiTutti();
    T? EstraiPerID(int id);
    void Aggiungi(T item);
    void Modifica(T item);
    void Elimina(int id);
}

public interface IDatiGenericiConChiave<T,U>
{
    List<T> EstraiTutti();
    T? EstraiPerID(U id);
    void Aggiungi(T item);
    void Modifica(T item);
    void Elimina(U id);
}
