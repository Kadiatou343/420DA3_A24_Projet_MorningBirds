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

namespace _420DA3_A24_Projet.Presentation;
internal partial class AdminMainMenu : Form {
    private WsysApplication parentApp;
    public AdminMainMenu(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    private void LogoutButtton_Click(object sender, EventArgs e) {
        this.parentApp.LoginService.Logout();
        this.DialogResult = DialogResult.Continue;
    }

    #region Gestion des utilisateurs

    private void SearchTextBox_TextChanged(object sender, EventArgs e) {

    }

    private void UserListBox_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void SeeUserDetailsButton_Click(object sender, EventArgs e) {

    }

    private void UpdateUserButton_Click(object sender, EventArgs e) {

    }

    private void DeleteUserButton_Click(object sender, EventArgs e) {

    }

    private void CreateUserButton_Click(object sender, EventArgs e) {

    }

    #endregion
}
