using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _420DA3_A24_Projet.Business.Services;

namespace _420DA3_A24_Projet.Presentation.Views;
public enum EnumView {
    View,
    Create,
    Update,
    Delete
}
internal partial class PurchaseOrderView : Form {
    private readonly WsysApplication parentApp;
    private EnumView currentAction;
    private PurchaseOrder currentInstance = null!;
    private bool isInitialize = false; // Si les données ont été initialisées
    public PurchaseOrderView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {

    }
    private void LoadPurchaseOrdeData(PurchaseOrder purchaseOrder) {
        this.currentInstance = purchaseOrder;

        this.idValue.Value = purchaseOrder.Id;
        this.quantiteValue.Value = purchaseOrder.Quantity;

        this.produitValue.SelectedItem = null;
        this.produitValue.SelectedIndex = -1;
        this.produitValue.SelectedItems.Clear();

        this.WarehouseValue.SelectedItem = null;
        this.WarehouseValue.SelectedIndex = -1;
        this.WarehouseValue.SelectedItems.Clear();



        List<Product> products = this.parentApp.ProductService.GetAllProducts();
        foreach (Product product in products) {
            if (product.ProductId == purchaseOrder.ProductId) {
                this.produitValue.SelectedItems.Add(product);
            }
        }


        List<Warehouse> warehouses = this.parentApp.WarehouseService.GetAllWarehouse();
        foreach (Warehouse warehouse in warehouses) {
            if (warehouse.Id == purchaseOrder.WarehouseId) {
                this.WarehouseValue.SelectedItems.Add(warehouse);
            }
        }

    }
    private void Initialize() {
        if (!this.isInitialize) {
            List<Product> products = this.parentApp.ProductService.GetAllProducts();
            foreach (Product product in products) {
                _ = this.produitValue.Items.Add(product);
            }


            List<Warehouse> warehouses = this.parentApp.WarehouseService.GetAllWarehouse();
            foreach (Warehouse warehouse in warehouses) {
                _ = this.WarehouseValue.Items.Add(warehouse);
            }
        }
        this.isInitialize = true;
    }
    public DialogResult OpenForView(PurchaseOrder purchaseOrder) {
        try {
            this.Initialize();
            this.currentAction = EnumView.View;
            this.LoadPurchaseOrdeData(purchaseOrder);
            this.btnAction.Text = "OK";
            this.idValue.Enabled = false;
            this.produitValue.Enabled = false;
            this.WarehouseValue.Enabled = false;
            this.quantiteValue.Enabled = false;
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    public DialogResult OpenForCreation(PurchaseOrder newPurchaseOrder) {
        try {
            this.currentAction = EnumView.Create;
            this.LoadPurchaseOrdeData(newPurchaseOrder);
            this.btnAction.Text = "Create";
            this.idValue.Enabled = false;
            this.produitValue.Enabled = true;
            this.WarehouseValue.Enabled = true;
            this.quantiteValue.Enabled = true;
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }
    public DialogResult OpenForModification(PurchaseOrder purchaseOrder) {
        try {
            this.Initialize();
            this.currentAction = EnumView.Update;
            this.LoadPurchaseOrdeData(purchaseOrder);
            this.btnAction.Text = "Save";
            this.idValue.Enabled = false;
            this.produitValue.Enabled = true;
            this.WarehouseValue.Enabled = true;
            this.quantiteValue.Enabled = true;
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }
    public DialogResult OpenForDeletion(PurchaseOrder purchaseOrder) {
        try {
            this.Initialize();
            this.currentAction = EnumView.Delete;
            this.LoadPurchaseOrdeData(purchaseOrder);
            this.btnAction.Text = "Confirm";
            this.idValue.Enabled = false;
            this.idValue.Enabled = false;
            this.produitValue.Enabled = false;
            this.WarehouseValue.Enabled = false;
            this.quantiteValue.Enabled = false;

            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    private void button2_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
