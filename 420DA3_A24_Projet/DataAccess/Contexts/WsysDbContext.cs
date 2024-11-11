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

    public DbSet<Product> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
     
    public DbSet<Client> Clients { get; set; }
    public DbSet<Address> Addresses { get; set; }
    
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
            .HasKey(user => user.Id);      // Dont la clé primaire est la propriété Id de l'entité

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

        #region CONFIGURATION DE LA LIAISON ENTITE Client A TABLE 'Clients'

        _ = modelBuilder.Entity<Client>()
           .ToTable("Clients")
           .HasKey(client => client.Id);

        _ = modelBuilder.Entity<Client>()
          .Property(client => client.Id)
          .HasColumnName("Id")
          .HasColumnOrder(0)
          .HasColumnType("int");

        _ = modelBuilder.Entity<Client>()
          .Property(client => client.ClientName)
          .HasColumnName("ClientName")
          .HasColumnOrder(2)
          .HasColumnType("nvarchar(128)")
          .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
        .Property(client => client.WarehouseId)
        .HasColumnName("WarehouseId ")
        .HasColumnOrder(3)
        .HasColumnType("int")
        .IsRequired(false);

        _ = modelBuilder.Entity<Client>()
        .Property(client => client.ContactFirstName)
        .HasColumnName("ContactFirstName")
        .HasColumnOrder(4)
        .HasColumnType("nvarchar(32)")
        .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
        .Property(client => client.ContactLastName)
        .HasColumnName("ContactLastName")
        .HasColumnOrder(5)
        .HasColumnType("nvarchar(32)")
        .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
        .Property(client => client.ContactEmail)
        .HasColumnName("ContactEmail")
        .HasColumnOrder(6)
        .HasColumnType("nvarchar(128)")
        .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
        .Property(client => client.ContactTelephone)
        .HasColumnName("ContactTelephone")
        .HasColumnOrder(7)
        .HasColumnType("nvarchar(15)")
        .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
        .Property(client => client.DateCreated)
        .HasColumnName("DateCreated")
        .HasColumnOrder(8)
        .HasColumnType("datetime2(6)")
        .HasPrecision(6)
        .HasDefaultValueSql("GETUTCDATE()")
        .HasConversion(utcDateTimeConverter)
        .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
        .Property(client => client.DateModified)
        .HasColumnName("DateModified")
        .HasColumnOrder(9)
        .HasColumnType("datetime2(6)")
        .HasPrecision(6)
        .HasConversion(utcDateTimeConverter)
        .IsRequired(false);

        _ = modelBuilder.Entity<Client>()
        .Property(client => client.DateDeleted)
        .HasColumnName("DateDeleted")
        .HasColumnOrder(10)
        .HasColumnType("datetime2(6)")
        .HasPrecision(6)
        .HasConversion(utcDateTimeConverter)
        .IsRequired(false);

        _ = modelBuilder.Entity<Client>()
        .Property(client => client.RowVersion)
        .HasColumnName("RowVersion")
        .HasColumnOrder(11)
        .IsRowVersion();

        #endregion

        #region CONFIGURATION DE LA LIAISON ENTITE Address A TABLE 'Addresses'

        _ = modelBuilder.Entity<Address>()
           .ToTable("Addresses")
           .HasKey(address => address.Id);

        _ = modelBuilder.Entity<Address>()
          .Property(address => address.Id)
          .HasColumnName("Id")
          .HasColumnOrder(0)
          .HasColumnType("int");

        _ = modelBuilder.Entity<Address>()
          .Property(address => address.AddressType)
          .HasColumnName("AddressType")
          .HasColumnOrder(1)
          .HasColumnType("nvarchar(64)")
          .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
        .Property(address => address.Addresse)
        .HasColumnName("Addresse")
        .HasColumnOrder(2)
        .HasColumnType("nvarchar(64)")
        .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
        .Property(address => address.CivicNumber)
        .HasColumnName("CivicNumber")
        .HasColumnOrder(3)
        .HasColumnType("nvarchar(6)")
        .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
        .Property(address => address.Street)
        .HasColumnName("ContactLastName")
        .HasColumnOrder(4)
        .HasColumnType("nvarchar(128)")
        .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
        .Property(address => address.City)
        .HasColumnName("City")
        .HasColumnOrder(5)
        .HasColumnType("nvarchar(64)")
        .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
        .Property(address => address.State)
        .HasColumnName("State")
        .HasColumnOrder(6)
        .HasColumnType("nvarchar(64)")
        .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
        .Property(address => address.Country)
        .HasColumnName("Country")
        .HasColumnOrder(7)
        .HasColumnType("nvarchar(64)")
        .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
        .Property(address => address.PostalCode)
        .HasColumnName("PostalCode")
        .HasColumnOrder(8)
        .HasColumnType("nvarchar(64)")
        .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
        .Property(address => address.DateCreated)
        .HasColumnName("DateCreated")
        .HasColumnOrder(9)
        .HasColumnType("datetime2(6)")
        .HasPrecision(6)
        .HasDefaultValueSql("GETUTCDATE()")
        .HasConversion(utcDateTimeConverter)
        .IsRequired(true);

        _ = modelBuilder.Entity<Address>()
        .Property(address => address.DateModified)
        .HasColumnName("DateModified")
        .HasColumnOrder(10)
        .HasColumnType("datetime2(6)")
        .HasPrecision(6)
        .HasConversion(utcDateTimeConverter)
        .IsRequired(false);

        _ = modelBuilder.Entity<Address>()
        .Property(address => address.DateDeleted)
        .HasColumnName("DateDeleted")
        .HasColumnOrder(11)
        .HasColumnType("datetime2(6)")
        .HasPrecision(6)
        .HasConversion(utcDateTimeConverter)
        .IsRequired(false);

        _ = modelBuilder.Entity<Address>()
        .Property(address => address.RowVersion)
        .HasColumnName("RowVersion")
        .HasColumnOrder(11)
        .IsRowVersion();

        #endregion

        #region CONFIGURATION DE LA LIAISON ENTITE Product A TABLE 'Products'
        _ = modelBuilder.Entity<Product>()
            .ToTable("Products")
            .HasKey(product => product.ProductId);

        // CONFIGURATION DES COLONNE DE LA TABLE 'Products'

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.ProductId)
            .HasColumnName("ProductId")
            .HasColumnOrder(0)
            .HasColumnType("int");

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.ProductName)
            .HasColumnName("ProductName")
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Product.PRODUCT_NAME_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.Desc)
            .HasColumnName("Desc")
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Product.DESC_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.CodeUPC)
            .HasColumnName("CodeUPC")
            .HasColumnOrder(3)
            .HasColumnType($"nvarchar({Product.CODE_UPC_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.PictureName)
            .HasColumnName("PictureName")
            .HasColumnOrder(4)
            .HasColumnType($"nvarchar({Product.PICTURE_NAME_MAX_LENGTH})")
            .IsRequired(false);

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.ClientId)
            .HasColumnName("ClientId")
            .HasColumnOrder(5)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.SupplierId)
            .HasColumnName("SupplierId")
            .HasColumnOrder(6)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.SupplierCode)
            .HasColumnName("SupplierCode")
            .HasColumnOrder(7)
            .HasColumnType($"nvarchar({Product.SUPPLIER_CODE_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.Quantity)
            .HasColumnName("SupplierCode")
            .HasColumnOrder(8)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.AimQuantity)
            .HasColumnName("AimQuanity")
            .HasColumnOrder(9)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.Weight)
            .HasColumnName("Weight")
            .HasColumnOrder(10)
            .HasColumnType("float")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(11)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasDefaultValueSql("GETUTCDATE()")
            .HasConversion(utcDateTimeConverter)
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(12)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(utcDateTimeConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(13)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(utcDateTimeConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<Product>()
            .Property(product => product.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnOrder(14)
            .IsRowVersion();
        #endregion

        #region CONFIGURATION DE LA LIAISON ENTITE Supplier A TABLE 'Suppliers'
        _ = modelBuilder.Entity<Supplier>()
            .ToTable("Suppliers")
            .HasKey(supplier => supplier.SupplierId);

        // CONFIGURATION DES COLONNE DE LA TABLE 'Suppliers'

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.SupplierId)
            .HasColumnName("SupplierId")
            .HasColumnOrder(0)
            .HasColumnType("int");

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.SupplierName)
            .HasColumnName("SupplierName")
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Supplier.SUPPLIER_NAME_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.ContactLastName)
            .HasColumnName("ContactLastName")
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Supplier.CONTACT_NAME_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.ContactFirstName)
            .HasColumnName("ContactFirstName")
            .HasColumnOrder(3)
            .HasColumnType($"nvarchar({Supplier.CONTACT_NAME_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.ContactEmail)
            .HasColumnName("ContactEmail")
            .HasColumnOrder(4)
            .HasColumnType($"nvarchar({Supplier.CONTACT_EMAIL_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.ContactPhone)
            .HasColumnName("ContactPhone")
            .HasColumnOrder(5)
            .HasColumnType($"nvarchar({Supplier.CONTACT_PHONE_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(6)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasDefaultValueSql("GETUTCDATE()")
            .HasConversion(utcDateTimeConverter)
            .IsRequired(true);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(7)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(utcDateTimeConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(8)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(utcDateTimeConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnOrder(9)
            .IsRowVersion();
        #endregion

        #region  CONFIGURATION DE LA LIAISON ENTITE Warehouse A TABLE 'Warehouses'

        _ = modelBuilder.Entity<Warehouse>()
            .ToTable("Warehouses")
            .HasKey(warehouse => warehouse.Id);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.Id)
            .HasColumnName("Id")
            .HasColumnOrder(0)
            .HasColumnType("int");

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.WareHouseName)
            .HasColumnName("WarehouseName")
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Warehouse.WAREHOUSE_NAME_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.AddressId)
            .HasColumnName("AddressId")
            .HasColumnOrder(2)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(3)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasDefaultValueSql("GETUTCDATE()")
            .HasConversion(utcDateTimeConverter)
            .IsRequired(true);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(4)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(utcDateTimeConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(5)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(utcDateTimeConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(warehouse => warehouse.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnOrder(6)
            .IsRowVersion();


        #endregion

        #region CONFIGURATION DE LA LIAISON ENTITE Shipment A TABLE 'Shipments'

        _ = modelBuilder.Entity<Shipment>()
            .ToTable("Shipments")
            .HasKey(shipment => shipment.Id);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.Id)
            .HasColumnName("Id")
            .HasColumnOrder(0)
            .HasColumnType("int");

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.Status)
            .HasColumnName("Status")
            .HasColumnOrder(1)
            .HasColumnType("nvarchar(16)")
            .IsRequired(true);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.ShippingService)
            .HasColumnName("ShippingService")
            .HasColumnOrder(2)
            .HasColumnType("nvarchar(16)")
            .IsRequired(true);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.ShippingOrderId)
            .HasColumnName("ShippingOrderId")
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.TrackingNumber)
            .HasColumnName("TrackingNumber")
            .HasColumnOrder(4)
            .HasColumnType($"nvarchar({Shipment.TRACKING_NUMBER_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(5)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasDefaultValueSql("GETUTCDATE()")
            .HasConversion(utcDateTimeConverter)
            .IsRequired(true);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(6)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(utcDateTimeConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(7)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(utcDateTimeConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<Shipment>()
            .Property(shipment => shipment.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnOrder(8)
            .IsRowVersion();


        #endregion

        // Note de Kadiatou : On peut tous mettre la configuration de nos relations ici 
        #region CONFIGURATION DES RELATIONS ENTRE ENTITES

        #region RELATION COTÉ PRODUCT
        _ = modelBuilder.Entity<Product>()
            .HasOne(product => product.Client)
            .WithMany(client => client.Products)
            .HasForeignKey(product => product.ClientId)
            .OnDelete(DeleteBehavior.Cascade);

        _ = modelBuilder.Entity<Product>()
            .HasOne(product => product.Supplier)
            .WithMany(supplier => supplier.Products)
            .HasForeignKey(product => product.SupplierId)
            .OnDelete(DeleteBehavior.SetNull);

        # endregion

        #region RELATION COTÉ SUPPLIER
        _ = modelBuilder.Entity<Supplier>()
            .HasMany(supplier => supplier.Products)
            .WithOne(product => product.Supplier)
            .HasForeignKey(product => product.SupplierId)
            .OnDelete(DeleteBehavior.Cascade);
        #endregion

        #region RELATIONS COTÉ USER
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

        #region RELATIONS COTÉ WAREHOUSE

        // Relation un à plusieurs entre Warehouse et Client coté Warehouse
        _ = modelBuilder.Entity<Warehouse>()
            .HasMany(warehouse => warehouse.Clients)
            .WithOne(client => client.AssignedWarehouse)
            .HasForeignKey(client => client.WarehouseId)
            .OnDelete(DeleteBehavior.Cascade);

        //Relation un à un entre Warehouse et Address coté Warehouse 
        _ = modelBuilder.Entity<Warehouse>()
            .HasOne(warehouse => warehouse.Adresse)
            .WithOne(address => address.OwnerWarehouse)
            .HasForeignKey<Warehouse>(warehouse => warehouse.AddressId)
            .OnDelete(DeleteBehavior.Cascade);

        //Relation un à plusieurs entre Warehouse et PurchaseOrder coté Warehouse
        _ = modelBuilder.Entity<Warehouse>()
            .HasMany(warehouse => warehouse.RestockOrders)
            .WithOne(purchaseOrder => purchaseOrder.Warehouse)
            .HasForeignKey(purchaseOrder => purchaseOrder.WarehouseId)
            .OnDelete(DeleteBehavior.Cascade);

        //Relation un à plusieurs entre Warehouse et User coté Warehouse
        _ = modelBuilder.Entity<Warehouse>()
            .HasMany(warehouse => warehouse.WarehouseEmployees)
            .WithOne(user => user.EmployeeWarehouse)
            .HasForeignKey(user => user.EmployeeWarehouseId)
            .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #region RELATION COTÉ SHIPMENT

        //Relation un à un entre Shipment et ShippingOrder coté Shipment
        _ = modelBuilder.Entity<Shipment>()
            .HasOne(shipment => shipment.ShippingOrder)
            .WithOne(shippingOrder => shippingOrder.Shipment)
            .HasForeignKey<Shipment>(shipment => shipment.ShippingOrderId)
            .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #region RELATION COTÉ CLIENT 

        // Relation plusieurs à plusieurs entre Client et Address
        _ = modelBuilder.Entity<Client>()
            .HasMany(client => client.Addresses)
            .WithMany(address => address.Clients);


        // Relation un à plusieurs entre Client et warehouse coté Client
        _ = modelBuilder.Entity<Client>()
            .HasOne(client => client.AssignedWarehouse)
            .WithMany(warehouse => warehouse.Clients)
            .HasForeignKey(client => client.AssignedWarehouseId)
            .OnDelete(DeleteBehavior.Cascade);

        // Relation un à plusieurs entre Client et Produit coté Client
        _ = modelBuilder.Entity<Client>()
            .HasMany(client => client.Products)
            .WithOne(product => product.Client)            
            .HasForeignKey(product => product.ClientId)
            .OnDelete(DeleteBehavior.Cascade);

        // Relation un à plusieurs entre Client et ShipmentOrder coté Client
        _ = modelBuilder.Entity<Client>()
            .HasOne(client => client.ShippingOrders)
            .WithMany(shippingOrder => shippingOrder.SourceClient)
            .HasForeignKey(shippingOrder => shippingOrder.SourceClientId)
            .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #region RELATION COTÉ ADDRESSE

        // Relation un à un entre Addresse et Warehouse côté addresse
        _ = modelBuilder.Entity<Address>()
            .HasOne(address => address.OwnerWarehouse)
            .WithOne(warehouse => warehouse.Adresse)
            .HasForeignKey<Warehouse>(warehouse => warehouse.AddressId)
            .OnDelete(DeleteBehavior.Cascade);

        // Relation un à un entre Adresse et ShippingOrder côté addresse
        _ = modelBuilder.Entity<Address>()
          .HasOne(address => address.OwnerShipOrder)
          .WithOne(shippingOrder => shippingOrder.DestinationAddress)
          .HasForeignKey<ShippingOrder>(shippingOrder => shippingOrder.DestinationAdressId)
          .OnDelete(DeleteBehavior.Cascade);


        #endregion

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

        User user1 = new User("hunter", "7761467A80A38D8429C0B80898FE3047F1E85E1C0CB2A9304FF72D028D39FF4D:" +
            "8C68F80262A76FDB8E595A6212B3545A:100000:SHA256") { // Mdp non hashé : ILoveEFCore
            Id = 1
        };

        user1.Roles.Add(role1);
        user1.Roles.Add(role2);

        User user2 = new User("deiiidia", "4ECAA597B625B3FCA7E36442D4C6A3EB05AB9DFFC9F254EE483FBDBEB6D2910C:" +
            "D761ED59218EDF8032D7F7882DE44EAE:100000:SHA256") { // Mpd non hashé : GitIsOurSavior
            Id = 2
        };

        user2.Roles.Add(role2);

        _ = modelBuilder.Entity<User>()
            .HasData(user1, user2);

        // Ajout des données de Supplier 
        Supplier sup1 = new Supplier("THE ULTIMATE SUPPLIER", "Test", "Jonhy", "jonhytest@gmail.com", "4503497684") { SupplierId = 1 };

        // Ajout des données de Clients 
        Client cli1 = new Client("MISA DARK JARJAR", "Binks", "Jar Jar", "darkjarjar@gmail.com", "450450450",10) { Id = 1 };

        // Ajout des données de Product
        Product pro1 = new Product("Chaise", "Une chaise sibole", "1038330384463", 1, 1, "acode", 50, 100, 50) { ProductId= 1 };

        #endregion

    }
}
