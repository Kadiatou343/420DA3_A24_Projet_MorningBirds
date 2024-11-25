using Exemple_Enseignant_Avance.DataAccess.Contexts;

namespace Exemple_Enseignant_Avance.DataAccess.DataProviders;
public class MySqlDataProvider : AbstractDataProvider {

    public MySqlDataProvider() : base(new MySqlDataContext()) { }

}
