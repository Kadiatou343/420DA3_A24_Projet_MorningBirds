using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using System.Data;

namespace _420DA3_A24_Projet.Presentation.Views;

/// <summary>
/// Enum pour diriger les view dépendemment de l'action souhaité
/// </summary>
public enum ViewActionEnum {
    View,
    Create,
    Update,
    Delete
}
internal partial class SupplierView : Form {

    private readonly WsysApplication parentApp;
    private ViewActionEnum currentAction;
    private Supplier currentInstance = null!;
    private bool isInitialize = false; // Si les données ont été initialisées
    public SupplierView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
        this.supplierNameValue.MaxLength = Supplier.SUPPLIER_NAME_MAX_LENGTH;
        this.ctcLastNameValue.MaxLength = Supplier.CONTACT_NAME_MAX_LENGTH;
        this.ctcFirstNameValue.MaxLength = Supplier.CONTACT_NAME_MAX_LENGTH;
        this.ctcEmailValue.MaxLength = Supplier.CONTACT_EMAIL_MAX_LENGTH;
        this.ctcPhoneValue.MaxLength = Supplier.CONTACT_PHONE_MAX_LENGTH;
    }

    /// <summary>
    /// Open the view in creation mode
    /// </summary>
    /// <param name="newSupplier">The new supplier that will be added</param>
    /// <returns>the view or abort if error</returns>
    public DialogResult OpenForCreation(Supplier newSupplier) {
        try {
            this.currentAction = ViewActionEnum.Create;
            this.LoadSupplierData(newSupplier);
            this.actionBtn.Text = "Create";
            this.idValue.Enabled = false;
            this.supplierNameValue.Enabled = true;
            this.ctcLastNameValue.Enabled = true;
            this.ctcFirstNameValue.Enabled = true;
            this.ctcEmailValue.Enabled = true;
            this.ctcPhoneValue.Enabled = true;
            this.productsValue.Enabled = true;
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Open the view in view mode
    /// </summary>
    /// <param name="supplier">the supplier to view</param>
    /// <returns>the view or abort if error</returns>
    public DialogResult OpenForView(Supplier supplier) {
        try {
            this.Initialize();
            this.currentAction = ViewActionEnum.View;
            this.LoadSupplierData(supplier);
            this.actionBtn.Text = "OK";
            this.idValue.Enabled = false;
            this.supplierNameValue.Enabled = false;
            this.ctcLastNameValue.Enabled = false;
            this.ctcFirstNameValue.Enabled = false;
            this.ctcEmailValue.Enabled = false;
            this.ctcPhoneValue.Enabled = false;
            this.productsValue.Enabled = false;
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Open the view in modification mode
    /// </summary>
    /// <param name="supplier">The supplier that will be modified</param>
    /// <returns>the view or abort if error</returns>
    public DialogResult OpenForModification(Supplier supplier) {
        try {
            this.Initialize();
            this.currentAction = ViewActionEnum.Update;
            this.LoadSupplierData(supplier);
            this.actionBtn.Text = "Save";
            this.idValue.Enabled = false;
            this.supplierNameValue.Enabled = true;
            this.ctcLastNameValue.Enabled = true;
            this.ctcFirstNameValue.Enabled = true;
            this.ctcEmailValue.Enabled = true;
            this.ctcPhoneValue.Enabled = true;
            this.productsValue.Enabled = true;
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Open the view in deletion mode
    /// </summary>
    /// <param name="supplier">the supplier to delete</param>
    /// <returns>the view or abort if error</returns>
    public DialogResult OpenForDeletion(Supplier supplier) {
        try {
            this.Initialize();
            this.currentAction = ViewActionEnum.Delete;
            this.LoadSupplierData(supplier);
            this.actionBtn.Text = "Confirm";
            this.idValue.Enabled = false;
            this.supplierNameValue.Enabled = false;
            this.ctcLastNameValue.Enabled = false;
            this.ctcFirstNameValue.Enabled = false;
            this.ctcEmailValue.Enabled = false;
            this.ctcPhoneValue.Enabled = false;
            this.productsValue.Enabled = false;

            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Initialize les données des boxLists
    /// </summary>
    private void Initialize() {
        if (!this.isInitialize) {
            List<Product> products = this.parentApp.ProductService.GetAllProducts();
            foreach (Product product in products) {
                _ = this.productsValue.Items.Add(product);
            }
        }
        this.isInitialize = true;
    }

    /// <summary>
    /// Load the data from the current instance to the view element
    /// </summary>
    /// <param name="supplier">the supplier to use as a currentInstance</param>
    private void LoadSupplierData(Supplier supplier) {
        this.currentInstance = supplier;

        this.idValue.Value = supplier.SupplierId;
        this.supplierNameValue.Text = supplier.SupplierName;
        this.ctcLastNameValue.Text = supplier.ContactLastName;
        this.ctcFirstNameValue.Text = supplier.ContactFirstName;
        this.ctcEmailValue.Text = supplier.ContactEmail;
        this.ctcPhoneValue.Text = supplier.ContactPhone;

        this.productsValue.SelectedItem = null;
        this.productsValue.SelectedIndex = -1;
        this.productsValue.SelectedItems.Clear();

        foreach (Product product in supplier.Products) {
            this.productsValue.SelectedItems.Add(product);
        }
    }

    private void SupplierView_Load(object sender, EventArgs e) {

    }

    private void cancelBtn_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void actionBtn_Click(object sender, EventArgs e) {
        switch (this.currentAction) {
            case ViewActionEnum.Create:

                this.currentInstance.Products = this.productsValue.SelectedItems.Cast<Product>().ToList();

                this.currentInstance.SupplierId = (int) this.idValue.Value;
                this.currentInstance.SupplierName = this.supplierNameValue.Text;
                this.currentInstance.ContactLastName = this.ctcLastNameValue.Text;
                this.currentInstance.ContactFirstName = this.ctcFirstNameValue.Text;
                this.currentInstance.ContactEmail = this.ctcEmailValue.Text;
                this.currentInstance.ContactPhone = this.ctcPhoneValue.Text;

                _ = this.parentApp.SupplierService.CreateSupplier(this.currentInstance);
                break;
            case ViewActionEnum.Delete:
                this.parentApp.SupplierService.DeleteSupplier(this.currentInstance);

                break;
            case ViewActionEnum.Update:
                this.currentInstance.Products = this.productsValue.SelectedItems.Cast<Product>().ToList();

                this.currentInstance.SupplierId = (int) this.idValue.Value;
                this.currentInstance.SupplierName = this.supplierNameValue.Text;
                this.currentInstance.ContactLastName = this.ctcLastNameValue.Text;
                this.currentInstance.ContactFirstName = this.ctcFirstNameValue.Text;
                this.currentInstance.ContactEmail = this.ctcEmailValue.Text;
                this.currentInstance.ContactPhone = this.ctcPhoneValue.Text;

                _ = this.parentApp.SupplierService.UpdateSupplier(this.currentInstance);
                break;
            case ViewActionEnum.View:
            default:
                break;

        }
        this.DialogResult = DialogResult.OK;
    }
}
