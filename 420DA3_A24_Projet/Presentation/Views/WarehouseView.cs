using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs;
using Project_Utilities.Enums;
using System.Diagnostics.Tracing;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class WarehouseView : Form {

    private readonly WsysApplication parentApp;
    private ViewActionsEnum action;
    private Warehouse? currentInstance;
    private bool isInitialize = false;
    private bool hasAddress = false;
    
    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="parentApp">L'application</param>
    public WarehouseView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.action = ViewActionsEnum.Visualization;
        this.InitializeComponent();
        this.nameValue.MaxLength = Warehouse.WAREHOUSE_NAME_MAX_LENGTH;
    }

    /// <summary>
    /// Ouvrir la fenêtre en mode création
    /// </summary>
    /// <param name="warehouse">Le nouveaux warehouse à ajouter</param>
    /// <returns>The view</returns>
    public DialogResult OpenForCreaton(Warehouse warehouse) {
        try {
            this.action = ViewActionsEnum.Creation;
            this.LoadWarehouseData(warehouse);
            this.actionBtn.Text = "Create";
            this.idValue.Enabled = false;
            this.nameValue.Enabled = true;
            this.addresseIdValue.Enabled = true;
            this.codePostalValue.Enabled = true;
            this.HasAddress();
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Ouvrir la fenêtre en mode modification
    /// </summary>
    /// <param name="warehouse">Le warehouse à modifier</param>
    /// <returns>The view</returns>
    public DialogResult OpenForModification(Warehouse warehouse) {
        try {
            this.Initialize();
            this.action = ViewActionsEnum.Edition;
            this.LoadWarehouseData(warehouse);
            this.actionBtn.Text = "Save";
            this.idValue.Enabled = false;
            this.nameValue.Enabled = true;
            this.addresseIdValue.Enabled = true;
            this.codePostalValue.Enabled = true;
            this.HasAddress();
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Ouvrir la fenêtre en mode visualization
    /// </summary>
    /// <param name="warehouse">Le  warehouse à visualiser</param>
    /// <returns>The view</returns>
    public DialogResult OpenForView(Warehouse warehouse) {
        try {
            this.Initialize();
            this.action = ViewActionsEnum.Visualization;
            this.LoadWarehouseData(warehouse);
            this.actionBtn.Text = "Ok";
            this.idValue.Enabled = false;
            this.nameValue.Enabled = false;
            this.addresseIdValue.Enabled = false;
            this.codePostalValue.Enabled = false;
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Ouvrir la fenêtre en mode deletion
    /// </summary>
    /// <param name="warehouse">Le warehouse à supprimer</param>
    /// <returns>The view</returns>
    public DialogResult OpenForDelete(Warehouse warehouse) {
        try {
            this.Initialize();
            this.action = ViewActionsEnum.Deletion;
            this.LoadWarehouseData(warehouse);
            this.actionBtn.Text = "Confirm";
            this.idValue.Enabled = false;
            this.nameValue.Enabled = false;
            this.addresseIdValue.Enabled = false;
            this.codePostalValue.Enabled = false;
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Initialize les données des employeesBoxList
    /// </summary>
    private void Initialize() {
        if (!this.isInitialize) {
            List<User> users = this.parentApp.UserService.GetAllUsers();
            foreach (User user in users) {
                _ = this.employesValue.Items.Add(user);
            }
        }
    }

    /// <summary>
    /// Methode pour verifier si le warehouse a une addresse assigné
    /// </summary>
    private void HasAddress() {
        if (this.codePostalValue.Text == null && hasAddress == false) {
            _ = MessageBox.Show("Please assign an address for the warehouse");
        }
    }

    /// <summary>
    /// Charger les données du current instance
    /// </summary>
    /// <param name="warehouse">Le objet à utiliser comme curent instance</param>
    private void LoadWarehouseData(Warehouse warehouse) {
        this.currentInstance = warehouse;

        this.idValue.Value = warehouse.Id;
        this.nameValue.Text = warehouse.WareHouseName;
        this.addresseIdValue.Text = warehouse.AddressId.ToString();
        this.codePostalValue.Text = warehouse.Adresse.PostalCode;
        this.dateCreationPicker.Value = warehouse.DateCreated;
        this.dateModificationPicker.Value = warehouse.DateModified ?? DateTime.Now;

        this.employesValue.SelectedItem = null;
        this.employesValue.SelectedIndex = -1;
        this.employesValue.SelectedItems.Clear();
        List<User> users = this.parentApp.UserService.GetAllUsers();
        foreach (User user in users) {
            if (user.EmployeeWarehouse != null && user.EmployeeWarehouse.Id == warehouse.Id) {
                _ = this.employesValue.Items.Add(user);
            }
        }
    }

    /// <summary>
    /// Botton pour acceder au menu de création d'un objet tyoe Address
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void creationAdressBtn_Click(object sender, EventArgs e) {
        //Pas de methodes OpenAddressViewForCreation() dans la class AddresseService pour le moment
        Address? addresse = null;// this.parentApp.AdresseService.OpenAddressViewForCreation();
        try {
            if (addresse != null) {
                this.addresseIdValue.Text = addresse.Id.ToString();
                this.codePostalValue.Text = addresse.PostalCode;
                this.hasAddress = true;
            }
        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    /// <summary>
    /// Executer l'action
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void actionBtn_Click(object sender, EventArgs e) {
        switch (action) {
            case ViewActionsEnum.Creation:
                this.currentInstance.WareHouseName = this.nameValue.Text;
                this.currentInstance.AddressId = int.Parse(addresseIdValue.Text);
                _ = this.parentApp.WarehouseService.CreateWarehouse(this.currentInstance);
                break;
            case ViewActionsEnum.Edition:
                this.currentInstance.WareHouseName = this.nameValue.Text;
                this.currentInstance.AddressId = int.Parse(addresseIdValue.Text);
                _ = this.parentApp.WarehouseService.UpdateWarehouse(this.currentInstance);
                break;
            case ViewActionsEnum.Deletion:
                this.parentApp.WarehouseService.DeleteWarehouse(this.currentInstance);
                break;
            case ViewActionsEnum.Visualization:
            default:
                break;
        }
    }

    /// <summary>
    /// Cancel la view
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void cancelBtn_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
