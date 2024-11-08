using Exemple_Enseignant_Avance.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemple_Enseignant_Avance;
internal static class Program {

    [STAThread]
    public static void Main(string[] args) {
        ApplicationConfiguration.Initialize();
        new AdvancedExampleApplication().Start();
    }
}
