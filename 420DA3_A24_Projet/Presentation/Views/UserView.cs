using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace _420DA3_A24_Projet.Presentation.Views;
/// <summary>
/// Classe représentant la vue d'un utilisateur
/// </summary>
internal partial class UserView : Form {
    /// <summary>
    /// L'application elle-même
    /// </summary>
    private readonly WsysApplication parentApp;
    /// <summary>
    /// L'action de vue pour la fenêtre
    /// </summary>
    private ViewActionsEnum action;
    /// <summary>
    /// L'utilisateur associé à la vue ou null
    /// </summary>
    private User? userInstance;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="parentApp">L'application</param>
    public UserView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.action = ViewActionsEnum.Visualization;
        this.copyrightLabel.Text = this.parentApp.GetCopyright();
        this.InitializeComponent();
    }

    /// <summary>
    /// Obtenir l'utilisateur courant qui est concerné par la vue
    /// </summary>
    /// <returns></returns>
    public User? GetUserCurrentInstance() {
        return this.userInstance;
    }

    /// <summary>
    /// Ouvrir la fenêtre courante en fonction de l'action de la vue et d'un utilisateur ou pas
    /// </summary>
    /// <param name="action">L'action de la vue pour laquelle la fenêtre doit être ouverte</param>
    /// <param name="user">Le possible d'un utilisateur pour lequel la fenêtre doit être ouverte</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">L'exception levée si l'utilisateur est null pour certaines actions</exception>
    /// <exception cref="NotImplementedException">L'exception levée si l'action fournie n'est pas reconnue</exception>
    public DialogResult OpenFor(ViewActionsEnum action, User? user = null) {
        this.action = action;
        this.userInstance = user;
        this.LoadInstanceInControls(user);
        switch (action) {
            case ViewActionsEnum.Visualization:
                if (user == null) {
                    throw new ArgumentException($"L'utilisateur ne peut pas être null pour l'action [{action}].");
                }
                this.LoadUserRolesInListBox();
                this.viewModeValue.Text = "Visualisation";
                this.actionButton.Text = "OK";
                this.DisableEditableControls();

                break;
            case ViewActionsEnum.Creation:
                this.LoadUserRolesInListBox();
                this.viewModeValue.Text = "Création";
                this.actionButton.Text = "Créer";
                this.EnableEditableControls();
                break;
            case ViewActionsEnum.Edition:
                if (user == null) {
                    throw new ArgumentException($"L'utilisateur ne peut pas être null pour l'action [{action}].");
                }
                this.LoadUserRolesInListBox();
                this.viewModeValue.Text = "Modification";
                this.actionButton.Text = "Modifier";
                this.EnableEditableControls();
                break;
            case ViewActionsEnum.Deletion:
                if (user == null) {
                    throw new ArgumentException($"L'utilisateur ne peut pas être null pour l'action [{action}].");
                }
                this.LoadUserRolesInListBox();
                this.viewModeValue.Text = "Suppression";
                this.actionButton.Text = "Supprimer";
                this.DisableEditableControls();
                break;
            default:
                throw new NotImplementedException($"L'action [{action}] n'est pas implementée");
        }
        return this.ShowDialog();
    }

    /// <summary>
    /// Charger les éléments d'une liste d'entrepôts dans la liste box fait pour dans la fenetre
    /// </summary>
    /// <param name="warehouses">La liste d'entrepôt</param>
    private void ReloadEmployeeWaherouseList(List<Warehouse> warehouses) {
        this.employeeWhListBox.Items.Clear();
        this.employeeWhListBox.SelectedItem = null;
        this.employeeWhListBox.SelectedIndex = -1;

        foreach (Warehouse warehouse in warehouses) {
            _ = this.employeeWhListBox.Items.Add(warehouse);
        }
    }

    /// <summary>
    /// Charger les rôles du système dans la list box fait pour
    /// </summary>
    private void LoadUserRolesInListBox() {
        List<Role> roles = this.parentApp.RoleService.GetAllRoles();
        this.userRolesListBox.Items.Clear();
        this.userRolesListBox.SelectedItems.Clear();

        foreach (Role role in roles) {
            _ = this.userRolesListBox.Items.Add(role);
        }

    }

    /// <summary>
    /// Charger les informations par defaut dans les controls en fonction d'un utilisateur ou null
    /// </summary>
    /// <param name="user">L'utilisateur concerné</param>
    /// <exception cref="Exception">L'exception levé si la méthode d'obtention des roles par id retourne un null</exception>
    private void LoadInstanceInControls(User? user) {
        if (user is null) {
            this.idNumUpDown.Value = 0;
            this.usernameTextBox.Text = null;
            this.passwordTextBox.Text = null;
            this.dateCreatedDTPicker.Value = DateTime.Now;
            this.dateModifiedDTPicker.Value = DateTime.Now;
            this.dateDeletedDTPicker.Value = DateTime.Now;

            //got to wait for warehouse service
            //this.ReloadEmployeeWaherouseList(this.parentApp.WarehouseService.getAllWarehouses());
        } else {
            this.idNumUpDown.Value = user.Id;
            this.usernameTextBox.Text = user.Username;
            this.passwordTextBox.Text = "Ensuré";
            this.dateCreatedDTPicker.Value = user.DateCreated;
            this.dateModifiedDTPicker.Value = user.DateModified ?? DateTime.Now;
            this.dateDeletedDTPicker.Value = user.DateDeleted ?? DateTime.Now;

            //got to wait for warehouse service
            //this.ReloadEmployeeWaherouseList(this.parentApp.WarehouseService.getAllWarehouses());

        }
    }

    /// <summary>
    /// Activer les controls modifiables 
    /// </summary>
    private void EnableEditableControls() {
        this.usernameTextBox.Enabled = true;
        this.passwordTextBox.Enabled = true;
        this.userRolesListBox.Enabled = true;
        this.employeeWhListBox.Enabled = true;
    }

    /// <summary>
    /// Desactiver les controls modifiables 
    /// </summary>
    private void DisableEditableControls() {
        this.usernameTextBox.Enabled = false;
        this.passwordTextBox.Enabled = false;
        this.userRolesListBox.Enabled = false;
        this.employeeWhListBox.Enabled = false;
    }

    /// <summary>
    /// Proceder l'action en cours
    /// </summary>
    /// <exception cref="Exception">Taille du hash maximale atteinte, Rôles non trouvés</exception>
    /// <exception cref="NotImplementedException">L'action en cours n'est pas reconnue</exception>
    private void ProcessAction() {
        this.ValidateControlsForAction();
        switch (this.action) {
            case ViewActionsEnum.Visualization:
                // Rien à faire dans ce case parce que il faut juster visualiser
                break;
            case ViewActionsEnum.Creation:
                string passwordHash = this.parentApp.PasswordService.HashPassword(this.passwordTextBox.Text.Trim());
                if (passwordHash.Length > User.PASSWORDHASH_MAX_LENGTH) {
                    throw new Exception($"Le hash du mot de passe depasse la taille maximale [{User.PASSWORDHASH_MAX_LENGTH}].");
                }

                User newUser = new User(
                    this.usernameTextBox.Text.Trim(),
                    passwordHash,
                    (this.employeeWhListBox.SelectedItem as Role)?.Id
                    );

                foreach (Role role in this.userRolesListBox.SelectedItems.Cast<Role>().ToList()) {
                    newUser.Roles.Add(role);
                }

                this.userInstance = this.parentApp.UserService.CreateUser(newUser);
                break;

            case ViewActionsEnum.Edition:
                if (this.userInstance == null) {
                    throw new Exception("Aucune instance d'utilisateur chargé!");
                }
                this.userInstance.Username = this.usernameTextBox.Text.Trim();
                this.userInstance.PasswordHash = this.parentApp.PasswordService.HashPassword(
                    this.passwordTextBox.Text.Trim());
                this.userInstance.EmployeeWarehouseId = (this.employeeWhListBox.SelectedItem as Role)?.Id;

                this.userInstance.Roles.Clear();

                foreach (Role role in this.userRolesListBox.SelectedItems.Cast<Role>().ToList()) {
                    this.userInstance.Roles.Add(role);
                }

                this.userInstance = this.parentApp.UserService.UpdateUser(this.userInstance);
                break;
            case ViewActionsEnum.Deletion:
                if (this.userInstance == null) {
                    throw new Exception("Aucune instance d'utilisateur chargé!");
                }

                this.parentApp.UserService.DeleteUser(this.userInstance);
                this.userInstance = null;
                break;
            default:
                throw new NotImplementedException($"View action [{this.action}] is not implemented.");
        }
    }

    /// <summary>
    /// Valider les données saisis dans les controls faits pour recupérer l'entrée utilisateur
    /// </summary>
    /// <exception cref="Exception">L'exception levée si le message d'erreur n'est pas vide</exception>
    private void ValidateControlsForAction() {
        string message = string.Empty;

        // Verification du controle pour l'id uniquement pour la modification et la suppression
        if (this.action == ViewActionsEnum.Edition
            || this.action == ViewActionsEnum.Deletion) {
            if (this.idNumUpDown.Value == 0) {
                message += Environment.NewLine + "\t- Le numero de l'identifiant ne peut pas être vide.";
            }
            if (this.idNumUpDown.Value < 0) {
                message += Environment.NewLine + "\t- Le numero de l'identifiant ne doit pas être négatif.";
            }
        }

        // Verification des champs de saisie pour la création et la modification
        if (this.action == ViewActionsEnum.Edition
            || this.action == ViewActionsEnum.Creation) {

            if (string.IsNullOrEmpty(this.usernameTextBox.Text.Trim())) {
                message += Environment.NewLine + "\t- Le nom d'utilisateur ne peut pas être vide.";
            }

            if (this.usernameTextBox.Text.Length > User.USERNAME_MAX_LENGTH
                || this.usernameTextBox.Text.Length < User.USERNAME_MIN_LENGTH) {

                message += Environment.NewLine + $"\t- La longueur du nom d'utilisateur ne peut pas être supérieure à {User.USERNAME_MAX_LENGTH} "
                    + $"ou inférieure à {User.USERNAME_MIN_LENGTH} caractères.";
            }

            if (string.IsNullOrEmpty(this.passwordTextBox.Text.Trim())) {
                message += Environment.NewLine + "\t- Le mot de passe ne peut pas être vide.";
            }

            if (this.passwordTextBox.Text.Length > User.PASSWORD_MAX_LENGTH
                || this.passwordTextBox.Text.Length < User.PASSWORD_MIN_LENGTH) {
                message += Environment.NewLine + $"\t- La longueur du mot de passe ne peut être supérieure à {User.PASSWORD_MAX_LENGTH} "
                    + $" ou inférieure à {User.PASSWORD_MIN_LENGTH} caractères.";
            }

            if (this.userRolesListBox.SelectedItems.Count <= 0) {
                message += Environment.NewLine + "\t- Au moins un role doit être associé à l'utilisateur.";
            }

            // Si le rôle d'employé est selectionné mais qu'aucun entrepôt n'est selectionné 
            this.userRolesListBox.SelectedItems.Cast<Role>().ToList().ForEach(role => {
                if (role.Id == Role.WH_EMPLOYEE_ROLE_ID && this.employeeWhListBox.SelectedItem == null) {
                    message += Environment.NewLine + "\t- Un entrepôt doit être associé à un employé d'entrepôt";
                }
            });
        }

        if (!string.IsNullOrEmpty(message)) {
            throw new ValidationException(message);
        }
    }

    /// <summary>
    /// Executer une action
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ActionButton_Click(object sender, EventArgs e) {
        try {
            this.ProcessAction();
            this.DialogResult = DialogResult.OK;
        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    /// <summary>
    /// Fermer la fenêtre
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
