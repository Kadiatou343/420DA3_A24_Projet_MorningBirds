using Microsoft.EntityFrameworkCore;

namespace Exemple_Enseignant_Avance.DataAccess.Contexts;
internal class SqlServerDataContext : AbstractAdvancedExampleContext {

    public SqlServerDataContext() : base() { }

    public SqlServerDataContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        _ = optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer("Server=.\\SQL2022DEV;Database=420da3_projet_exemple_enseignant_avance;Integrated Security=true;TrustServerCertificate=true;");
    }

}
