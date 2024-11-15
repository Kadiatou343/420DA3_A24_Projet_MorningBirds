using Exemple_Enseignant_Avance.Business;

namespace Exemple_Enseignant_Avance;
internal static class Program {

    [STAThread]
    public static void Main(string[] args) {
        ApplicationConfiguration.Initialize();
        new AdvancedExampleApplication().Start();
    }
}
