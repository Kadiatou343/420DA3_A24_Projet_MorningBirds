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

namespace _420DA3_A24_Projet.Presentation;
internal partial class RoleSelectionWindow : Form {

    private WsysApplication parentApp;
    public Role SelectedRole { get; private set; } = null!;
    public RoleSelectionWindow(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    public Role OpenRoleSelectionWindowForUser(User user) {
        this.ReloadUserRolesList(user.Roles);
        DialogResult result = this.ShowDialog();
        if (result != DialogResult.OK) {
            throw new Exception("Impossible de compléter le login : aucun role selectionné");
        }
        return this.SelectedRole;

    }

    private void ReloadUserRolesList(List<Role> roles) {
        this.userRolesListBox.Items.Clear();
        this.userRolesListBox.SelectedItem = null;
        this.userRolesListBox.SelectedIndex = -1;
        foreach (Role role in roles) {
            _ = this.userRolesListBox.Items.Add(role);
        }
    }

    private void UserRolesListBox_SelectedIndexChanged(object sender, EventArgs e) {
        Role? selectedRole = this.userRolesListBox.SelectedItem as Role;
        if (selectedRole is null) {
            this.chooseRoleButton.Enabled = false;
        } else {
            this.chooseRoleButton.Enabled = true;
            this.SelectedRole = selectedRole;
        }

    }

    private void ChooseRoleButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.OK;
    }

    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult= DialogResult.Cancel;
    }
}
