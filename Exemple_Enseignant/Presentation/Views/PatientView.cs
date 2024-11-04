using _420DA3_A24_Exemple_Enseignant.Business;
using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using Project_Utilities.Enums;
using Project_Utilities.Exceptions;

namespace _420DA3_A24_Exemple_Enseignant.Presentation.Views;
internal partial class PatientView : Form {
    private readonly ExempleApplication application;
    private ViewActionsEnum currentAction;
    private Patient? currentInstance;

    public PatientView(ExempleApplication app) {
        this.application = app;
        this.currentAction = ViewActionsEnum.Visualization; // default
        this.InitializeComponent();
        this.copyrightLabel.Text = this.application.GetCopyrightNotice();
    }

    public Patient? GetCurrentInstance() {
        return this.currentInstance;
    }

    public DialogResult OpenFor(ViewActionsEnum currentAction, Patient? patient = null) {
        this.currentAction = currentAction;
        this.LoadInstanceInControls(patient);
        switch (currentAction) {
            case ViewActionsEnum.Creation:
                this.viewModeValueLabel.Text = "Creation";
                this.actionButton.Text = "Créer";
                this.EnableEditableControls();
                break;
            case ViewActionsEnum.Visualization:
                if (patient is null) {
                    throw new ArgumentException($"Parameter [patient] cannot be null for view action [{currentAction}].");
                }
                this.viewModeValueLabel.Text = "Visualization";
                this.actionButton.Text = "OK";
                this.DisableEditableControls();
                break;
            case ViewActionsEnum.Edition:
                if (patient is null) {
                    throw new ArgumentException($"Parameter [patient] cannot be null for view action [{currentAction}].");
                }
                this.viewModeValueLabel.Text = "Edition";
                this.actionButton.Text = "Save Changes";
                this.EnableEditableControls();
                break;
            case ViewActionsEnum.Deletion:
                if (patient is null) {
                    throw new ArgumentException($"Parameter [patient] cannot be null for view action [{currentAction}].");
                }
                this.viewModeValueLabel.Text = "Deletion";
                this.actionButton.Text = "Delete";
                this.DisableEditableControls();
                break;
            default:
                throw new NotImplementedException($"View action [{currentAction}] is not implemented.");
        }
        return this.ShowDialog();
    }

    private void LoadInstanceInControls(Patient? patient) {
        if (patient is not null) {
            this.idNumericUpDown.Value = patient.Id;
            this.nomTextBox.Text = patient.Nom;
            this.prenomTextBox.Text = patient.Prenom;
            this.numAssMaladieTextBox.Text = patient.NumAssMaladie;
            this.dateCreatedDTPicker.Value = patient.DateCreated;
            this.dateModifiedDTPicker.Value = patient.DateModified ?? DateTime.Now;
            this.dateDeletedDTPicker.Value = patient.DateDeleted ?? DateTime.Now;
        } else {
            this.idNumericUpDown.Value = 0;
            this.nomTextBox.Text = null;
            this.prenomTextBox.Text = null;
            this.numAssMaladieTextBox.Text = null;
            this.dateCreatedDTPicker.Value = DateTime.Now;
            this.dateModifiedDTPicker.Value = DateTime.Now;
            this.dateDeletedDTPicker.Value = DateTime.Now;
        }
        this.currentInstance = patient;
    }

    private void EnableEditableControls() {
        this.nomTextBox.Enabled = true;
        this.prenomTextBox.Enabled = true;
        this.numAssMaladieTextBox.Enabled = true;
    }

    private void DisableEditableControls() {
        this.nomTextBox.Enabled = false;
        this.prenomTextBox.Enabled = false;
        this.numAssMaladieTextBox.Enabled = false;
    }


    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void ActionButton_Click(object sender, EventArgs e) {
        try {
            this.ProcessAction();
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            this.application.HandleException(ex);
        }
    }

    private void ProcessAction() {
        this.ValidateControlsForAction();
        switch (this.currentAction) {
            case ViewActionsEnum.Creation:
                Patient newPatient = new Patient(
                    this.nomTextBox.Text.Trim(),
                    this.prenomTextBox.Text.Trim(),
                    this.numAssMaladieTextBox.Text.Trim()
                );
                this.currentInstance = this.application.PatientService.Create(newPatient);
                break;
            case ViewActionsEnum.Visualization:
                // do nothing on visualization
                break;
            case ViewActionsEnum.Edition:
                if (this.currentInstance == null) {
                    throw new Exception("No current instance of [Patient] loaded.");
                }
                this.currentInstance.Nom = this.nomTextBox.Text.Trim();
                this.currentInstance.Prenom = this.prenomTextBox.Text.Trim();
                this.currentInstance.NumAssMaladie = this.numAssMaladieTextBox.Text.Trim();
                this.currentInstance = this.application.PatientService.Update(this.currentInstance);
                break;
            case ViewActionsEnum.Deletion:
                if (this.currentInstance == null) {
                    throw new Exception("No current instance of [Patient] loaded.");
                }
                this.application.PatientService.Delete(this.currentInstance);
                this.currentInstance = null;
                break;
            default:
                throw new NotImplementedException($"View action [{this.currentAction}] is not implemented.");
        }
    }

    private void ValidateControlsForAction() {
        string message = string.Empty;

        // Checks on the ID value for edition and deletion actions only
        // since an ID is required for those operations.
        if (this.currentAction == ViewActionsEnum.Edition
            || this.currentAction == ViewActionsEnum.Deletion) {

            if (this.idNumericUpDown.Value == 0) {
                message += Environment.NewLine + "\t- Le numéro d'ID ne peut être vide.";
            }
            if (this.idNumericUpDown.Value < 0) {
                message += Environment.NewLine + "\t- Le numéro d'ID ne peut être négatif.";
            }
        }

        // Checks on input values for edition and creation actions only
        // since those values get stored in the database for those operations.
        if (this.currentAction == ViewActionsEnum.Creation
            || this.currentAction == ViewActionsEnum.Edition) {

            if (string.IsNullOrEmpty(this.nomTextBox.Text.Trim())) {
                message += Environment.NewLine + "\t- Le nom ne peut être vide.";
            }
            if (this.nomTextBox.Text.Trim().Length > Patient.LASTNAME_MAX_LENGTH) {
                message += Environment.NewLine + $"\t- Le nom ne peut dépasser {Patient.LASTNAME_MAX_LENGTH} caractères.";
            }

            if (string.IsNullOrEmpty(this.prenomTextBox.Text.Trim())) {
                message += Environment.NewLine + "\t- Le prénom ne peut être vide.";
            }
            if (this.prenomTextBox.Text.Trim().Length > Patient.FIRSTNAME_MAX_LENGTH) {
                message += Environment.NewLine + $"\t- Le prénom ne peut dépasser {Patient.FIRSTNAME_MAX_LENGTH} caractères.";
            }

            if (string.IsNullOrEmpty(this.numAssMaladieTextBox.Text.Trim())) {
                message += Environment.NewLine + "\t- Le numéro d'assurance maladie ne peut être vide.";
            }
            if (this.numAssMaladieTextBox.Text.Trim().Length > Patient.ASSNUMBER_MAX_LENGTH) {
                message += Environment.NewLine + $"\t- Le numéro d'assurance maladie ne peut dépasser {Patient.ASSNUMBER_MAX_LENGTH} caractères.";
            }
        }

        if (!string.IsNullOrEmpty(message)) {
            throw new ValidationException(message);
        }
    }
}
