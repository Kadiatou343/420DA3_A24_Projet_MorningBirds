using _420DA3_A24_Projet.Business;
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
public partial class RoleView : Form {

    private readonly WsysApplication parentApp;
    public RoleView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    private void RoleView_Load(object sender, EventArgs e) {

    }
}
