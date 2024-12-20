﻿using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.Presentation;

/// <summary>
/// Classe représentant la vue du menu principal des employés de bureau
/// </summary>
internal partial class OffEmployeeMainMenu : Form {
    /// <summary>
    /// L'application elle-même
    /// </summary>
    private readonly WsysApplication parentApp;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="parentApp">L'application</param>
    public OffEmployeeMainMenu(WsysApplication parentApp) {
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

    #region Shipping Order

    /// <summary>
    /// Charger une liste d'ordre d'expédition dans la list box fait pour
    /// </summary>
    /// <param name="sos">La liste d'ordre d'expédition à charger</param>
    private void LoadShippingOrdersInListBox(List<ShippingOrder> sos) {
        this.soListBox.Items.Clear();
        this.soListBox.SelectedItem = null;
        this.soListBox.SelectedIndex = -1;

        foreach (ShippingOrder so in sos) {
            _ = this.soListBox.Items.Add(so);
        }
    }

    /// <summary>
    /// Activer les boutons d'action pour un ordre d'expédition
    /// </summary>
    public void ActivateShippingOrderActionButtons() {
        this.createSoButton.Enabled = true;
        this.seeSoDetailsButton.Enabled = true;
        this.updateSoButtton.Enabled = true;
        this.deleteSoButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver les boutons d'action pour un ordre d'expédition
    /// </summary>
    public void DeactivateShippingOrderActionButtons() {
        this.createSoButton.Enabled = false;
        this.seeSoDetailsButton.Enabled = false;
        this.updateSoButtton.Enabled = false;
        this.deleteSoButton.Enabled = false;
    }

    /// <summary>
    /// Declencher le processus de création d'un ordre expédition
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateSoButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.ShippingOrderServices.OpenViewForCreation();
    }

    /// <summary>
    /// Declencher le processus de recherches d'ordres expédition
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SearchSOTextBox_TextChanged(object sender, EventArgs e) {
        string filter = this.searchSOTextBox.Text.Trim();

        // TODO: Add search method in so services
        //this.LoadShippingOrdersInListBox(this.parentApp.ShippingOrderServices.Search(filter));
    }

    /// <summary>
    /// Activer les boutons d'action si un item est selectionné, dans le cas contraire
    /// les desactiver, dans la list box des ordres d'expédition
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SoListBox_SelectedIndexChanged(object sender, EventArgs e) {
        ShippingOrder? selectedSo = this.soListBox.SelectedItem as ShippingOrder;

        if (selectedSo != null) {
            this.ActivateShippingOrderActionButtons();
        } else {
            this.DeactivateShippingOrderActionButtons();
        }
    }

    /// <summary>
    /// Declencher le processus de visualisation d'un ordre expédition
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SeeSoDetailsButton_Click(object sender, EventArgs e) {
        ShippingOrder? selectedSo = this.soListBox.SelectedItem as ShippingOrder;

        if (selectedSo != null) {
            _ = this.parentApp.ShippingOrderServices.OpenViewForView(selectedSo);
        }
    }

    /// <summary>
    /// Declencher le processus de modification d'un ordre expédition
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UpdateSoButtton_Click(object sender, EventArgs e) {
        ShippingOrder? selectedSo = this.soListBox.SelectedItem as ShippingOrder;

        if (selectedSo != null) {
            _ = this.parentApp.ShippingOrderServices.OpenViewForModification(selectedSo);
        }
    }

    /// <summary>
    /// Declencher le processus de suppression d'un ordre expédition
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DeleteSoButton_Click(object sender, EventArgs e) {
        ShippingOrder? selectedSo = this.soListBox.SelectedItem as ShippingOrder;

        if (selectedSo != null) {
            _ = this.parentApp.ShippingOrderServices.OpenViewForDeletion(selectedSo);
        }
    }

    #endregion

    #region Client 

    /// <summary>
    /// Charger une liste de clients dans la list box fait pour
    /// </summary>
    /// <param name="clients">La liste de clients à charger</param>
    private void LoadClientsInListBox(List<Client> clients) {
        this.clientListBox.Items.Clear();
        this.clientListBox.SelectedItem = null;
        this.clientListBox.SelectedIndex = -1;

        foreach (Client client in clients) {
            _ = this.clientListBox.Items.Add(client);
        }
    }

    /// <summary>
    /// Activer les boutons d'action pour un client
    /// </summary>
    private void ActivateClientActionButtons() {
        this.createClientButton.Enabled = true;
        this.seeClientDetailsButton.Enabled = true;
        this.updateClientButton.Enabled = true;
        this.deleteClientButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver les boutons d'action pour un client
    /// </summary>
    private void DeactivateClientActionButtons() {
        this.createClientButton.Enabled = false;
        this.seeClientDetailsButton.Enabled = false;
        this.updateClientButton.Enabled = false;
        this.deleteClientButton.Enabled = false;
    }

    #endregion

    #region Product

    /// <summary>
    /// Effectuer une recherche d'un produit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ProductSearchTextBox_TextChanged(object sender, EventArgs e) {
        List<Product> results = this.parentApp.ProductService.SearchProduct(this.productSearchTextBox.Text.Trim());
        this.LoadProductsInListBox(results);
    }

    /// <summary>
    /// Load une liste de product que l'on peut sélectionner pour effectuer des actions
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ProductListBox_SelectedIndexChanged(object sender, EventArgs e) {
        Product? selectedProduct = this.productListBox.SelectedItem as Product;
        if (selectedProduct != null) {
            this.ActivateProductActionButtons();
        } else {
            this.DeactivateProductActionButtons();
        }
    }

    /// <summary>
    /// Ouvre la vue de création de produit et l'ajout a la liste par la suite
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateProductButton_Click(object sender, EventArgs e) {
        Product? product = this.parentApp.ProductService.OpenViewForCreation();
        if (product != null) {
            _ = this.productListBox.Items.Add(product);
        }
    }

    /// <summary>
    /// Ouvre la vue de visualisation d'un produit sélectionné
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SeeProductDetailsButton_Click(object sender, EventArgs e) {
        Product? selectedProduct = this.productListBox.SelectedItem as Product;
        if (selectedProduct != null) {
            _ = this.parentApp.ProductService.OpenViewForView(selectedProduct);
        }
    }

    /// <summary>
    /// Ouvre la vue de modification d'un produit sélectionné
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UpdateProductButton_Click(object sender, EventArgs e) {
        Product? selectedProduct = this.productListBox.SelectedItem as Product;
        if (selectedProduct != null) {
            _ = this.parentApp.ProductService.OpenViewForModification(selectedProduct);
            this.productListBox.Refresh();
        }
    }

    /// <summary>
    /// Ouvre la vue pour supprimer un produit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DeleteProductButton_Click(object sender, EventArgs e) {
        Product? selectedProduct = this.productListBox.SelectedItem as Product;
        if (selectedProduct != null) {
            _ = this.parentApp.ProductService.OpenViewForDeletion(selectedProduct);
            this.productListBox.Refresh();
        }
    }

