using _420DA3_A24_Projet.Business;
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
internal partial class WarehouseView : Form {

    private readonly WsysApplication parentApp;
    private ViewActionsEnum action;
    private WarehouseView? currentInstance;
    public WarehouseView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        action = ViewActionsEnum.Visualization;
        this.InitializeComponent();
    }
}
