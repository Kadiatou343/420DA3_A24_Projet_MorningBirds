using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation;
internal partial class AdminMainMenu : Form {
    /// <summary>
    /// L'application elle-même
    /// </summary>
    private readonly WsysApplication parentApp;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="parentApp">L'application</param>
    public AdminMainMenu(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
        this.greetingLabel.Text = "Bonjour " + (this.parentApp.LoginService.LoggedInUser)?.Username;
    }


    /// <summary>
    /// Deconnexion de l'utilisateur courant
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LogoutButtton_Click(object sender, EventArgs e) {
        this.parentApp.LoginService.Logout();
        this.DialogResult = DialogResult.Continue;
    }

    #region Gestion des utilisateurs

    /// <summary>
    /// Charger une liste d'utilisateurs dans la list box des utilisateurs
    /// </summary>
    /// <param name="users">La liste d'utilisateurs</param>
    private void LoadUsersInListBox(List<User> users) {
        this.userListBox.Items.Clear();
        this.userListBox.SelectedItem = null;
        this.userListBox.SelectedIndex = -1;

        foreach (User user in users) {
            _ = this.userListBox.Items.Add(user);
        }
    }

    /// <summary>
    /// Activer les boutons d'action pour les utilisateurs
    /// </summary>
    private void ActivateUserActionButtons() {
        this.seeUserDetailsButton.Enabled = true;
        this.updateUserButton.Enabled = true;
        this.deleteUserButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver les boutons d'action pour les utilisateurs
    /// </summary>
    private void DeactivateUserActionButtons() {
        this.seeUserDetailsButton.Enabled = false;
        this.updateUserButton.Enabled = false;
        this.deleteUserButton.Enabled = false;
    }

    /// <summary>
    /// Activer les boutons d'action utilisateurs à chaque fois l'utilisateur selectionné change dans la list box
    /// Desactiver les boutons d'action utilisateurs lorsqu'aucun utilisateur n'est selectionné
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UserListBox_SelectedIndexChanged(object sender, EventArgs e) {
        User? selectedUser = this.userListBox.SelectedItem as User;
        if (selectedUser is not null) {
            this.ActivateUserActionButtons();
        } else {
            this.DeactivateUserActionButtons();
        }
    }

    /// <summary>
    /// Déclencher le processsus de visualisation d'un utilisateur
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SeeUserDetailsButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.UserService.OpenViewFor(ViewActionsEnum.Visualization,
             this.userListBox.SelectedItem as User);
    }

    /// <summary>
    /// Déclencher le processsus de mise à jour d'un utilisateur
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UpdateUserButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.UserService.OpenViewFor(ViewActionsEnum.Edition,
             this.userListBox.SelectedItem as User);

        this.userListBox.Refresh();
    }

    /// <summary>
    /// Déclencher le processsus de suppression  d'un utilisateur
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DeleteUserButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.UserService.OpenViewFor(ViewActionsEnum.Deletion,
            this.userListBox.SelectedItem as User);

        this.userListBox.Refresh();
    }

    /// <summary>
    /// Déclencher le processsus de création d'un utilisateur
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateUserButton_Click(object sender, EventArgs e) {
        User? createdUser = this.parentApp.UserService.OpenViewFor(ViewActionsEnum.Creation);

        if (createdUser is not null) {
            _ = this.userListBox.Items.Add(createdUser);
            this.userListBox.SelectedItem = createdUser;
        }
    }

    /// <summary>
    /// Déclencher le processsus de recherche d'utilisateurs à chaque que le texte de recherche change
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UserSearchTextBox_TextChanged(object sender, EventArgs e) {
        List<User> users = this.parentApp.UserService.SearchUsers(
            this.userSearchTextBox.Text.Trim());

        this.LoadUsersInListBox(users);
    }

    #endregion

    #region Gestion des rôles

    /// <summary>
    /// Charger une liste de rôles dans la list box des rôles
    /// </summary>
    /// <param name="roles">La liste de rôles</param>
    private void LoadRolesInListBox(List<Role> roles) {
        this.roleListBox.Items.Clear();
        this.roleListBox.SelectedItem = null;
        this.roleListBox.SelectedIndex = -1;

        foreach (Role role in roles) {
            _ = this.roleListBox.Items.Add(role);
        }
    }

    /// <summary>
    /// Activer les boutons d'action pour les rôles
    /// </summary>
    private void ActivateRoleActionButtons() {
        this.seeRoleDetailsButton.Enabled = true;
        this.updateRoleButton.Enabled = true;
        this.deleteRoleButton.Enabled = true;
    }

    /// <summary>
    /// Desactiver les boutons d'action pour les rôles
    /// </summary>
    private void DeactivateRoleActionButtons() {
        this.seeRoleDetailsButton.Enabled = false;
        this.updateRoleButton.Enabled = false;
        this.deleteRoleButton.Enabled = false;
    }

    /// <summary>
    /// Déclencher le processsus de création d'un rôle
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateRoleButton_Click(object sender, EventArgs e) {
        Role? createdRole = this.parentApp.RoleService.OpenViewFor(ViewActionsEnum.Creation);

        if (createdRole is not null) {
            _ = this.userListBox.Items.Add(createdRole);
            this.roleListBox.SelectedItem = createdRole;
        }
    }

    /// <summary>
    /// Déclencher le processsus de visualisation d'un rôle
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SeeRoleDetailsButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.RoleService.OpenViewFor(ViewActionsEnum.Visualization,
            this.roleListBox.SelectedItem as Role);
    }


    /// <summary>
    /// Déclencher le processsus de mise à jour d'un rôle
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void UpdateRoleButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.RoleService.OpenViewFor(ViewActionsEnum.Edition,
            this.roleListBox.SelectedItem as Role);
    }

    /// <summary>
    /// Déclencher le processsus de suppression d'un rôle
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DeleteRoleButton_Click(object sender, EventArgs e) {
        _ = this.parentApp.RoleService.OpenViewFor(ViewActionsEnum.Deletion,
            this.roleListBox.SelectedItem as Role);
    }

    /// <summary>
    /// Déclencher le processsus de recherche de rôles
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RoleSearchTextBox_TextChanged(object sender, EventArgs e) {
        List<Role> roles = this.parentApp.RoleService.SearchRoles(
            this.roleSearchTextBox.Text.Trim());
        this.LoadRolesInListBox(roles);
    }

    /// <summary>
    /// Activer les boutons d'action des rôles à chaque fois que le rôle selectionné dans la list box change
    /// Desactiver les boutons d'action lorsqu'aucun rôle n'est selectionné
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RoleListBox_SelectedIndexChanged(object sender, EventArgs e) {
        Role? selectedRole = this.roleListBox.SelectedItem as Role;

        if (selectedRole is not null) {
            this.ActivateRoleActionButtons();
        } else {
            this.DeactivateRoleActionButtons();
        }
    }

    #endregion
}
