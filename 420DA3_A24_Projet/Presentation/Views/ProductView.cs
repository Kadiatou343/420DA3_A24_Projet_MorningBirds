using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using System.Data;

namespace _420DA3_A24_Projet.Presentation.Views;

internal partial class ProductView : Form {

    private readonly WsysApplication parentApp;
    private ViewActionEnum currentAction;
    private Product currentInstance = null!;
    private bool isInitialize = false; // Si les données ont été initialisées

    public ProductView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
        this.nameValue.MaxLength = Product.PRODUCT_NAME_MAX_LENGTH;
        this.descValue.MaxLength = Product.DESC_MAX_LENGTH;
        this.codeUpcValue.MaxLength = Product.CODE_UPC_MAX_LENGTH;
        this.pictureNameValue.MaxLength = Product.PICTURE_NAME_MAX_LENGTH;
        this.supplierCodeValue.MaxLength = Product.SUPPLIER_CODE_MAX_LENGTH;
    }

    /// <summary>
    /// Open the view in creation mode
    /// </summary>
    /// <param name="newProduct">The new product that will be added</param>
    /// <returns>the view or abort if error</returns>
    public DialogResult OpenForCreation(Product newProduct) {
        try {
            this.currentAction = ViewActionEnum.Create;
            this.LoadProductData(newProduct);
            this.btnAction.Text = "Create";
            this.idValue.Enabled = false;
            this.nameValue.Enabled = true;
            this.descValue.Enabled = true;
            this.codeUpcValue.Enabled = true;
            this.supplierIdValue.Enabled = true;
            this.clientIdValue.Enabled = true;
            this.supplierCodeValue.Enabled = true;
            this.quantityValue.Enabled = true;
            this.aimQuantityValue.Enabled = true;
            this.weightValue.Enabled = true;
            this.pictureNameValue.Enabled = true;
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Open the view in view mode
    /// </summary>
    /// <param name="product">the product to view</param>
    /// <returns>the view or abort if error</returns>
    public DialogResult OpenForView(Product product) {
        try {
            this.Initialize();
            this.currentAction = ViewActionEnum.View;
            this.LoadProductData(product);
            this.btnAction.Text = "OK";
            this.idValue.Enabled = false;
            this.nameValue.Enabled = false;
            this.descValue.Enabled = false;
            this.codeUpcValue.Enabled = false;
            this.supplierIdValue.Enabled = false;
            this.clientIdValue.Enabled = false;
            this.supplierCodeValue.Enabled = false;
            this.quantityValue.Enabled = false;
            this.aimQuantityValue.Enabled = false;
            this.weightValue.Enabled = false;
            this.pictureNameValue.Enabled = false;
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Open the view in modification mode
    /// </summary>
    /// <param name="product">The product that will be modified</param>
    /// <returns>the view or abort if error</returns>
    public DialogResult OpenForModification(Product product) {
        try {
            this.Initialize();
            this.currentAction = ViewActionEnum.Update;
            this.LoadProductData(product);
            this.btnAction.Text = "Save";
            this.idValue.Enabled = false;
            this.nameValue.Enabled = true;
            this.descValue.Enabled = true;
            this.codeUpcValue.Enabled = true;
            this.supplierIdValue.Enabled = true;
            this.clientIdValue.Enabled = true;
            this.supplierCodeValue.Enabled = true;
            this.quantityValue.Enabled = true;
            this.aimQuantityValue.Enabled = true;
            this.weightValue.Enabled = true;
            this.pictureNameValue.Enabled = true;
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Open the view in deletion mode
    /// </summary>
    /// <param name="product">the product to delete</param>
    /// <returns>the view or abort if error</returns>
    public DialogResult OpenForDeletion(Product product) {
        try {
            this.Initialize();
            this.currentAction = ViewActionEnum.Delete;
            this.LoadProductData(product);
            this.btnAction.Text = "Confirm";
            this.idValue.Enabled = false;
            this.nameValue.Enabled = false;
            this.descValue.Enabled = false;
            this.codeUpcValue.Enabled = false;
            this.supplierIdValue.Enabled = false;
            this.clientIdValue.Enabled = false;
            this.supplierCodeValue.Enabled = false;
            this.quantityValue.Enabled = false;
            this.aimQuantityValue.Enabled = false;
            this.weightValue.Enabled = false;
            this.pictureNameValue.Enabled = false;
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
            List<Supplier> suppliers = this.parentApp.SupplierService.GetAllSupplier();
            foreach (Supplier supplier in suppliers) {
                _ = this.supplierIdValue.Items.Add(supplier);
            }

            // le ClientService ne compose pas de function GetAll Pour l'instant.
            List<Client> clients = this.parentApp.ClientService.GetAllClients();
            foreach (Client client in clients) {
                _ = this.clientIdValue.Items.Add(client);
            }
        }
        this.isInitialize = true;
    }

    /// <summary>
    /// Load the data from the current instance to the view element
    /// </summary>
    /// <param name="product">the product to use as a currentInstance</param>
    private void LoadProductData(Product product) {
        this.currentInstance = product;

        this.idValue.Value = product.ProductId;
        this.nameValue.Text = product.ProductName;
        this.descValue.Text = product.Desc;
        this.codeUpcValue.Text = product.CodeUPC;
        this.supplierCodeValue.Text = product.SupplierCode;
        this.quantityValue.Value = product.Quantity;
        this.aimQuantityValue.Value = product.AimQuantity;
        this.weightValue.Value = (decimal) product.Weight;
        this.pictureNameValue.Text = product.PictureName;

        this.supplierIdValue.SelectedItem = null;
        this.supplierIdValue.SelectedIndex = -1;
        this.supplierIdValue.SelectedItems.Clear();

        List<Supplier> suppliers = this.parentApp.SupplierService.GetAllSupplier();
        foreach (Supplier supplier in suppliers) {
            if (supplier.SupplierId == product.SupplierId) {
                this.supplierIdValue.SelectedItems.Add(supplier);
            }
        }

        this.clientIdValue.SelectedItem = null;
        this.clientIdValue.SelectedIndex = -1;
        this.clientIdValue.SelectedItems.Clear();
        // le ClientService ne compose pas de function GetAll Pour l'instant.
        List<Client> clients = this.parentApp.ClientService.GetAllClients();
        foreach (Client client in clients) {
            if (client.Id == product.ClientId) {
                this.clientIdValue.SelectedItems.Add(client);
            }
        }
    }

    /// <summary>
    /// Redirige vers les bonnes functions à utiliser lors de l'utilisation du bouton
    /// en fonction de la view afficher.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnAction_Click(object sender, EventArgs e) {
        switch (this.currentAction) {
            case ViewActionEnum.Create:

                this.currentInstance.Supplier = (Supplier) this.supplierIdValue.SelectedItems.Cast<Supplier>();
                this.currentInstance.Client = (Client) this.clientIdValue.SelectedItems.Cast<Client>();

                this.currentInstance.ProductId = (int) this.idValue.Value;
                this.currentInstance.ProductName = this.nameValue.Text;
                this.currentInstance.Desc = this.descValue.Text;
                this.currentInstance.CodeUPC = this.codeUpcValue.Text;
                this.currentInstance.SupplierId = this.currentInstance.Supplier.SupplierId;
                this.currentInstance.ClientId = this.currentInstance.Client.Id;
                this.currentInstance.SupplierCode = this.supplierCodeValue.Text;
                this.currentInstance.Quantity = (int) this.quantityValue.Value;
                this.currentInstance.AimQuantity = (int) this.aimQuantityValue.Value;
                this.currentInstance.Weight = (double) this.weightValue.Value;
                this.currentInstance.PictureName = this.pictureNameValue.Text;

                _ = this.parentApp.ProductService.CreateProduct(this.currentInstance);
                break;
            case ViewActionEnum.Delete:
                this.parentApp.ProductService.DeleteProduct(this.currentInstance);

                break;
            case ViewActionEnum.Update:
                this.currentInstance.Supplier = (Supplier) this.supplierIdValue.SelectedItems.Cast<Supplier>();
                this.currentInstance.Client = (Client) this.clientIdValue.SelectedItems.Cast<Client>();

                this.currentInstance.ProductId = (int) this.idValue.Value;
                this.currentInstance.ProductName = this.nameValue.Text;
                this.currentInstance.Desc = this.descValue.Text;
                this.currentInstance.CodeUPC = this.codeUpcValue.Text;
                this.currentInstance.SupplierId = this.currentInstance.Supplier.SupplierId;
                this.currentInstance.ClientId = this.currentInstance.Client.Id;
                this.currentInstance.SupplierCode = this.supplierCodeValue.Text;
                this.currentInstance.Quantity = (int) this.quantityValue.Value;
                this.currentInstance.AimQuantity = (int) this.aimQuantityValue.Value;
                this.currentInstance.Weight = (double) this.weightValue.Value;
                this.currentInstance.PictureName = this.pictureNameValue.Text;

                _ = this.parentApp.ProductService.UpdateProduct(this.currentInstance);
                break;
            case ViewActionEnum.View:
            default:
                break;

        }
        this.DialogResult = DialogResult.OK;
    }

    /// <summary>
    /// Cancel la view et retourne au menu précédent
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnCancel_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void supplierIdValue_SelectedIndexChanged(object sender, EventArgs e) {
        // ignorer
    }

    private void clientIdValue_SelectedIndexChanged(object sender, EventArgs e) {
        // ignorer
    }
}
