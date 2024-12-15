using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.Presentation;

/// <summary>
/// Classe représentant la vue du menu principal d'un employé d'entrepôt
/// </summary>
internal partial class WhEmployeeMainMenu : Form {
    /// <summary>
    /// L'application elle-même
    /// </summary>
    readonly WsysApplication parentApp;

    /// <summary>
    /// L'employé d'entrepôt connecté
    /// </summary>
    private User warehouseEmployeeLoggedIn = null!;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="parentApp">L'application</param>
    public WhEmployeeMainMenu(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
        this.DeactivatteAssignToMeButton();
        this.DeactivateSetPackagedButton();
        this.DeactivateSetReceivedButton();
        this.DeactivateSetShippedButton();
        this.seeDetailsButton.Enabled = false;
    }

    /// <summary>
    /// Remplissage du label de salutation de l'utilisateur connecté et ouverture de la vue en mode modal
    /// </summary>
    /// <returns>Le résultat de l'ouverture de la vue</returns>
    public DialogResult OpenView() {
        this.greetingLabel.Text = "Bonjour " + this.parentApp.LoginService.LoggedInUser?.Username;
        this.warehouseEmployeeLoggedIn = this.parentApp.LoginService.LoggedInUser ?? null!;
        this.LoadUnassignedShippingOrdersInListBox(
            this.parentApp.ShippingOrderServices.GetUnassignedSoForWhEmp(this.warehouseEmployeeLoggedIn));
        this.LoadProcessingShippingOrdersInListBox(
            this.parentApp.ShippingOrderServices.GetFulfilledSoForWhEmp(this.warehouseEmployeeLoggedIn));
        this.LoadPackagedShippingOrdersInListBox(
            this.parentApp.ShippingOrderServices.GetPackagedSoForWhEmp(this.warehouseEmployeeLoggedIn));
        this.LoadExpectedPurchaseOrdersInListBox(
            this.parentApp.PurchaseOrderServices.GetNewPoForWhEmp(this.warehouseEmployeeLoggedIn));
        return this.ShowDialog();
    }

    #region Shipping Order Non Assignés

    /*
     * Note aux autres :
     * La list box "unassignedSoListBox" est seulement faite pour les ordres d'expédition ayant le statut
     * unassigned et dont l'entrepot du client est le même que celui de l'employé d'entrepôt connecté
     */

    /// <summary>
    /// Charger une liste d'ordre d'expéditions non assignés dans la list box fait pour
    /// </summary>
    /// <param name="sos">La liste d'ordre d'expédition à charger</param>
    private void LoadUnassignedShippingOrdersInListBox(List<ShippingOrder> sos) {
        this.unassignedSoListBox.Items.Clear();
        this.unassignedSoListBox.SelectedItem = null;
        this.unassignedSoListBox.SelectedIndex = -1;

        foreach (ShippingOrder so in sos) {
            _ = this.unassignedSoListBox.Items.Add(so);
        }
    }

    /// <summary>
    /// Recharger une liste d'ordre d'expéditions non assignés dans la list box fait pour
    /// </summary>
    private void ReloadUnassignedShippingOrders() {
        this.LoadUnassignedShippingOrdersInListBox(
            this.parentApp.ShippingOrderServices.GetUnassignedSoForWhEmp(this.warehouseEmployeeLoggedIn));
    }

    #endregion

    #region Shipping Order en cour de traitement

    /* 
     * Note aux autres : 
     * La list box "processingSoListBox" est seulement faite pour les ordres d'expéditions ayant le statut
     * processing, et qui sont assignés à l'employé d'entrepôt connecté
     */

    /// <summary>
    /// Charger une liste d'ordre d'expédition en cours de traitement dans la list box fait pour
    /// </summary>
    /// <param name="sos">La liste d'ordre d'expédition à charger</param>
    private void LoadProcessingShippingOrdersInListBox(List<ShippingOrder> sos) {
        this.processingSoListBox.Items.Clear();
        this.processingSoListBox.SelectedItem = null;
        this.processingSoListBox.SelectedIndex = -1;

        foreach (ShippingOrder so in sos) {
            _ = this.processingSoListBox.Items.Add(so);
        }
    }

    /// <summary>
    /// Recharger une liste d'ordre d'expédition en cours de traitement dans la list box fait pour
    /// </summary>
    private void ReloadProcessingShippingOrders() {
        this.LoadProcessingShippingOrdersInListBox(
            this.parentApp.ShippingOrderServices.GetFulfilledSoForWhEmp(this.warehouseEmployeeLoggedIn));
    }

    #endregion

    #region Shipping Order emballés

    /*
     * Note aux autres : 
     * La list box "packagedSoListBox" est seulement faite pour les ordres d'expédition ayant le statut
     * packaged et dont l'entrepot du client est le même que celui de l'employé d'entrepôt connecté
     * 
     */

    /// <summary>
    /// Charger une liste d'ordre d'expédition emballés dans la list box fait pour
    /// </summary>
    /// <param name="sos">dans la list box fait pour</param>
    private void LoadPackagedShippingOrdersInListBox(List<ShippingOrder> sos) {
        this.packagedSoListBox.Items.Clear();
        this.packagedSoListBox.SelectedItem = null;
        this.packagedSoListBox.SelectedIndex = -1;

        foreach (ShippingOrder so in sos) {
            _ = this.packagedSoListBox.Items.Add(so);
        }
    }

