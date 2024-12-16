using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Services;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class ShipmentView : Form {

    private readonly WsysApplication parentApp;
    private ViewActionsEnum action;
    private Shipment? currentInstance;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="parentApp">L'application</param>
    public ShipmentView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.action = ViewActionsEnum.Visualization;
        this.InitializeComponent();
        this.trackingNumberValue.MaxLength = Shipment.TRACKING_NUMBER_MAX_LENGTH;
    }

    /// <summary>
    /// Ouvrir la fenêtre en mode création
    /// </summary>
    /// <param name="shipment">Le nouveaux shipment à ajouter</param>
    /// <returns>The view</returns>
    public DialogResult OpenForCreation(Shipment shipment) {
        try {
            this.action = ViewActionsEnum.Creation;
            this.LoadShipmentData(shipment);
            this.actionBtn.Text = "Create";
            this.idValue.Enabled = false;
            this.statusValue.Enabled = true;
            this.shippingServiceValue.Enabled = true;
            this.trackingNumberValue.Enabled = true;
            this.shippingOrderIdLabel.Enabled = true;

            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Ouvrir la fenêtre en mode modification
    /// </summary>
    /// <param name="shipment">Le shipment à modifier</param>
    /// <returns>The view</returns>
    public DialogResult OpenForModification(Shipment shipment) {
        try {
            this.action = ViewActionsEnum.Edition;
            this.LoadShipmentData(shipment);
            this.actionBtn.Text = "Save";
            this.idValue.Enabled = false;
            this.statusValue.Enabled = true;
            this.shippingServiceValue.Enabled = true;
            this.trackingNumberValue.Enabled = true;
            this.shippingOrderIdLabel.Enabled = true;

            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Ouvrir la fenêtre en mode visualization
    /// </summary>
    /// <param name="shipment">Le  shipment à visualiser</param>
    /// <returns>The view</returns>
    public DialogResult OpenForView(Shipment shipment) {
        try {
            this.action = ViewActionsEnum.Visualization;
            this.LoadShipmentData(shipment);
            this.actionBtn.Text = "Ok";
            this.idValue.Enabled = false;
            this.statusValue.Enabled = false;
            this.shippingServiceValue.Enabled = false;
            this.trackingNumberValue.Enabled = false;
            this.shippingOrderIdLabel.Enabled = false;

            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Ouvrir la fenêtre en mode deletion
    /// </summary>
    /// <param name="shipment">Le shipment à supprimer</param>
    /// <returns>The view</returns>
    public DialogResult OpenForDelete(Shipment shipment) {
        try {
            this.action = ViewActionsEnum.Deletion;
            this.LoadShipmentData(shipment);
            this.actionBtn.Text = "Confirm";
            this.idValue.Enabled = false;
            this.statusValue.Enabled = false;
            this.shippingServiceValue.Enabled = false;
            this.trackingNumberValue.Enabled = false;
            this.shippingOrderIdLabel.Enabled = false;

            return this.ShowDialog();

        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    /// <summary>
    /// Charger les données du current instance
    /// </summary>
    /// <param name="shipment">Le objet à utiliser comme curent instance</param>
    private void LoadShipmentData(Shipment shipment) {
        this.currentInstance = shipment;

        this.idValue.Value = shipment.Id;
        this.statusValue.SelectedItem = shipment.Status;
        this.shippingServiceValue.SelectedItem = shipment.ShippingService;
        this.trackingNumberValue.Text = shipment.TrackingNumber;
        this.shippinOrderIdValue.Text = shipment.ShippingOrderId.ToString();

        this.dateCreationPicker.Value = shipment.DateCreated;
        this.dateModificationPicker.Value = shipment.DateModified ?? DateTime.Now;
    }

    /// <summary>
    /// Executer l'action
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void actionBtn_Click(object sender, EventArgs e) {
        switch (action) {
            case ViewActionsEnum.Creation:
                this.currentInstance.Status = Enum.Parse<ShipmentStatusEnum>(this.statusValue.SelectedItem.ToString());
                this.currentInstance.ShippingService = Enum.Parse<ShippingProvidersEnum>(shippingServiceValue.SelectedItem.ToString());
                this.currentInstance.TrackingNumber = this.trackingNumberValue.Text;
                this.currentInstance.ShippingOrderId = int.Parse(this.shippingOrderIdLabel.Text);
                _ = this.parentApp.ShipmentService.CreateShipment(this.currentInstance);
                break;
            case ViewActionsEnum.Edition:
                this.currentInstance.Status = Enum.Parse<ShipmentStatusEnum>(this.statusValue.SelectedItem.ToString());
                this.currentInstance.ShippingService = Enum.Parse<ShippingProvidersEnum>(this.shippingServiceValue.SelectedItem.ToString());
                this.currentInstance.TrackingNumber = this.trackingNumberValue.Text;
                this.currentInstance.ShippingOrderId = int.Parse(this.shippingOrderIdLabel.Text);
                _ = this.parentApp.ShipmentService.UpdateShipment(this.currentInstance);
                break;
            case ViewActionsEnum.Deletion:
                this.parentApp.ShipmentService.DeleteShipment(this.currentInstance);
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
