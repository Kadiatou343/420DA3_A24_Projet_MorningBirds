using Exemple_Enseignant_Avance.Business.Domain;
using Exemple_Enseignant_Avance.Business.Services;
using ExtraAdvancedMultiTier.Business.Abstractions;
using Project_Utilities.Enums;
using Project_Utilities.Exceptions;
using System;
using System.Runtime.Serialization;

namespace Exemple_Enseignant_Avance.Presentation.Views;
public partial class MedecinView : Form, IEntityView<Medecin, int> {

    public IServiceContainer ServiceContainer { get; }
    public MedecinService EntityService { get; set; }
    public Medecin CurrentInstance { get; set; } = null!;
    public ViewActionsEnum CurrentAction { get; set; }

    IEntityService<Medecin, int> IEntityView<Medecin, int>.EntityService {
        get {
            return this.EntityService;
        }
    }

    public event IEntityView<Medecin, int>.ViewEventHandler ViewOpenEvent;
    public event IEntityView<Medecin, int>.CreationActionEventHandler CreationActionTriggeredEvent;
    public event IEntityView<Medecin, int>.VisualizationActionEventHandler VisualizationActionTriggeredEvent;
    public event IEntityView<Medecin, int>.ModificationActionEventHandler ModificationActionTriggeredEvent;
    public event IEntityView<Medecin, int>.DeletionActionEventHandler DeletionActionTriggeredEvent;

    public MedecinView(IServiceContainer app) {
        this.ServiceContainer = app;
        this.EntityService = app.GetService<MedecinService>() ?? throw new ArgumentException("No [MedecinService] found in the service container.", nameof(app));
        this.CurrentAction = ViewActionsEnum.Visualization; // default
        this.ViewOpenEvent += this.OnViewOpen;
        this.CreationActionTriggeredEvent += this.OnCreationActionTriggered;
        this.VisualizationActionTriggeredEvent += this.OnVisualizationActionTriggered;
        this.ModificationActionTriggeredEvent += this.OnModificationActionTriggered;
        this.DeletionActionTriggeredEvent += this.OnDeletionActionTriggered;
        this.InitializeComponent();
        this.copyrightLabel.Text = $"(c) {DateTime.Now.Year} Marc-Eric Boury - All rights reserved.";
    }

    public Medecin GetCurrentInstance() {
        return this.CurrentInstance;
    }

    public void SetCurrentInstance(Medecin medecin) {
        this.CurrentInstance = medecin;
    }

    public IEntityService<Medecin, int> GetEntityService() {
        return this.EntityService;
    }
    public ViewActionsEnum GetCurrentAction() {
        return this.CurrentAction;
    }

    public void SetCurrentAction(ViewActionsEnum view) {
        this.CurrentAction = view;
    }

    public DialogResult OpenFor(ViewActionsEnum action, Medecin? entity = null) {
        this.CurrentAction = action;
        this.CurrentInstance = entity;
        return this.ViewOpenEvent?.Invoke() ?? throw new Exception("Event [ViewOpenEvent] has no attached handler.");
    }

    private DialogResult OnViewOpen() {
        this.LoadInstanceInControls();
        this.UpdateControlsForAction();
        return this.ShowDialog();
    }

    private Medecin OnCreationActionTriggered() {
        this.ValidateControlsForAction();
        this.CurrentInstance = (Medecin) FormatterServices.GetUninitializedObject(typeof(Medecin));
        this.UpdateInstanceFromControls();
        return this.GetEntityService().Create(this.CurrentInstance);
    }

    private Medecin OnVisualizationActionTriggered() {
        return this.CurrentInstance;
    }

    private Medecin OnModificationActionTriggered() {
        this.ValidateControlsForAction();
        this.UpdateInstanceFromControls();
        return this.GetEntityService().Update(this.CurrentInstance);
    }

    private Medecin OnDeletionActionTriggered() {
        return this.GetEntityService().Delete(this.CurrentInstance);
    }

    public void LoadInstanceInControls() {
        if (this.CurrentInstance is not null) {
            this.idNumericUpDown.Value = this.CurrentInstance.Id;
            this.nomTextBox.Text = this.CurrentInstance.Nom;
            this.prenomTextBox.Text = this.CurrentInstance.Prenom;
            this.licenseNumericUpDown.Text = this.CurrentInstance.NumLicenseMedicale;
            this.dateCreatedDTPicker.Value = this.CurrentInstance.DateCreated ?? DateTime.Now;
            this.dateModifiedDTPicker.Value = this.CurrentInstance.DateModified ?? DateTime.Now;
            this.dateDeletedDTPicker.Value = this.CurrentInstance.DateDeleted ?? DateTime.Now;
        } else {
            this.idNumericUpDown.Value = 0;
            this.nomTextBox.Text = null;
            this.prenomTextBox.Text = null;
            this.licenseNumericUpDown.Text = null;
            this.dateCreatedDTPicker.Value = DateTime.Now;
            this.dateModifiedDTPicker.Value = DateTime.Now;
            this.dateDeletedDTPicker.Value = DateTime.Now;
        }
    }

