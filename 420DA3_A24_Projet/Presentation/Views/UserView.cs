﻿using _420DA3_A24_Projet.Business;
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
internal partial class UserView : Form {
    private readonly WsysApplication parentApp;
    public UserView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    private void UserView_Load(object sender, EventArgs e) {

    }
}
