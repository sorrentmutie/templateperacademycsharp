

namespace Template.Core.Interfacce;

public interface IGestioneFacoltà
{
    void RegistraEsameStudente(EsameSostenuto esameSostenuto);
    decimal CalcolaMediaVoti(int studenteId);
    string GeneraReportEsamiSostenuti(int studenteId);
    bool PuòLaurearsi(int studenteId);

}
