using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
internal class WsysDbContext : DbContext {
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        _ = optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer("Server=.\\SQL2022DEV;Database=X;Integrated Security=true;TrustServerCertificate=true;"); // TODO ADD DATABASE NAME
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        // Configuration du modèle de données Entity Framework

        #region CONFIGURATION DE LA LIAISON ENTITE User A TABLE 'Users'

        // CONFIGURATION DE LA TABLE 'Users' ET DE SA CLE PRIMAIRE

        _ = modelBuilder.Entity<User>()     // L'entité User
            .ToTable("Users")               // Est liée à une table qui se nomme 'Users'
            .HasKey(user  => user.Id);      // Dont la clé primaire est la propriété Id de l'entité

        // CONFIGURATION DES COLONNE DE LA TABLE 'Users'

        #endregion

        #region CONFIGURATION DE LA LIAISON ENTITE Role A TABLE 'Roles'

        // CONFIGURATION DE LA TABLE 'Roles' ET DE SA CLE PRIMAIRE

        _ = modelBuilder.Entity<Role>()     // L'entité Role
            .ToTable("Roles")               // Est liée à une table qui se nomme 'Roles'
            .HasKey(role => role.Id);       // Dont la clé primaire est la propriété Id de l'entité

        // CONFIGURATION DES COLONNE DE LA TABLE 'Users'

        #endregion
    }
}
