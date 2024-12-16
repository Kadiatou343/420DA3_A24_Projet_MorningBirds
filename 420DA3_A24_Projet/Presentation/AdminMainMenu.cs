using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation;
internal partial class AdminMainMenu : Form {
    /// <summary>
    /// L'application elle-même
    /// </summary>
    private readonly WsysApplication parentApp;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="parentApp">L'application</param>
    public AdminMainMenu(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    /// <summary>
    /// Remplissage du label de salutation de l'utilisateur connecté et ouverture de la vue en mode modal
    /// </summary>
    /// <returns>Le résultat de l'ouverture de la vue</returns>
    public DialogResult OpenView() {
        this.greetingLabel.Text = "Bonjour " + this.parentApp.LoginService.LoggedInUser?.Username;
        return this.ShowDialog();
    }


    /// <summary>
    /// Deconnexion de l'utilisateur courant
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LogoutButtton_Click(object sender, EventArgs e) {
        this.parentApp.LoginService.Logout();
        this.DialogResult = DialogResult.Continue;
    }

    #region Gestion des utilisateurs

    /// <summary>
    /// Charger une liste d'utilisateurs dans la list box des utilisateurs
    /// </summary>
    /// <param name="users">La liste d'utilisateurs</param>
    private void LoadUsersInListBox(List<User> users) {
        this.userListBox.Items.Clear();
        this.userListBox.SelectedItem = null;
        this.userListBox.SelectedIndex = -1;

        foreach (User user in users) {
            _ = this.userListBox.Items.Add(user);
        }
    }

    /// <summary>
    /// Activer les boutons d'action pour les utilisateurs
    /// </summary>
    private void ActivateUserActionButtons() {
        this.seeUserDetailsButton.Enabled = true;
        this.updateUserButton.Enabled = true;
        this.deleteUserButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver les boutons d'action pour les utilisateurs
    /// </summary>
    private void DeactivateUserActionButtons() {
        this.seeUserDetailsButton.Enabled = false;
        this.updateUserButton.Enabled = false;
        this.deleteUserButton.Enabled = false;
    }

    /// <summary>
    /// Activer les boutons d'action utilisateurs à chaque fois l'utilisateur selectionné change dans la list box
    /// Desactiver les boutons d'action utilisateurs lorsqu'aucun utilisateur n'est selectionné
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UserListBox_SelectedIndexChanged(object sender, EventArgs e) {
        User? selectedUser = this.userListBox.SelectedItem as User;
        if (selectedUser is not null) {
            this.ActivateUserActionButtons();
        } else {
            this.DeactivateUserActionButtons();
        }
    }

    /// <summary>
    /// Déclencher le processsus de visualisation d'un utilisateur
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SeeUserDetailsButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.UserService.OpenViewFor(ViewActionsEnum.Visualization,
             this.userListBox.SelectedItem as User);
    }

    /// <summary>
    /// Déclencher le processsus de mise à jour d'un utilisateur
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UpdateUserButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.UserService.OpenViewFor(ViewActionsEnum.Edition,
             this.userListBox.SelectedItem as User);

        this.userListBox.Refresh();
    }

    /// <summary>
    /// Déclencher le processsus de suppression  d'un utilisateur
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DeleteUserButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.UserService.OpenViewFor(ViewActionsEnum.Deletion,
            this.userListBox.SelectedItem as User);

