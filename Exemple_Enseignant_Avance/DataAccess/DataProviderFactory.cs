using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.DataAccess.DataProviders;
using ExtraAdvancedMultiTier.Business.Domain;
using ExtraAdvancedMultiTier.Business.Enums;

namespace Exemple_Enseignant_Avance.DataAccess;
public static class DataProviderFactory {

    private static IDataProvider? currentProvider;

    public static IDataProvider GetDataProvider(AppConfigurations configurations) {
        switch (configurations.GetDbTypeConfig()) {
            case DbTypesEnum.SqlServer:
                if (currentProvider is null || currentProvider.GetType() != typeof(SqlServerDataProvider)) {
                    currentProvider = new SqlServerDataProvider();
                }
                break;
            case DbTypesEnum.MySql:
                if (currentProvider is null || currentProvider.GetType() != typeof(MySqlDataProvider)) {
                    currentProvider = new MySqlDataProvider();
                }
                break;
            case DbTypesEnum.Postgesql:
            default:
                throw new NotImplementedException($"Data provider for database type [{configurations.GetDbTypeConfig()}] not supported (yet).");
        }
        return currentProvider;
    }

}
