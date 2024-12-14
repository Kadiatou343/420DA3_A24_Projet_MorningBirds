using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
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
internal partial class ShipmentView : Form {

    private readonly WsysApplication parentApp;
    private ViewActionsEnum action;
    private WarehouseView? currentInstance;

    public ShipmentView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        action = ViewActionsEnum.Visualization;
        this.InitializeComponent();
    }

    public DialogResult OpenFor(ViewActionsEnum action, Shipment? shipment = null) {
        DialogResult result = DialogResult.Cancel; //Ce juste temporal
        return result;
    }
}