        this.userListBox.Refresh();
    }

    /// <summary>
    /// Déclencher le processsus de création d'un utilisateur
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateUserButton_Click(object sender, EventArgs e) {
        User? createdUser = this.parentApp.UserService.OpenViewFor(ViewActionsEnum.Creation);

        if (createdUser is not null) {
            _ = this.userListBox.Items.Add(createdUser);
            this.userListBox.SelectedItem = createdUser;
        }
    }

    /// <summary>
    /// Déclencher le processsus de recherche d'utilisateurs à chaque que le texte de recherche change
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UserSearchTextBox_TextChanged(object sender, EventArgs e) {
        List<User> users = this.parentApp.UserService.SearchUsers(
            this.userSearchTextBox.Text.Trim());

        this.LoadUsersInListBox(users);
    }

    #endregion

    #region Gestion des rôles

    /// <summary>
    /// Charger une liste de rôles dans la list box des rôles
    /// </summary>
    /// <param name="roles">La liste de rôles</param>
    private void LoadRolesInListBox(List<Role> roles) {
        this.roleListBox.Items.Clear();
        this.roleListBox.SelectedItem = null;
        this.roleListBox.SelectedIndex = -1;

        foreach (Role role in roles) {
            _ = this.roleListBox.Items.Add(role);
        }
    }

    /// <summary>
    /// Activer les boutons d'action pour les rôles
    /// </summary>
    private void ActivateRoleActionButtons() {
        this.seeRoleDetailsButton.Enabled = true;
        this.updateRoleButton.Enabled = true;
        this.deleteRoleButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver les boutons d'action pour les rôles
    /// </summary>
    private void DeactivateRoleActionButtons() {
        this.seeRoleDetailsButton.Enabled = false;
        this.updateRoleButton.Enabled = false;
        this.deleteRoleButton.Enabled = false;
    }

    /// <summary>
    /// Déclencher le processsus de création d'un rôle
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateRoleButton_Click(object sender, EventArgs e) {
        Role? createdRole = this.parentApp.RoleService.OpenViewFor(ViewActionsEnum.Creation);

        if (createdRole is not null) {
            _ = this.userListBox.Items.Add(createdRole);
            this.roleListBox.SelectedItem = createdRole;
        }
    }

    /// <summary>
    /// Déclencher le processsus de visualisation d'un rôle
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SeeRoleDetailsButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.RoleService.OpenViewFor(ViewActionsEnum.Visualization,
            this.roleListBox.SelectedItem as Role);
    }


    /// <summary>
    /// Déclencher le processsus de mise à jour d'un rôle
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UpdateRoleButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.RoleService.OpenViewFor(ViewActionsEnum.Edition,
            this.roleListBox.SelectedItem as Role);
    }

    /// <summary>
    /// Déclencher le processsus de suppression d'un rôle
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DeleteRoleButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.RoleService.OpenViewFor(ViewActionsEnum.Deletion,
            this.roleListBox.SelectedItem as Role);
    }

    /// <summary>
    /// Déclencher le processsus de recherche de rôles
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RoleSearchTextBox_TextChanged(object sender, EventArgs e) {
        List<Role> roles = this.parentApp.RoleService.SearchRoles(
            this.roleSearchTextBox.Text.Trim());
        this.LoadRolesInListBox(roles);
    }

    /// <summary>
    /// Activer les boutons d'action des rôles à chaque fois que le rôle selectionné dans la list box change
    /// Desactiver les boutons d'action lorsqu'aucun rôle n'est selectionné
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RoleListBox_SelectedIndexChanged(object sender, EventArgs e) {
        Role? selectedRole = this.roleListBox.SelectedItem as Role;

        if (selectedRole is not null) {
            this.ActivateRoleActionButtons();
        } else {
            this.DeactivateRoleActionButtons();
        }
    }

    #endregion


    private void DeleteSoButton_Click(object sender, EventArgs e) {
        ShippingOrder? selectedShippingorder = this.ShippingOrderListBox.SelectedItem as ShippingOrder;

        if (selectedShippingorder != null) {
            _ = this.parentApp.ShippingOrderServices.OpenViewForDeletion(selectedShippingorder);
        }
    }

    private void DeleteClientButton_Click(object sender, EventArgs e) {

    }

    #region Gestion des produits 

    /// <summary>
    /// Activer les boutons d'action pour les produits
    /// </summary>
    private void ActivateProductActionButtons() {
        this.seePoDetailsButton.Enabled = true;
        this.updateProdButton.Enabled = true;
        this.deleteProdButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver les boutons d'action pour les produits
    /// </summary>
    private void DeactivateProductActionButtons() {
        this.seePoDetailsButton.Enabled = false;
        this.updateProdButton.Enabled = false;
        this.deleteProdButton.Enabled = false;
    }

    /// <summary>
    /// Charger une liste de produits dans la list box fait pour
    /// </summary>
    /// <param name="products">La liste de produits</param>
    private void LoadProductsInListBox(List<Product> products) {
        this.prodListBox.Items.Clear();
        this.prodListBox.SelectedItem = null;
        this.prodListBox.SelectedIndex = -1;

        foreach (Product product in products) {
            _ = this.prodListBox.Items.Add(product);
        }
    }
   

    /// <summary>
    /// Declencher le processus de création d'un produit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateProductButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.ProductService.OpenViewForCreation();
    }

    /// <summary>
    /// Déclencher le processsus de recherche de produits
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SearchProdTextBox_TextChanged(object sender, EventArgs e) {
        string filter = this.searchProdTextBox.Text.Trim();

        this.LoadProductsInListBox(this.parentApp.ProductService.SearchProduct(filter));
    }

    /// <summary>
    /// Activer les boutons d'action des produits si un item est selectionné, le cas contraire les desactiver, 
    /// dans la list box des produits
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ProdListBox_SelectedIndexChanged(object sender, EventArgs e) {
        Product? selectedProd = this.prodListBox.SelectedItem as Product;

        if (selectedProd != null) {
            this.ActivateProductActionButtons();
        } else {
            this.DeactivateProductActionButtons();
        }
    }

    /// <summary>
    /// Déclencher le processsus de visualisation d'un produit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SeeProdDetailsButton_Click(object sender, EventArgs e) {
        Product? selectedProd = this.prodListBox.SelectedItem as Product;

        if (selectedProd != null) {
            _ = this.parentApp.ProductService.OpenViewForView(selectedProd);
        }
    }

    /// <summary>
    /// Déclencher le processsus de mise à jour d'un produit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UpdateProdButton_Click(object sender, EventArgs e) {
        Product? selectedProd = this.prodListBox.SelectedItem as Product;

        if (selectedProd != null) {
            _ = this.parentApp.ProductService.OpenViewForModification(selectedProd);
        }
    }

    /// <summary>
    /// Déclencher le processsus de suppression d'un produit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DeleteProdButton_Click(object sender, EventArgs e) {
        Product? selectedProd = this.prodListBox.SelectedItem as Product;

        if (selectedProd != null) {
            _ = this.parentApp.ProductService.OpenViewForDeletion(selectedProd);
        }
    }

    #endregion

    #region Gestion des fournisseurs

    /// <summary>
    /// Charger une liste de fournisseurs dans la list box fait pour
    /// </summary>
    /// <param name="suppliers">La liste de fournisseurs fournie</param>
    private void LoadSuppliersInListBox(List<Supplier> suppliers) {
        this.supplierListBox.Items.Clear();
        this.supplierListBox.SelectedItem = null;
        this.supplierListBox.SelectedIndex = -1;

        foreach (Supplier supplier in suppliers) {
            _ = this.supplierListBox.Items.Add(supplier);
        }
    }

    /// <summary>
    /// Activer les boutons d'action pour les fournisseurs
    /// </summary>
    private void ActivateSupplierActionButton() {
        this.seeSupplierDetailsBtn.Enabled = true;
        this.updateSupplierButton.Enabled = true;
        this.deleteSupllierButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver les boutons d'action pour les fournisseurs
    /// </summary>
    private void DeactivateSupplierActionButton() {
        this.seeSupplierDetailsBtn.Enabled = false;
        this.updateSupplierButton.Enabled = false;
        this.deleteSupllierButton.Enabled = false;
    }

    /// <summary>
    /// Declencher le processus de création d'un fournisseur
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateSupplierButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.SupplierService.OpenViewForCreation();
    }

    /// <summary>
    /// Déclencher le processsus de recherche de fournisseurs
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SearchSupplierTextBox_TextChanged(object sender, EventArgs e) {
        string filter = this.searchSupplierTextBox.Text.Trim();

        this.LoadSuppliersInListBox(this.parentApp.SupplierService.SearchSupplier(filter));
    }

    /// <summary>
    /// Activer les boutons d'action des fournisseurs si un item est selectionné, le cas contraire 
    /// les desactiver, dans la list box des fournisseurs
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SupplierListBox_SelectedIndexChanged(object sender, EventArgs e) {
        Supplier? selectedSupplier = this.supplierListBox.SelectedItem as Supplier;

        if (selectedSupplier != null) {
            this.ActivateSupplierActionButton();
        } else {
            this.DeactivateSupplierActionButton();
        }
    }

    /// <summary>
    /// Déclencher le processsus de visualisation d'un fournisseur
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SeeSupplierDetailsBtn_Click(object sender, EventArgs e) {
        Supplier? selectedSupplier = this.supplierListBox.SelectedItem as Supplier;

        if (selectedSupplier != null) {
            _ = this.parentApp.SupplierService.OpenViewForView(selectedSupplier);
        }
    }

    /// <summary>
    /// Déclencher le processsus de mise à jour d'un fournisseur
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UpdateSupplierButton_Click(object sender, EventArgs e) {
        Supplier? selectedSupplier = this.supplierListBox.SelectedItem as Supplier;

        if (selectedSupplier != null) {
            _ = this.parentApp.SupplierService.OpenViewForModification(selectedSupplier);
        }
    }

    /// <summary>
    /// Déclencher le processsus de suppression d'un fournisseur
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DeleteSupllierButton_Click(object sender, EventArgs e) {
        Supplier? selectedSupplier = this.supplierListBox.SelectedItem as Supplier;

        if (selectedSupplier != null) {
            _ = this.parentApp.SupplierService.OpenViewForDeletion(selectedSupplier);
        }
    }

    #endregion

    #region Gestion des entrepôts 

    /// <summary>
    /// Charger une liste d'entrepôts dans la list box fait pour
    /// </summary>
    /// <param name="warehouses">La liste d'entrepôts fournie</param>
    private void LoadWarehousesInListBox(List<Warehouse> warehouses) {
        this.warehouseListBox.Items.Clear();
        this.warehouseListBox.SelectedItem = null;
        this.warehouseListBox.SelectedIndex = -1;

        foreach (Warehouse warehouse in warehouses) {
            _ = this.warehouseListBox.Items.Add(warehouse);
        }
    }

    /// <summary>
    /// Activer les boutons d'actions pour les entrepôts
    /// </summary>
    private void ActivateWarehouseActionButton() {
        this.seeWhDetailsButton.Enabled = true;
        this.updateWarehouseBtn.Enabled = true;
        this.deleteWarehouseBtn.Enabled = true;
    }

    /// <summary>
    /// Desactiver les boutons d'actions pour les entrepôts
    /// </summary>
    private void DeactivateWarehouseActionButton() {
        this.seeWhDetailsButton.Enabled = false;
        this.updateWarehouseBtn.Enabled = false;
        this.deleteWarehouseBtn.Enabled = false;
    }

    /// <summary>
    /// Declencher le processus de création d'un entrepôt
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateWarehouseButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.WarehouseService.OpenViewForCreation();
    }

    /// <summary>
    /// Declencher le processus de recherche d'entrepôts
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SearchWhseTextBox_TextChanged(object sender, EventArgs e) {
        string filter = this.searchWhseTextBox.Text.Trim();

        this.LoadWarehousesInListBox(this.parentApp.WarehouseService.SearchWarehouse(filter));
    }


    /// <summary>
    /// Activer les boutons d'action si un item est selectionné, dans le cas contraire
    /// les desactiver, dans la list box des entrepôts
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WarehouseListBox_SelectedIndexChanged(object sender, EventArgs e) {
        Warehouse? selectedWh = this.warehouseListBox.SelectedItem as Warehouse;

        if (selectedWh != null) {
            this.ActivateWarehouseActionButton();
        } else {
            this.DeactivateWarehouseActionButton();
        }
    }

    /// <summary>
    /// Declencher le processus de visualisation d'un entrepôt
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SeeWhDetailsButton_Click(object sender, EventArgs e) {
        Warehouse? selectedWh = this.warehouseListBox.SelectedItem as Warehouse;

        if (selectedWh != null) {
            _ = this.parentApp.WarehouseService.OpenForView(selectedWh);
        }
    }

    /// <summary>
    /// Declencher le processus de mise à jour d'un entrepôt
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UpdateWarehouseBtn_Click(object sender, EventArgs e) {
        Warehouse? selectedWh = this.warehouseListBox.SelectedItem as Warehouse;

        if (selectedWh != null) {
            _ = this.parentApp.WarehouseService.OpenViewForUpdate(selectedWh);
        }
    }

    /// <summary>
    /// Declencher le processus de suppression d'un entrepôt
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DeleteWarehouseBtn_Click(object sender, EventArgs e) {
        Warehouse? selectedWh = this.warehouseListBox.SelectedItem as Warehouse;

        if (selectedWh != null) {
            _ = this.parentApp.WarehouseService.OpenViewForDelete(selectedWh);
        }
    }

    #endregion

    #region Gestion des expéditions

    /// <summary>
    /// Charger une liste d'expéditions dans la list box fait pour
    /// </summary>
    /// <param name="shipments"></param>
    private void LoadShipmentsInListBox(List<Shipment> shipments) {
        this.shipmentListBox.Items.Clear();
        this.shipmentListBox.SelectedItem = null;
        this.shipmentListBox.SelectedIndex = -1;

        foreach(Shipment shipment in shipments) {
            _ = this.shipmentListBox.Items.Add(shipment);
        }
    }

    /// <summary>
    /// Activer le bouton d'action des expéditions
    /// </summary>
    private void ActivateShipmentActionButton() {
        this.seeShipmentDetailsButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver le bouton d'action des expéditions
    /// </summary>
    private void DeactivateShipmentActionButton() {
        this.seeShipmentDetailsButton.Enabled = false;
    }

    /// <summary>
    /// Declencher le processus de création d'expédition
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateShipmentButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.ShipmentService.OpenViewForCreation();
    }

    /// <summary>
    /// Declencher le processus de recherche d'expéditions
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SearchShipmentTextBox_TextChanged(object sender, EventArgs e) {
        string filter = this.searchShipmentTextBox.Text.Trim();

        this.LoadShipmentsInListBox(this.parentApp.ShipmentService.SearchShipment(filter));
    }

    /// <summary>
    /// Activer le bouton d'action si un item est selectionné, dans le cas contraire
    /// les desactiver, dans la list box des expéditions
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ShipmentListBox_SelectedIndexChanged(object sender, EventArgs e) {
        Shipment? selectedShip = this.shipmentListBox.SelectedItem as Shipment;

        if (selectedShip != null) {
            this.ActivateShipmentActionButton();
        } else {
            this.DeactivateShipmentActionButton();
        }
    }

    /// <summary>
    /// Declencher le processus de visualisation d'expédition
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SeeShipmentDetailsButton_Click(object sender, EventArgs e) {
        Shipment? selectedShip = this.shipmentListBox.SelectedItem as Shipment;

        if (selectedShip != null) {
            _ = this.parentApp.ShipmentService.OpenViewForView(selectedShip);
        }
    }

    #endregion


    private void LoaShippingOrderInListBox(List<ShippingOrder> shippingOrders) {
        this.ShippingOrderListBox.Items.Clear();
        this.ShippingOrderListBox.SelectedItem = null;
        this.ShippingOrderListBox.SelectedIndex = -1;

        foreach (ShippingOrder shippingOrder in shippingOrders) {
            _ = this.ShippingOrderListBox.Items.Add(shippingOrder);
        }
    }
    private void LoadPurchaseOrderInListBox(List<PurchaseOrder> purchaseOrders) {
        this.PurchaseOrderListBox.Items.Clear();
        this.PurchaseOrderListBox.SelectedItem = null;
        this.PurchaseOrderListBox.SelectedIndex = -1;

        foreach (PurchaseOrder purchaseOrder in purchaseOrders) {
            _ = this.ShippingOrderListBox.Items.Add(purchaseOrder);
        }
    }
    private void SeeSoDetailsButton_Click(object sender, EventArgs e) {
        ShippingOrder? selectedShippingOrder = this.ShippingOrderListBox.SelectedItem as ShippingOrder;

        if (selectedShippingOrder != null) {
            _ = this.parentApp.ShippingOrderServices.OpenViewForView(selectedShippingOrder);
        }
    }

    private void UpdateSoButton_Click(object sender, EventArgs e) {
        ShippingOrder? selectedShippingOrder = this.ShippingOrderListBox.SelectedItem as ShippingOrder;

        if (selectedShippingOrder != null) {
            _ = this.parentApp.ShippingOrderServices.OpenViewForModification(selectedShippingOrder);
        }
    }

    private void SeePoDetailsButton_Click(object sender, EventArgs e) {
        PurchaseOrder? selectedPurchaseOrder = this.PurchaseOrderListBox.SelectedItem as PurchaseOrder;

        if (selectedPurchaseOrder != null) {
            _ = this.parentApp.PurchaseOrderServices.OpenViewForView(selectedPurchaseOrder);
        }
    }

    private void SearchSoTextBox_TextChanged(object sender, EventArgs e) {
        string filter = this.searchShippingOrder.Text.Trim();

        this.LoaShippingOrderInListBox(this.parentApp.ShippingOrderServices.SearchShippingOrder(filter));
    }

    private void SearchPoTextBox_TextChanged(object sender, EventArgs e) {
        string filter = this.searchPurchaseOrderPoTextBox.Text.Trim();

        this.LoadPurchaseOrderInListBox(this.parentApp.PurchaseOrderServices.SearchPurchaseOrderNomProd(filter));

    }
}
