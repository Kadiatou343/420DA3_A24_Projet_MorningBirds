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
/// <summary>
/// Classe représentant la vue de selection de rôle
/// </summary>
internal partial class RoleSelectionWindow : Form {

    /// <summary>
    /// L'application elle-même
    /// </summary>
    private WsysApplication parentApp;

    /// <summary>
    /// Le rôle choisi lors de la connexion d'un utilisateur
    /// </summary>
    public Role SelectedRole { get; private set; } = null!;
    public RoleSelectionWindow(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    /// <summary>
    /// Ouvrir la fenêtre de selection de rôle pour un utilisateur
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public Role OpenRoleSelectionWindowForUser(User user) {
        this.ReloadUserRolesList(user.Roles);
        DialogResult result = this.ShowDialog();
        if (result != DialogResult.OK) {
            throw new Exception("Impossible de compléter le login : aucun role selectionné");
        }
        return this.SelectedRole;

    }

    /// <summary>
    /// Charger une liste de rôles dans la list box
    /// </summary>
    /// <param name="roles"></param>
    private void ReloadUserRolesList(List<Role> roles) {
        this.userRolesListBox.Items.Clear();
        this.userRolesListBox.SelectedItem = null;
        this.userRolesListBox.SelectedIndex = -1;
        foreach (Role role in roles) {
            _ = this.userRolesListBox.Items.Add(role);
        }
    }

    /// <summary>
    /// Activer le bouton de selection à chaque fois qu'un rôle est selectionné
    /// Desactiver le bouton de selection losqu'aucun rôle n'est selectioné
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UserRolesListBox_SelectedIndexChanged(object sender, EventArgs e) {
        Role? selectedRole = this.userRolesListBox.SelectedItem as Role;
        if (selectedRole is null) {
            this.chooseRoleButton.Enabled = false;
        } else {
            this.chooseRoleButton.Enabled = true;
            this.SelectedRole = selectedRole;
        }

    }

    /// <summary>
    /// Terminer le processus de selection de rôle
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ChooseRoleButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.OK;
    }

    /// <summary>
    /// Annuler le processus de selection de rôle
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult= DialogResult.Cancel;
    }
}
