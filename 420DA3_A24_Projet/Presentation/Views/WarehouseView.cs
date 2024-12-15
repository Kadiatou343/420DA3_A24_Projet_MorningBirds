using _420DA3_A24_Projet.Business;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class WarehouseView : Form {

    private readonly WsysApplication parentApp;
    private readonly ViewActionsEnum action;
    private readonly WarehouseView? currentInstance;
    public WarehouseView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.action = ViewActionsEnum.Visualization;
        this.InitializeComponent();
    }
}