    public void EnableEditableControls() {
        this.nomTextBox.Enabled = true;
        this.prenomTextBox.Enabled = true;
        this.licenseNumericUpDown.Enabled = true;
    }

    public void DisableEditableControls() {
        this.nomTextBox.Enabled = false;
        this.prenomTextBox.Enabled = false;
        this.licenseNumericUpDown.Enabled = false;
    }

    public void UpdateInstanceFromControls() {
        this.CurrentInstance.Nom = this.nomTextBox.Text.Trim();
        this.CurrentInstance.Prenom = this.prenomTextBox.Text.Trim();
        this.CurrentInstance.NumLicenseMedicale = this.licenseNumericUpDown.Text.Trim();
    }

    public void UpdateControlsForAction() {
        switch (this.CurrentAction) {
            case ViewActionsEnum.Creation:
                this.viewModeValueLabel.Text = "Creation";
                this.actionButton.Text = "Créer";
                this.EnableEditableControls();
                break;
            case ViewActionsEnum.Visualization:
                this.viewModeValueLabel.Text = "Visualization";
                this.actionButton.Text = "OK";
                this.DisableEditableControls();
                break;
            case ViewActionsEnum.Edition:
                this.viewModeValueLabel.Text = "Edition";
                this.actionButton.Text = "Save Changes";
                this.EnableEditableControls();
                break;
            case ViewActionsEnum.Deletion:
                this.viewModeValueLabel.Text = "Deletion";
                this.actionButton.Text = "Delete";
                this.DisableEditableControls();
                break;
            default:
                throw new NotImplementedException($"View action [{this.CurrentAction}] is not implemented.");
        }
    }


    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void ActionButton_Click(object sender, EventArgs e) {
        try {
            switch (this.CurrentAction) {
                case ViewActionsEnum.Creation:
                    this.CurrentInstance = this.CreationActionTriggeredEvent?.Invoke() 
                        ?? throw new Exception("Event [CreationActionTriggeredEvent] has no attached handler.");
                    ;
                    break;
                case ViewActionsEnum.Visualization:
                    this.CurrentInstance = this.VisualizationActionTriggeredEvent?.Invoke()
                        ?? throw new Exception("Event [VisualizationActionTriggeredEvent] has no attached handler.");
                    break;
                case ViewActionsEnum.Edition:
                    this.CurrentInstance = this.ModificationActionTriggeredEvent?.Invoke()
                        ?? throw new Exception("Event [ModificationActionTriggeredEvent] has no attached handler.");
                    break;
                case ViewActionsEnum.Deletion:
                    this.CurrentInstance = this.DeletionActionTriggeredEvent?.Invoke()
                        ?? throw new Exception("Event [DeletionActionTriggeredEvent] has no attached handler.");
                    break;
                default:
                    throw new NotImplementedException($"View action [{this.CurrentAction}] is not implemented.");
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            this.ServiceContainer.TriggerExceptionThrownEvent(ex);
        }
    }

    public void ValidateControlsForAction() {
        string message = string.Empty;

        // Checks on the ID value for edition and deletion actions only
        // since an ID is required for those operations.
        if (this.CurrentAction == ViewActionsEnum.Edition
            || this.CurrentAction == ViewActionsEnum.Deletion) {

            if (this.idNumericUpDown.Value == 0) {
                message += Environment.NewLine + "\t- Le numéro d'ID ne peut être vide.";
            }
            if (this.idNumericUpDown.Value < 0) {
                message += Environment.NewLine + "\t- Le numéro d'ID ne peut être négatif.";
            }
        }

        // Checks on input values for edition and creation actions only
        // since those values get stored in the database for those operations.
        if (this.CurrentAction == ViewActionsEnum.Creation
            || this.CurrentAction == ViewActionsEnum.Edition) {

            if (string.IsNullOrEmpty(this.nomTextBox.Text.Trim())) {
                message += Environment.NewLine + "\t- Le nom ne peut être vide.";
            }
            if (this.nomTextBox.Text.Trim().Length > Medecin.LASTNAME_MAX_LENGTH) {
                message += Environment.NewLine + $"\t- Le nom ne peut dépasser {Medecin.LASTNAME_MAX_LENGTH} caractères.";
            }

            if (string.IsNullOrEmpty(this.prenomTextBox.Text.Trim())) {
                message += Environment.NewLine + "\t- Le prénom ne peut être vide.";
            }
            if (this.prenomTextBox.Text.Trim().Length > Medecin.FIRSTNAME_MAX_LENGTH) {
                message += Environment.NewLine + $"\t- Le prénom ne peut dépasser {Medecin.FIRSTNAME_MAX_LENGTH} caractères.";
            }

            if (string.IsNullOrEmpty(this.licenseNumericUpDown.Text.Trim())) {
                message += Environment.NewLine + "\t- Le numéro de license médicale ne peut être vide.";
            }
            if (this.licenseNumericUpDown.Text.Trim().Length > Medecin.LICENSE_MAX_LENGTH) {
                message += Environment.NewLine + $"\t- Le numéro de license médicale ne peut dépasser {Medecin.LICENSE_MAX_LENGTH} caractères.";
            }
        }

        if (!string.IsNullOrEmpty(message)) {
            throw new ValidationException(message);
        }
    }
}
