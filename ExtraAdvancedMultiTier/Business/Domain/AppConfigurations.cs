using ExtraAdvancedMultiTier.Business.Enums;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedMultiTier.Business.Domain;
public class AppConfigurations {
    private const string appDevModeKeyName = "DevMode";
    private const string dbTypeKeyName = "DB_Type";
    private const string dbServerAddressKeyName = "DB_Server_Address";
    private const string dbDatabaseNameKeyName = "DB_Database_Name";
    private const string dbUsernameKeyName = "DB_User_Id";
    private const string dbUserPasswordKeyName = "DB_Password";

    private readonly NameValueCollection configurations;
    private readonly Dictionary<string, string> connectionStrings;

    public AppConfigurations() {
        this.configurations = ConfigurationManager.AppSettings;
        this.connectionStrings = ConfigurationManager.ConnectionStrings.Cast<ConnectionStringSettings>().ToDictionary(
            setting => {
                return setting.Name;
            },
            setting => {
                return setting.ConnectionString;
            });
    }

    public string? GetConfig(string configKey) {
        return this.configurations.Get(configKey);
    }

    public string? GetConnexionString(string connStringName) {
        return this.connectionStrings.Where(kvp => {
            return kvp.Key == connStringName;
        }).FirstOrDefault().Value;
    }

    public DbTypesEnum GetDbTypeConfig() {
        string configValue = this.configurations.Get(dbTypeKeyName) ?? throw new Exception($"No configuration value found for key [{dbTypeKeyName}].");
        DbTypesEnum output;
        return Enum.TryParse(configValue, out output)
            ? output
            : throw new Exception($"Failed to parse text value [{configValue}] to enum value.");
    }

    public string GetDbServerConfig() {
        return this.configurations.Get(dbServerAddressKeyName) ?? throw new Exception($"No configuration value found for key [{dbServerAddressKeyName}].");
    }

    public string GetDbDatabaseConfig() {
        return this.configurations.Get(dbDatabaseNameKeyName) ?? throw new Exception($"No configuration value found for key [{dbDatabaseNameKeyName}].");
    }

    public string GetDbUsernameConfig() {
        return this.configurations.Get(dbUsernameKeyName) ?? throw new Exception($"No configuration value found for key [{dbUsernameKeyName}].");
    }

    public string GetDbPasswordConfig() {
        return this.configurations.Get(dbUserPasswordKeyName) ?? throw new Exception($"No configuration value found for key [{dbUserPasswordKeyName}].");
    }

}
