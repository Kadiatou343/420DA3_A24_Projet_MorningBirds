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

    private readonly WsysApplication parentApp;
    private ViewActionsEnum action;
    private Role? roleInstance;
    public RoleView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.action = ViewActionsEnum.Visualization;
        this.InitializeComponent();
        this.copyrightLabel.Text = this.parentApp.GetCopyright();
    }

    public Role? GetRoleInstance() {
        return this.roleInstance;
    }

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

    private void EnableEditableControls() {
        this.roleNameTextBox.Enabled = true;
        this.roleDescRichTextBox.Enabled = true;
    }

    private void DisableEditableControls() {
        this.roleNameTextBox.Enabled = false;
        this.roleDescRichTextBox.Enabled = false;
    }

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
}
