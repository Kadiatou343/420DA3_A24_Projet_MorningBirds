using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
internal class WsysDbContext : DbContext {
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Address> Addresss { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        _ = optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer("Server=.\\SQL2022DEV;Database=X;Integrated Security=true;TrustServerCertificate=true;"); // TODO ADD DATABASE NAME
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        // CONFIGURATION DU MODELE DE DONNEES ENTITY FRAMEWORK

        // Convertisseur de DateTime en UTC pour la base de donnees et d'UTC en DateTime pour l'affichage dans l'application
        // La date sera stockée dans la base de données au format UTC et sera affiche dans l'app au format date locale
        // Note de Kadiatou aux coéquipiers : Cette méthode pour la conversion n'est pas requise pour le projet 
        // et l'examen final mais j'ai decidé de l'appliquer sur les meta-données des mes classes entités 
        ValueConverter<DateTime, DateTime> utcDateTimeConverter = new ValueConverter<DateTime, DateTime>(
            dt => dt.ToUniversalTime(),
            dt => DateTime.SpecifyKind(dt, DateTimeKind.Utc).ToLocalTime());

        #region CONFIGURATION DE LA LIAISON ENTITE User A TABLE 'Users'

        // CONFIGURATION DE LA TABLE 'Users' ET DE SA CLE PRIMAIRE

        _ = modelBuilder.Entity<User>()     // L'entité User
            .ToTable("Users")               // Est liée à une table qui se nomme 'Users'
            .HasKey(user  => user.Id);      // Dont la clé primaire est la propriété Id de l'entité

        _ = modelBuilder.Entity<User>()     // L'entite User 
            .Property(user => user.Id)      // A sa propriété Id
            .HasColumnName("Id")            // Lié à une colonne du nom 'Id' dans la table
            .HasColumnOrder(0)              // Qui est la premiere colonne dans la table
            .HasColumnType("int");          // Et de type int 

        _ = modelBuilder.Entity<User>()
            .Property(user => user.Username)
            .HasColumnName("Username")
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({User.USERNAME_MAX_LENGTH})")
            .IsRequired(true);  // Colonne NOT NULL

        _ = modelBuilder.Entity<User>()
            .Property(user => user.PasswordHash)
            .HasColumnName("PasswordHash")
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({User.PASSWORDHASH_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.EmployeeWarehouseId)
            .HasColumnName("EmployeeWarehouseId")
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(4)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasDefaultValueSql("GETUTCDATE()")
            .HasConversion(utcDateTimeConverter)
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(5)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(utcDateTimeConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(6)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(utcDateTimeConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnOrder(7)
            .IsRowVersion();            // Colonne Anti-concurence

        // CONFIGURATION DES COLONNE DE LA TABLE 'Users'

        #endregion

        #region CONFIGURATION DE LA LIAISON ENTITE Role A TABLE 'Roles'

        // CONFIGURATION DE LA TABLE 'Roles' ET DE SA CLE PRIMAIRE

        _ = modelBuilder.Entity<Role>()     // L'entité Role
            .ToTable("Roles")               // Est liée à une table qui se nomme 'Roles'
            .HasKey(role => role.Id);       // Dont la clé primaire est la propriété Id de l'entité

        // CONFIGURATION DES COLONNE DE LA TABLE 'Users'

        _ = modelBuilder.Entity<Role>()     // L'entité Role
            .Property(role => role.Id)      // A sa propriété Id
            .HasColumnName("Id")            // Lié a la colonne de nom 'Id' dans la table
            .HasColumnOrder(0)              // Qui est la première colonne
            .HasColumnType("int");          // Et de type int

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.RoleName)
            .HasColumnName("RoleName")
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Role.ROLE_NAME_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.RoleDescription)
            .HasColumnName("RoleDescription")
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Role.ROLE_DESCRIPTION_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(3)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasDefaultValueSql("GETUTCDATE()")
            .HasConversion(utcDateTimeConverter)
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(4)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(utcDateTimeConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(5)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(utcDateTimeConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnOrder(6)
            .IsRowVersion();

        #endregion

        // Note de Kadiatou : On peut tous mettre la configuration de nos relations ici 
        #region CONFIGURATION DES RELATIONS ENTRE ENTITES

        // Relation plusieurs à plusieurs entre User et Role
        _ = modelBuilder.Entity<User>()
            .HasMany(user => user.Roles)
            .WithMany(role => role.Users);

        // Relation un à plusieurs entre User et Warehouse coté User
        _ = modelBuilder.Entity<User>()
            .HasOne(user => user.EmployeeWarehouse)
            .WithMany(warehouse => warehouse.WarehouseEmployees)
            .HasForeignKey(user => user.EmployeeWarehouse.Id)
            .OnDelete(DeleteBehavior.SetNull);

        // Relation un à plusieurs entre User et ShippingOrder coté User (CreatedShipOrders)
        _ = modelBuilder.Entity<User>()
            .HasMany(user => user.CreatedShipOrders)
            .WithOne(shippingOrder => shippingOrder.CreatorEmployee)
            .HasForeignKey(shippingOrder => shippingOrder.CreatorEmployeeId)
            .OnDelete(DeleteBehavior.Cascade);

        // Relation un à plusieurs entre User et ShippingOrder coté User (FulfilledShipOrders)
        _ = modelBuilder.Entity<User>()
            .HasMany(user => user.FulfilledShipOrders)
            .WithOne(shippingOrder => shippingOrder.FulfillerEmployee)
            .HasForeignKey(shippingOrder => shippingOrder.FulfillerEmployeeId)
            .OnDelete(DeleteBehavior.Cascade);

        #endregion

        // Note de Kadiatou : On peut tous mettre les données d'insertion dans cette region
        #region INSERTION DE DONNEES INITIALES 

        Role role1 = new Role("Administrateur", "Les supers utilisateurs") {
            Id = 1
        };

        Role role2 = new Role("Employés de bureau", "Boss of paperwork") {
            Id = 2
        };

        _ = modelBuilder.Entity<Role>()
            .HasData(role1, role2);

        User user1 = new User("hunter","ILoveEFCore") {
            Id = 1
        };

        user1.Roles.Add(role1);
        user1.Roles.Add(role2);

        User user2 = new User("deiiidia", "GitIsOurSavior") {
            Id = 2
        };

        user2.Roles.Add(role2);

        _ = modelBuilder.Entity<User>()
            .HasData(user1, user2);

        #endregion
    }
}
