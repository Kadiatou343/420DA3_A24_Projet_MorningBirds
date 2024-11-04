using _420DA3_A24_Exemple_Enseignant.Business;
using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using Project_Utilities.Enums;
using Project_Utilities.Exceptions;

namespace _420DA3_A24_Exemple_Enseignant.Presentation.Views;
internal partial class MedecinView : Form {
    private readonly ExempleApplication application;
    private ViewActionsEnum currentAction;
    private Medecin? currentInstance;

    public MedecinView(ExempleApplication app) {
        this.application = app;
        this.currentAction = ViewActionsEnum.Visualization; // default
        this.InitializeComponent();
        this.copyrightLabel.Text = this.application.GetCopyrightNotice();
    }

    public Medecin? GetCurrentInstance() {
        return this.currentInstance;
    }

    public DialogResult OpenFor(ViewActionsEnum currentAction, Medecin? medecin = null) {
        this.currentAction = currentAction;
        this.LoadInstanceInControls(medecin);
        switch (currentAction) {
            case ViewActionsEnum.Creation:
                this.viewModeValueLabel.Text = "Creation";
                this.actionButton.Text = "Créer";
                this.EnableEditableControls();
                break;
            case ViewActionsEnum.Visualization:
                if (medecin is null) {
                    throw new ArgumentException($"Parameter [medecin] cannot be null for view action [{currentAction}].");
                }
                this.viewModeValueLabel.Text = "Visualization";
                this.actionButton.Text = "OK";
                this.DisableEditableControls();
                break;
            case ViewActionsEnum.Edition:
                if (medecin is null) {
                    throw new ArgumentException($"Parameter [medecin] cannot be null for view action [{currentAction}].");
                }
                this.viewModeValueLabel.Text = "Edition";
                this.actionButton.Text = "Save Changes";
                this.EnableEditableControls();
                break;
            case ViewActionsEnum.Deletion:
                if (medecin is null) {
                    throw new ArgumentException($"Parameter [medecin] cannot be null for view action [{currentAction}].");
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

    private void LoadInstanceInControls(Medecin? medecin) {
        if (medecin is not null) {
            this.idNumericUpDown.Value = medecin.Id;
            this.nomTextBox.Text = medecin.Nom;
            this.prenomTextBox.Text = medecin.Prenom;
            this.licenseNumericUpDown.Text = medecin.NumLicenseMedicale;
            this.dateCreatedDTPicker.Value = medecin.DateCreated;
            this.dateModifiedDTPicker.Value = medecin.DateModified ?? DateTime.Now;
            this.dateDeletedDTPicker.Value = medecin.DateDeleted ?? DateTime.Now;
        } else {
            this.idNumericUpDown.Value = 0;
            this.nomTextBox.Text = null;
            this.prenomTextBox.Text = null;
            this.licenseNumericUpDown.Text = null;
            this.dateCreatedDTPicker.Value = DateTime.Now;
            this.dateModifiedDTPicker.Value = DateTime.Now;
            this.dateDeletedDTPicker.Value = DateTime.Now;
        }
        this.currentInstance = medecin;
    }

    private void EnableEditableControls() {
        this.nomTextBox.Enabled = true;
        this.prenomTextBox.Enabled = true;
        this.licenseNumericUpDown.Enabled = true;
    }

    private void DisableEditableControls() {
        this.nomTextBox.Enabled = false;
        this.prenomTextBox.Enabled = false;
        this.licenseNumericUpDown.Enabled = false;
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
                Medecin newMedecin = new Medecin(
                    this.nomTextBox.Text.Trim(),
                    this.prenomTextBox.Text.Trim(),
                    this.licenseNumericUpDown.Text.Trim()
                );
                this.currentInstance = this.application.MedecinService.Create(newMedecin);
                break;
            case ViewActionsEnum.Visualization:
                // do nothing on visualization
                break;
            case ViewActionsEnum.Edition:
                if (this.currentInstance == null) {
                    throw new Exception("No current instance of [Medecin] loaded.");
                }
                this.currentInstance.Nom = this.nomTextBox.Text.Trim();
                this.currentInstance.Prenom = this.prenomTextBox.Text.Trim();
                this.currentInstance.NumLicenseMedicale = this.licenseNumericUpDown.Text.Trim();
                this.currentInstance = this.application.MedecinService.Update(this.currentInstance);
                break;
            case ViewActionsEnum.Deletion:
                if (this.currentInstance == null) {
                    throw new Exception("No current instance of [Medecin] loaded.");
                }
                this.application.MedecinService.Delete(this.currentInstance);
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
