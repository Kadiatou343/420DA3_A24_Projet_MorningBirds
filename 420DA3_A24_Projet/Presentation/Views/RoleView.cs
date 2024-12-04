using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class RoleView : Form {
    /// <summary>
    /// L'application elle-même
    /// </summary>
    private readonly WsysApplication parentApp;

    /// <summary>
    /// L'action de vue pour la fenêtre
    /// </summary>
    private ViewActionsEnum action;

    /// <summary>
    /// Le rôle associé à la fenêtre ou null
    /// </summary>
    private Role? roleInstance;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="parentApp">L'application</param>
    public RoleView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.action = ViewActionsEnum.Visualization;
        this.InitializeComponent();
        this.copyrightLabel.Text = this.parentApp.GetCopyright();
    }

    /// <summary>
    /// Obtenir l'instance de rôl courant
    /// </summary>
    /// <returns>Role</returns>
    public Role? GetRoleInstance() {
        return this.roleInstance;
    }

    /// <summary>
    /// Ouvrir la fenêtre courante en fonction de l'action de la vue et d'un rôle ou pas
    /// </summary>
    /// <param name="action">L'action de la vue pour laquelle la fenêtre doit être ouverte</param>
    /// <param name="role">Le possible rôle pour lequel la fenêtre doit être ouverte</param>
    /// <returns>Le DialogResult de la fenêtre courrante</returns>
    /// <exception cref="ArgumentException">L'exception levée si le rôle est null pour certaines actions</exception>
    /// <exception cref="NotImplementedException">L'exception levée si l'action fourni n'est pas reconnue</exception>
    public DialogResult OpenFor(ViewActionsEnum action, Role? role = null) {
        this.action = action;
        this.LoadInstanceInControls(role);
        switch (action) {
            case ViewActionsEnum.Visualization:
                if (role is null) {
                    throw new ArgumentException($"Le paramètre [role] ne peut null pour l'action [{action}].");
                }
                this.viewModeValueLabel.Text = "Visualisation";
                this.actionButton.Text = "OK";
                this.DisableEditableControls();
                break;
            case ViewActionsEnum.Creation:
                this.viewModeValueLabel.Text = "Création";
                this.actionButton.Text = "Créer";
                this.EnableEditableControls();
                break;
            case ViewActionsEnum.Edition:
                if (role is null) {
                    throw new ArgumentException($"Le paramètre [role] ne peut null pour l'action [{action}].");
                }
                this.viewModeValueLabel.Text = "Modification";
                this.actionButton.Text = "Modifier";
                this.EnableEditableControls();
                break;
            case ViewActionsEnum.Deletion:
                if (role is null) {
                    throw new ArgumentException($"Le paramètre [role] ne peut null pour l'action [{action}].");
                }
                this.viewModeValueLabel.Text = "Suppression";
                this.actionButton.Text = "Supprimer";
                this.DisableEditableControls();
                break;
            default:
                throw new NotImplementedException($"Action [{action}] non implementée !");
        }

        return this.ShowDialog();
    }

    /// <summary>
    /// Charger les information par defaut dans les controls en fonction d'un rôle ou null
    /// </summary>
    /// <param name="role">Le rôle dont les informations seront chargés</param>
    private void LoadInstanceInControls(Role? role) {
        if (role is null) {
            this.idNumUpDown.Value = 0;
            this.roleNameTextBox.Text = null;
            this.roleDescRichTextBox.Text = null;
            this.dateCreatedDTPicker.Value = DateTime.Now;
            this.dateModifiedDTPicker.Value = DateTime.Now;
            this.dateDeletedDTPicker.Value = DateTime.Now;
        } else {
            this.idNumUpDown.Value = role.Id;
            this.roleNameTextBox.Text = role.RoleName;
            this.roleDescRichTextBox.Text = role.RoleDescription;
            this.dateCreatedDTPicker.Value = role.DateCreated;
            this.dateModifiedDTPicker.Value = role.DateModified ?? DateTime.Now;
            this.dateDeletedDTPicker.Value = role.DateDeleted ?? DateTime.Now;
        }

        this.roleInstance = role;
    }

    /// <summary>
    /// Activer les controls editables
    /// </summary>
    private void EnableEditableControls() {
        this.roleNameTextBox.Enabled = true;
        this.roleDescRichTextBox.Enabled = true;
    }

    /// <summary>
    /// Desactiver les controls editables
    /// </summary>
    private void DisableEditableControls() {
        this.roleNameTextBox.Enabled = false;
        this.roleDescRichTextBox.Enabled = false;
    }

    /// <summary>
    /// Procéder l'action en cours
    /// </summary>
    /// <exception cref="Exception">L'exception levée si aucune instance de rôle n'est chargée</exception>
    /// <exception cref="NotImplementedException">L'exception levée si l'action en cours n'est pas reconnue</exception>
    private void ProcessAction() {
        this.ValidateControlsForAction();
        switch (this.action) {
            case ViewActionsEnum.Visualization:
                //Nothing to do in this case cause it's just visualizing
                break;
            case ViewActionsEnum.Creation:
                Role newRole = new Role(
                    this.roleNameTextBox.Text.Trim(),
                    this.roleDescRichTextBox.Text.Trim());
                this.roleInstance = this.parentApp.RoleService.CreateRole(newRole);
                break;
            case ViewActionsEnum.Edition:
                if (this.roleInstance == null) {
                    throw new Exception("Aucune instance de rôle chargée.");
                }
                this.roleInstance.RoleName = this.roleNameTextBox.Text.Trim();
                this.roleInstance.RoleDescription = this.roleDescRichTextBox.Text.Trim();
                this.roleInstance = this.parentApp.RoleService.UpdateRole(this.roleInstance);
                break;
            case ViewActionsEnum.Deletion:
                if (this.roleInstance == null) {
                    throw new Exception("Aucune instance de rôle chargée.");
                }
                this.parentApp.RoleService.DeleteRole(this.roleInstance);
                this.roleInstance = null;
                break;
            default:
                throw new NotImplementedException($"Action [{this.action}] non implementée.");
        }
    }

    /// <summary>
    /// Valider les controls modifiable par l'utilisateur
    /// </summary>
    /// <exception cref="ValidationException">L'exception levée si le message d'erreur n'est pas vide</exception>
    private void ValidateControlsForAction() {
        string message = string.Empty;

        if (this.action == ViewActionsEnum.Edition
            || this.action == ViewActionsEnum.Deletion) {

            if (this.idNumUpDown.Value == 0) {
                message += Environment.NewLine + "\t- Le numero de l'identifiant ne peut être vide.";
            }
            if (this.idNumUpDown.Value < 0) {
                message += Environment.NewLine + "\t- Le numero de l'identifiant ne peut negatif.";
            }
        }

        if (this.action == ViewActionsEnum.Creation
            || this.action == ViewActionsEnum.Edition) {

            if (string.IsNullOrEmpty(this.roleNameTextBox.Text.Trim())) {
                message += Environment.NewLine + "\t- Le nom du rôle ne peut être vide.";
            }

            if (this.roleNameTextBox.Text.Trim().Length > Role.ROLE_NAME_MAX_LENGTH) {
                message += Environment.NewLine + $"\t- La longueur du nom du rôle ne peut depasser {Role.ROLE_NAME_MAX_LENGTH} caractères.";
            }

            if (string.IsNullOrEmpty(this.roleDescRichTextBox.Text.Trim())) {
                message += Environment.NewLine + "\t- La description du rôle ne peut être vide.";
            }

            if (this.roleDescRichTextBox.Text.Trim().Length > Role.ROLE_DESCRIPTION_MAX_LENGTH) {
                message += Environment.NewLine + $"\t- La longueur de la description du rôle ne peut depasser {Role.ROLE_DESCRIPTION_MAX_LENGTH} caractères.";
            }
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
