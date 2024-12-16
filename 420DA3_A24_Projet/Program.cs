using _420DA3_A24_Projet.Business;

namespace _420DA3_A24_Projet;

internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main(string[] args) {
        (new WsysApplication()).Start();
    }
}