    /// <summary>
    /// Charger une liste de produits dans la list box fait pour
    /// </summary>
    /// <param name="products">La liste de produits à charger</param>
    private void LoadProductsInListBox(List<Product> products) {
        this.productListBox.Items.Clear();
        this.productListBox.SelectedItem = null;
        this.productListBox.SelectedIndex = -1;

        foreach (Product product in products) {
            _ = this.productListBox.Items.Add(product);
        }
    }

    /// <summary>
    /// Activer les boutons d'action pour un produit
    /// </summary>
    private void ActivateProductActionButtons() {
        this.createProductButton.Enabled = true;
        this.seeProductDetailsButton.Enabled = true;
        this.updateProductButton.Enabled = true;
        this.deleteProductButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver les boutons d'action pour un produit
    /// </summary>
    private void DeactivateProductActionButtons() {
        this.createProductButton.Enabled = false;
        this.seeProductDetailsButton.Enabled = false;
        this.updateProductButton.Enabled = false;
        this.deleteProductButton.Enabled = false;
    }

    #endregion

    #region Supplier

    /// <summary>
    /// Charger une liste de fournisseurs dans la list box fait pour
    /// </summary>
    /// <param name="suppliers">La liste de fournisseurs à charger</param>
    private void LoadSuppliersInListBox(List<Supplier> suppliers) {
        this.supplierListBox.Items.Clear();
        this.supplierListBox.SelectedItem = null;
        this.supplierListBox.SelectedIndex = -1;

        foreach (Supplier supplier in suppliers) {
            _ = this.supplierListBox.Items.Add(supplier);
        }
    }

    /// <summary>
    /// Activer les boutons d'action pour un fournisseur
    /// </summary>
    private void ActivateSupplierActionButton() {
        this.createSupplierButton.Enabled = true;
        this.seeSupplierDetailsButton.Enabled = true;
        this.updateSupplierButton.Enabled = true;
        this.deleteSupplierButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver les boutons d'action pour un fournisseur
    /// </summary>
    private void DeactivateSupplierActionButton() {
        this.createSupplierButton.Enabled = false;
        this.seeSupplierDetailsButton.Enabled = false;
        this.updateSupplierButton.Enabled = false;
        this.deleteSupplierButton.Enabled = false;
    }

    /// <summary>
    /// Effectuer une recherche d'un supplier
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SupplierSearchTextBox_TextChanged(object sender, EventArgs e) {
        List<Supplier> results = this.parentApp.SupplierService.SearchSupplier(this.supplierSearchTextBox.Text.Trim());
        this.LoadSuppliersInListBox(results);
    }

    /// <summary>
    /// Load une liste de supplier que l'on peut sélectionner pour effectuer des actions
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
    /// Ouvre la vue de création de supplier et l'ajout a la liste par la suite
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateSupplierButton_Click(object sender, EventArgs e) {
        Supplier? supplier = this.parentApp.SupplierService.OpenViewForCreation();
        if (supplier != null) {
            _ = this.productListBox.Items.Add(supplier);
        }
    }

    /// <summary>
    /// Ouvre la vue de visualisation d'un supplier
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SeeSupplierDetailsButton_Click(object sender, EventArgs e) {
        Supplier? selectedSupplier = this.supplierListBox.SelectedItem as Supplier;
        if (selectedSupplier != null) {
            _ = this.parentApp.SupplierService.OpenViewForView(selectedSupplier);
        }
    }

    /// <summary>
    /// Ouvre la vue de modification d'un supplier
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UpdateSupplierButton_Click(object sender, EventArgs e) {
        Supplier? selectedSupplier = this.supplierListBox.SelectedItem as Supplier;
        if (selectedSupplier != null) {
            _ = this.parentApp.SupplierService.OpenViewForModification(selectedSupplier);
            this.supplierListBox.Refresh();
        }
    }

    /// <summary>
    /// Ouvre la vue pour supprimer un supplier
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DeleteSupplierButton_Click(object sender, EventArgs e) {
        Supplier? selectedSupplier = this.supplierListBox.SelectedItem as Supplier;
        if (selectedSupplier != null) {
            _ = this.parentApp.SupplierService.OpenViewForDeletion(selectedSupplier);
            this.supplierListBox.Refresh();
        }
    }


    #endregion

    /// <summary>
    /// Déclencher le processus de deconnexion
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LogoutButton_Click(object sender, EventArgs e) {
        this.parentApp.LoginService.Logout();
        this.DialogResult = DialogResult.Continue;
    }


}
