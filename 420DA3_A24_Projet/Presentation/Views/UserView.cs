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
internal partial class UserView : Form {
    private readonly WsysApplication parentApp;
    private ViewActionsEnum action;
    private User? userInstance;
    public UserView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        action = ViewActionsEnum.Visualization;
        this.InitializeComponent();
        this.copyrightLabel.Text = this.parentApp.GetCopyright();
    }

    public User? GetUserCurrentInstance() {
        return this.userInstance;
    }

    private void ReloadEmployeeWaherouseList(List<Warehouse> warehouses) {
        this.employeeWhListBox.Items.Clear();
        this.employeeWhListBox.SelectedItem = null;
        this.employeeWhListBox.SelectedIndex = -1;

        foreach(Warehouse warehouse in warehouses) {
            _ = this.employeeWhListBox.Items.Add(warehouse);
        }
    }

    private void LoadInstanceInControls(User? user) {
        if (user is null) {
            this.idNumUpDown.Value = 0;
            this.usernameTextBox.Text = null;
            this.passwordTextBox.Text = null;
            this.adminRoleChkBox.Checked = false;
            this.officeEmpRoleChkBox.Checked = false;
            this.whEmpRoleChkBox.Checked = false;
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

            if (user.Roles.Contains(
                this.parentApp.RoleService.GetRoleById(Role.ADMIN_ROLE_ID)
                        ?? throw new Exception($"Aucun rôle trouvé pour l'identifiant de rôle [{Role.ADMIN_ROLE_ID}].")
                        )) {
                this.adminRoleChkBox.Checked = true;
            }

            if (user.Roles.Contains(
                this.parentApp.RoleService.GetRoleById(Role.OFFICE_EMPLOYEE_ROLE_ID)
                        ?? throw new Exception($"Aucun rôle trouvé pour l'identifiant de rôle [{Role.OFFICE_EMPLOYEE_ROLE_ID}].")
                        )) {
                this.officeEmpRoleChkBox.Checked = true;
            }

            //got to wait for warehouse service
            //this.ReloadEmployeeWaherouseList(this.parentApp.WarehouseService.getAllWarehouses());

            if (user.Roles.Contains(
                this.parentApp.RoleService.GetRoleById(Role.WH_EMPLOYEE_ROLE_ID)
                        ?? throw new Exception($"Aucun rôle trouvé pour l'identifiant de rôle [{Role.WH_EMPLOYEE_ROLE_ID}].")
                        )) {
                this.whEmpRoleChkBox.Checked = true;
                this.employeeWhListBox.SelectedItem = user.EmployeeWarehouse;
            }

            

            
        }
    }

    private void EnableEditableControls() {
        this.usernameTextBox.Enabled = true;
        this.passwordTextBox.Enabled = true;
        this.adminRoleChkBox.Enabled = true;
        this.officeEmpRoleChkBox.Enabled = true;
        this.whEmpRoleChkBox.Enabled = true;
        this.employeeWhListBox.Enabled = true;
    }

    private void DisableEditableControls() {
        this.usernameTextBox.Enabled = false;
        this.passwordTextBox.Enabled = false;
        this.adminRoleChkBox.Enabled = false;
        this.officeEmpRoleChkBox.Enabled = false;
        this.whEmpRoleChkBox.Enabled = false;
        this.employeeWhListBox.Enabled = false;
    }

    private void ExecuteAction() {
        this.ValidateControlsForAction();
        switch (this.action) {
            case ViewActionsEnum.Visualization:
                // Rien à faire dans le case de visualisation
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

                if (this.adminRoleChkBox.Checked) {
                    newUser.Roles.Add(
                        this.parentApp.RoleService.GetRoleById(Role.ADMIN_ROLE_ID) 
                        ?? throw new Exception($"Aucun rôle trouvé pour l'identifiant de rôle [{Role.ADMIN_ROLE_ID}].")
                        );
                }

                if (this.officeEmpRoleChkBox.Checked) {
                    newUser.Roles.Add(
                        this.parentApp.RoleService.GetRoleById(Role.OFFICE_EMPLOYEE_ROLE_ID)
                        ?? throw new Exception($"Aucun rôle trouvé pour l'identifiant de rôle [{Role.OFFICE_EMPLOYEE_ROLE_ID}].")
                        );
                }

                if (this.whEmpRoleChkBox.Checked) {
                    newUser.Roles.Add(
                        this.parentApp.RoleService.GetRoleById(Role.WH_EMPLOYEE_ROLE_ID)
                        ?? throw new Exception($"Aucun rôle trouvé pour l'identifiant de rôle [{Role.WH_EMPLOYEE_ROLE_ID}].")
                        );
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

                if (this.adminRoleChkBox.Checked) {
                    this.userInstance.Roles.Add(
                        this.parentApp.RoleService.GetRoleById(Role.ADMIN_ROLE_ID)
                        ?? throw new Exception($"Aucun rôle trouvé pour l'identifiant de rôle [{Role.ADMIN_ROLE_ID}].")
                        );
                }

                if (this.officeEmpRoleChkBox.Checked) {
                    this.userInstance.Roles.Add(
                        this.parentApp.RoleService.GetRoleById(Role.OFFICE_EMPLOYEE_ROLE_ID)
                        ?? throw new Exception($"Aucun rôle trouvé pour l'identifiant de rôle [{Role.OFFICE_EMPLOYEE_ROLE_ID}].")
                        );
                }

                if (this.whEmpRoleChkBox.Checked) {
                    this.userInstance.Roles.Add(
                        this.parentApp.RoleService.GetRoleById(Role.WH_EMPLOYEE_ROLE_ID)
                        ?? throw new Exception($"Aucun rôle trouvé pour l'identifiant de rôle [{Role.WH_EMPLOYEE_ROLE_ID}].")
                        );
                }

                this.userInstance = this.parentApp.UserService.UpdateUser( this.userInstance );
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

            if (!this.adminRoleChkBox.Checked && !this.officeEmpRoleChkBox.Checked
                && !this.whEmpRoleChkBox.Checked) {
                message += Environment.NewLine + "\t- Au moins un role doit être associé à l'utilisateur.";
            }

            if (this.whEmpRoleChkBox.Checked && this.employeeWhListBox.SelectedItem == null) {
                message += Environment.NewLine + "\t- Un entrepôt doit être choisi pour un employé d'entrepôt.";
            }
        }

        if (!string.IsNullOrEmpty(message)) {
            throw new Exception(message);
        }
    }
}
