using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class ClientView : Form {

    private readonly WsysApplication parentApp;
    private bool isInitialize = false;
    private readonly Client currentInstance = null!;
    private ViewActionsEnum currentAction;
    public ClientView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
        this.textboxnomclient.MaxLength = Client.ClientNameMaxLength;
        this.textboxcontactFN.MaxLength = Client.ContactFirstNameMaxLength;
        this.textBoxcontactLN.MaxLength = Client.ContactLastNameMaxLength;
        this.textBoxemail.MaxLength = Client.ContactEmailMaxLength;
        this.textBoxtel.MaxLength = Client.ContactEmailMaxLength;

    }

    public DialogResult OpenForCreation(Client client) {

        try {

            this.currentAction = ViewActionsEnum.Creation;
            this.btnaction.Text = "Create";
            this.textboxnomclient.Enabled = true;
            this.textboxcontactFN.Enabled = true;
            this.textBoxcontactLN.Enabled = true;
            this.textBoxemail.Enabled = true;
            this.textBoxtel.Enabled = true;
            return this.ShowDialog();

        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }

    }


    public DialogResult OpenForUpdate(Client client) {

        try {

            this.currentAction = ViewActionsEnum.Edition;
            this.btnaction.Text = "Edit";
            this.textboxnomclient.Enabled = true;
            this.textboxcontactFN.Enabled = true;
            this.textBoxcontactLN.Enabled = true;
            this.textBoxemail.Enabled = true;
            this.textBoxtel.Enabled = true;
            return this.ShowDialog();

        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }

    }


    public DialogResult OpenForDelete(Client client) {

        try {

            this.currentAction = ViewActionsEnum.Deletion;
            this.btnaction.Text = "Delete";
            this.textboxnomclient.Enabled = false;
            this.textboxcontactFN.Enabled = false;
            this.textBoxcontactLN.Enabled = false;
            this.textBoxemail.Enabled = false;
            this.textBoxtel.Enabled = false;
            return this.ShowDialog();

        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }

    }

    public DialogResult OpenForSearch(Client client) {

        try {

            this.currentAction = ViewActionsEnum.Visualization;
            this.btnaction.Text = "Delete";
            this.textboxnomclient.Enabled = false;
            this.textboxcontactFN.Enabled = false;
            this.textBoxcontactLN.Enabled = false;
            this.textBoxemail.Enabled = false;
            this.textBoxtel.Enabled = false;
            return this.ShowDialog();

        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.Abort;
        }

    }

    private void ReloadEmployeeWaherouseList(List<Warehouse> warehouses) {
        this.ListClient.Items.Clear();
        this.ListClient.SelectedItem = null;
        this.ListClient.SelectedIndex = -1;

        foreach (Warehouse warehouse in warehouses) {
            _ = this.ListClient.Items.Add(warehouse);
        }
    }

    private void Initialize() {

        this.isInitialize = true;
    }

    private void btnaction_Click(object sender, EventArgs e) {

    }

    private void btncancel_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}

