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

namespace _420DA3_A24_Projet.Presentation.Views;

public enum ViewAEnum {
    View,
    Create,
    Update,
    Delete
}
internal partial class ShippingOrderView : Form {


    private readonly WsysApplication parentApp;
    private ViewAEnum currentAction;
    private ShippingOrder currentInstance = null!;
    private bool isInitialize = false; // Si les données ont été initialisées
    public ShippingOrderView() {
        InitializeComponent();
    }
    /// <param name="newShippingOrder">The new product that will be added</param>
    /// <returns>the view or abort if error</returns>
    public DialogResult OpenForCreation(ShippingOrder newShippingOrder) {
        try {
            this.currentAction = ViewAEnum.Create;
            this.LoadShippingOrderData(newShippingOrder);
            this.btnAction.Text = "Create";
            this.idValue.Enabled = false;
            this.EmployeValue.Enabled = true;
            this.ClientValue.Enabled = true;
            this.shipmentValue.Enabled = true;
            this.userValue.Enabled = true;
            this.AdressValue.Enabled = true;
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    private void LoadShippingOrderData(ShippingOrder shippingOrder) {
        this.currentInstance = shippingOrder;

        this.idValue.Value = shippingOrder.Id;

        this.EmployeValue.SelectedItem = null;
        this.EmployeValue.SelectedIndex = -1;
        this.EmployeValue.SelectedItems.Clear();

        this.ClientValue.SelectedItem = null;
        this.ClientValue.SelectedIndex = -1;
        this.ClientValue.SelectedItems.Clear();

        this.shipmentValue.SelectedItem = null;
        this.shipmentValue.SelectedIndex = -1;
        this.shipmentValue.SelectedItems.Clear();

        this.userValue.SelectedItem = null;
        this.userValue.SelectedIndex = -1;
        this.userValue.SelectedItems.Clear();

        this.AdressValue.SelectedItem = null;
        this.AdressValue.SelectedIndex = -1;
        this.AdressValue.SelectedItems.Clear();

        List<Client> clients = this.parentApp.ClientService.GetAllClient();
        foreach (Client client in clients) {
            if (client.Id == shippingOrder.Id) {
                this.ClientValue.SelectedItems.Add(client);
            }
        }


        List<Shipment> shipments = this.parentApp.ShipmentService.GetAllShipment();
        foreach (Shipment shipment in shipments) {
            if (shipment.Id == shippingOrder.shipmentId) {
                this.shipmentValue.SelectedItems.Add(shipment);
            }
        }

        List<Address> adresses = this.parentApp.AdresseService.GetAllAddress();
        foreach (Address adresse in adresses) {
            if (adresse.Id == shippingOrder.DestinationAdressId) {
                this.AdressValue.SelectedItems.Add(adresse);
            }
        }

        List<User> users = this.parentApp.UserService.GetAllUsers();
        foreach (User user in users) {
            if (user.Id == shippingOrder.SourceClientId) {
                this.userValue.SelectedItems.Add(user);
            }
        }

        List<User> employes = this.parentApp.UserService.GetAllUsers();
        foreach (User employe in employes) {
            if (employe.Id == shippingOrder.CreatorEmployeeId) {
                this.userValue.SelectedItems.Add(employe);
            }
        }
    }

    public DialogResult OpenForDeletion(ShippingOrder shippingOrder) {
        try {
            this.Initialize();
            this.currentAction = ViewAEnum.Delete;
            this.LoadShippingOrderData(shippingOrder);
            this.btnAction.Text = "Confirm";
            this.idValue.Enabled = false;
            this.EmployeValue.Enabled = false;
            this.ClientValue.Enabled = false;
            this.shipmentValue.Enabled = false;
            this.userValue.Enabled = false;
            this.AdressValue.Enabled = false;

            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    public DialogResult OpenForModification(ShippingOrder shippingOrder) {
        try {
            this.Initialize();
            this.currentAction = ViewAEnum.Update;
            this.LoadShippingOrderData(shippingOrder);
            this.btnAction.Text = "Save";
            this.idValue.Enabled = false;
            this.EmployeValue.Enabled = true;
            this.ClientValue.Enabled = true;
            this.shipmentValue.Enabled = true;
            this.userValue.Enabled = true;
            this.AdressValue.Enabled = true;
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    public DialogResult OpenForView(ShippingOrder shippingOrder) {
        try {
            this.Initialize();
            this.currentAction = ViewAEnum.View;
            this.LoadShippingOrderData(shippingOrder);
            this.btnAction.Text = "OK";
            this.idValue.Enabled = false;
            this.EmployeValue.Enabled = false;
            this.ClientValue.Enabled = false;
            this.shipmentValue.Enabled = false;
            this.userValue.Enabled = false;
            this.AdressValue.Enabled = false;
            return this.ShowDialog();
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }
    }

    public void ShippingOrderView_Load(object sender, EventArgs e) {

    }

    private void label9_Click(object sender, EventArgs e) {

    }

    private void label10_Click(object sender, EventArgs e) {

    }

    private void label9_Click_1(object sender, EventArgs e) {

    }

    private void btnAction_Click(object sender, EventArgs e) {
        switch (this.currentAction) {
            case ViewAEnum.Create:

                this.currentInstance.SourceClient = (Client) this.ClientValue.SelectedItems.Cast<Client>();
                this.currentInstance.Shipment = (Shipment) this.shipmentValue.SelectedItems.Cast<Shipment>();
                this.currentInstance.DestinationAddress = (Address) this.AdressValue.SelectedItems.Cast<Address>();
                this.currentInstance.FulfillerEmployee = (User) this.shipmentValue.SelectedItems.Cast<User>();
                this.currentInstance.CreatorEmployee = (User) this.userValue.SelectedItems.Cast<User>();
                this.currentInstance.Id = (int) this.idValue.Value;

                _ = this.parentApp.ShippingOrderServices.CreateShippingOrder(this.currentInstance);
                break;
            case ViewAEnum.Delete:
                this.parentApp.ShippingOrderServices.DeleteShippingOrder(this.currentInstance);

                break;
            case ViewAEnum.Update:

                this.currentInstance.SourceClient = (Client) this.ClientValue.SelectedItems.Cast<Client>();
                this.currentInstance.Shipment = (Shipment) this.shipmentValue.SelectedItems.Cast<Shipment>();
                this.currentInstance.DestinationAddress = (Address) this.AdressValue.SelectedItems.Cast<Address>();
                this.currentInstance.FulfillerEmployee = (User) this.shipmentValue.SelectedItems.Cast<User>();
                this.currentInstance.CreatorEmployee = (User) this.userValue.SelectedItems.Cast<User>();
                this.currentInstance.Id = (int) this.idValue.Value;

                _ = this.parentApp.ShippingOrderServices.UpdateShippingOrder(this.currentInstance);
                break;
            case ViewAEnum.View:
            default:
                break;

        }
        this.DialogResult = DialogResult.OK;

    }
    private void Initialize() {
        if (!this.isInitialize) {
            List<Client> clients = this.parentApp.ClientService.GetAllClient();
            foreach (Client client in clients) {
                _ = this.ClientValue.Items.Add(client);
            }

          
            List<Shipment> shipments = this.parentApp.ShipmentService.GetAllShipment();
            foreach (Shipment shipment in shipments) {
                _ = this.shipmentValue.Items.Add(shipment);
            }

            List<Address> adresses = this.parentApp.AdresseService.GetAllAddress();
            foreach (Address adresse in adresses) {
                _ = this.shipmentValue.Items.Add(adresse);
            }

            List<User> users = this.parentApp.UserService.GetAllUsers();
            foreach (User user in users) {
                _ = this.shipmentValue.Items.Add(user);
            }
        }
        this.isInitialize = true;
    }
    private void btnCancel_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}