    /// <summary>
    /// Recharger une liste d'ordre d'expédition emballés dans la list box fait pour
    /// </summary>
    private void ReloadPackagedShippingOrders() {
        this.LoadPackagedShippingOrdersInListBox(
            this.parentApp.ShippingOrderServices.GetPackagedSoForWhEmp(this.warehouseEmployeeLoggedIn));
    }

    #endregion

    #region Purchase Order Attendus

    /*
     * Note aux autres :
     * La list box "expectedPoListBox" est seulement faite pour les ordres de restockage ayant le statut
     * new et dont l'entrépot de destination est le même que l'employé d'entrepôt connecté 
     */

    /// <summary>
    /// Charger une liste d'ordre de restockage attentus dans la list box fait pour
    /// </summary>
    /// <param name="pos">La liste d'ordre de restockage à charger</param>
    private void LoadExpectedPurchaseOrdersInListBox(List<PurchaseOrder> pos) {
        this.expectedPoListBox.Items.Clear();
        this.expectedPoListBox.SelectedItem = null;
        this.expectedPoListBox.SelectedIndex = -1;

        foreach (PurchaseOrder po in pos) {
            _ = this.expectedPoListBox.Items.Add(po);
        }
    }

    /// <summary>
    /// Recharger une liste d'ordre de restockage attentus dans la list box fait pour
    /// </summary>
    private void ReloadExpectedPurchaseOrders() {
        this.LoadExpectedPurchaseOrdersInListBox(
            this.parentApp.PurchaseOrderServices.GetNewPoForWhEmp(this.warehouseEmployeeLoggedIn));
    }

    #endregion

    #region Activate Deactivate Buttons

    /// <summary>
    /// Activer le bouton d'assignation d'ordre d'expédition
    /// </summary>
    private void ActivateAssignToMeButton() {
        this.assignToMeButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver le bouton d'assignation d'ordre d'expédition
    /// </summary>
    private void DeactivatteAssignToMeButton() {
        this.assignToMeButton.Enabled = false;
    }

    /// <summary>
    /// Activer le bouton de mise en emballage d'un ordre d'expédition
    /// </summary>
    private void ActivateSetPackagedButton() {
        this.setPackagedButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver le bouton de mise en emballage d'un ordre d'expédition
    /// </summary>
    private void DeactivateSetPackagedButton() {
        this.setPackagedButton.Enabled = false;
    }

    /// <summary>
    /// Activer le bouton de mise en expédition d'un ordre d'expédition
    /// </summary>
    private void ActivateSetShippedButton() {
        this.setShippedButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver le bouton de mise en expédition d'un ordre d'expédition
    /// </summary>
    private void DeactivateSetShippedButton() {
        this.setShippedButton.Enabled = false;
    }

    /// <summary>
    /// Activer le bouton de mise en reception d'un ordre de restockage
    /// </summary>
    private void ActivateSetReceivedButton() {
        this.setReceivedButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver le bouton de mise en reception d'un ordre de restockage
    /// </summary>
    private void DeactivateSetReceivedButton() {
        this.setReceivedButton.Enabled = false;
    }

    #endregion

    private void Logout_Click(object sender, EventArgs e) {
        this.parentApp.LoginService.Logout();
        this.DialogResult = DialogResult.Continue;
    }

    private void SoUnassignedRefreshBtn_Click(object sender, EventArgs e) {
        this.ReloadUnassignedShippingOrders();
    }

    private void SoPackagedRefreshBtn_Click(object sender, EventArgs e) {
        this.ReloadPackagedShippingOrders();
    }

    private void PoRefreshBtn_Click(object sender, EventArgs e) {
        this.ReloadExpectedPurchaseOrders();
    }

    private void SoProcessingRefreshBtn_Click(object sender, EventArgs e) {
        this.ReloadProcessingShippingOrders();
    }

    private void UnassignedSoListBox_SelectedIndexChanged(object sender, EventArgs e) {
        ShippingOrder? selectedSo = this.unassignedSoListBox.SelectedItem as ShippingOrder;

        if (selectedSo != null) {
            this.ActivateAssignToMeButton();
        } else {
            this.DeactivatteAssignToMeButton();
        }
    }

    private void ProcessingSoListBox_SelectedIndexChanged(object sender, EventArgs e) {
        ShippingOrder? selectedSo = this.processingSoListBox.SelectedItem as ShippingOrder;

        if (selectedSo != null) {
            this.ActivateSetPackagedButton();
            this.seeDetailsButton.Enabled = true;
        } else {
            this.seeDetailsButton.Enabled = false;
            this.DeactivateSetPackagedButton();
        }
    }

    private void PackagedSoListBox_SelectedIndexChanged(object sender, EventArgs e) {
        ShippingOrder? selectedSo = this.packagedSoListBox.SelectedItem as ShippingOrder;

        if (selectedSo != null) {
            this.ActivateSetShippedButton();
        } else {
            this.DeactivateSetShippedButton();
        }
    }

    private void ExpectedPoListBox_SelectedIndexChanged(object sender, EventArgs e) {
        
    }

    private void AssignToMeButton_Click(object sender, EventArgs e) {

    }

    private void SeeDetailsButton_Click(object sender, EventArgs e) {

    }

    private void SetPackagedButton_Click(object sender, EventArgs e) {

    }

    private void SetShippedButton_Click(object sender, EventArgs e) {

    }

    private void SetReceivedButton_Click(object sender, EventArgs e) {

    }
}
