using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class ShipmentView : Form {

    private readonly WsysApplication parentApp;
    private readonly ViewActionsEnum action;
    private readonly WarehouseView? currentInstance;

    public ShipmentView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.action = ViewActionsEnum.Visualization;
        this.InitializeComponent();
    }

    public DialogResult OpenFor(ViewActionsEnum action, Shipment? shipment = null) {
        DialogResult result = DialogResult.Cancel; //Ce juste temporal
        return result;
    }
}
