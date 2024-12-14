using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_A24_Projet.Presentation;

/// <summary>
/// Classe représentant la vue du menu principal des employés de bureau
/// </summary>
internal partial class OffEmployeeMainMenu : Form {
    /// <summary>
    /// L'application elle-même
    /// </summary>
    private WsysApplication parentApp;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="parentApp">L'application</param>
    public OffEmployeeMainMenu(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
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
    private void productSearchTextBox_TextChanged(object sender, EventArgs e) {
        List<Product> results = this.parentApp.ProductService.SearchProduct(this.productSearchTextBox.Text.Trim());
        this.LoadProductsInListBox(results);
    }

    /// <summary>
    /// Load une liste de product que l'on peut sélectionner pour effectuer des actions
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void productListBox_SelectedIndexChanged(object sender, EventArgs e) {
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
    private void createProductButton_Click(object sender, EventArgs e) {
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
    private void seeProductDetailsButton_Click(object sender, EventArgs e) {
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
    private void updateProductButton_Click(object sender, EventArgs e) {
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
    private void deleteProductButton_Click(object sender, EventArgs e) {
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
    private void supplierSearchTextBox_TextChanged(object sender, EventArgs e) {
        List<Supplier> results = this.parentApp.SupplierService.SearchSupplier(this.supplierSearchTextBox.Text.Trim());
        this.LoadSuppliersInListBox(results);
    }

    /// <summary>
    /// Load une liste de supplier que l'on peut sélectionner pour effectuer des actions
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void supplierListBox_SelectedIndexChanged(object sender, EventArgs e) {
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
    private void createSupplierButton_Click(object sender, EventArgs e) {
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
    private void seeSupplierDetailsButton_Click(object sender, EventArgs e) {
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
    private void updateSupplierButton_Click(object sender, EventArgs e) {
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
    private void deleteSupplierButton_Click(object sender, EventArgs e) {
        Supplier? selectedSupplier = this.supplierListBox.SelectedItem as Supplier;
        if (selectedSupplier != null) {
            _ = this.parentApp.SupplierService.OpenViewForDeletion(selectedSupplier);
            this.supplierListBox.Refresh();
        }
    }


    #endregion

    private void logoutButton_Click(object sender, EventArgs e) {

    }


}
