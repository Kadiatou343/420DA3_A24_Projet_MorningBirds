using Exemple_Enseignant_Avance.DataAccess.Contexts;

namespace Exemple_Enseignant_Avance.DataAccess.DataProviders;
public class SqlServerDataProvider : AbstractDataProvider {

    public SqlServerDataProvider() : base(new SqlServerDataContext()) { }

}
