using Microsoft.EntityFrameworkCore;

namespace Exemple_Enseignant_Avance.DataAccess.Contexts;
internal class MySqlDataContext : AbstractAdvancedExampleContext {
    public MySqlDataContext() : base() { }

    public MySqlDataContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        _ = optionsBuilder
            .UseLazyLoadingProxies()
            .UseMySQL(""); // TODO: Ajouter la chaîne de connexion MySQL
    }

}
